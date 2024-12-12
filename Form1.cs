using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Für die Netzwerkzugriffe
using System.Net;
using System.Net.Sockets;

// Für das Threading
using System.Threading;


namespace Server
{
    public partial class Form : System.Windows.Forms.Form
    {
        private TcpListener meinServer = null;
        private Thread threadWarteAufKlienten = null;
        private List<TcpClient> clientList = new List<TcpClient>();

        public Form()
        {
            InitializeComponent();
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        { 
            starteServer();
        }

        private void starteServer()
        {
            if (meinServer == null)
            { // Server existiert noch nicht
                try
                {
                    meinServer = new TcpListener(IPAddress.Parse(txtIPAdresse.Text), 
                                                 Convert.ToInt32(txtPort.Text));
                    meinServer.Start();

                    threadWarteAufKlienten = new Thread(warteAufKlienten);
                    threadWarteAufKlienten.Start();
                    
                    lblServerStatus.Text = "Server gestartet";
                    txtIPAdresse.Enabled = false;
                    txtPort.Enabled = false;
                    protokoll("Server gestartet");
                }
                catch (Exception ausnahme)
                {
                    MessageBox.Show(this,
                        "Fehler beim Starten des Servers!\n" + ausnahme.Message,
                        "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    meinServer = null;
                }
            }
        }

        private void btnServerStopp_Click(object sender, EventArgs e)
        {
            stoppeServer();
        }
        private void stoppeServer()
        {
            if (meinServer != null)
            { // Server existiert schon
                try
                {
                    meinServer.Stop();

                    if (threadWarteAufKlienten.IsAlive)
                    {
                        threadWarteAufKlienten.Abort();
                    }

                    while (clientList.Count > 0)
                    {
                        clientList[0].Close();
                        clientList.RemoveAt(0); 
                    }
                    lblServerStatus.Text = "Server gestoppt";
                    txtIPAdresse.Enabled = true;
                    txtPort.Enabled = true;
                    protokoll("Server gestoppt");
                }
                catch (Exception ausnahme)
                {
                    MessageBox.Show(this,
                        "Fehler beim Stoppen des Servers!\n" + ausnahme.Message,
                        "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                meinServer = null;
            }
        }

        private void protokoll(string text)
        {
            lstProtokoll.Invoke( (MethodInvoker) delegate { 
                lstProtokoll.Items.Add(text);
            });
        }

        private void btnClearAusgabe_Click(object sender, EventArgs e)
        {
            lstProtokoll.Items.Clear();
        }

        private void warteAufKlienten()
        {
            bool ende = false;
            TcpClient neuerKlient = null;
            string sendeText = "Hallo neuer Klient!\n";
            do
            {
                try
                {
                    neuerKlient = meinServer.AcceptTcpClient();
                    neuerKlient.GetStream().Write(Encoding.ASCII.GetBytes(sendeText), 0, sendeText.Length);
                    clientList.Add(neuerKlient);
                    updateClientList();

                    new Thread(empfangeVomKlienten).Start(neuerKlient);

                    string ipAdresse = neuerKlient.Client.RemoteEndPoint.ToString();
                    ipAdresse = ipAdresse.Substring(0, ipAdresse.IndexOf(":"));
                    sendeAnAlle("neuer Klient: " + ipAdresse);

                }
                catch (Exception)
                {
                    ende = true;
                }            
            } while (!ende);
        }

        private void sendeAnAlle(string text)
        {
            List<TcpClient> abgemeldet = new List<TcpClient>();

            protokoll(text);
            text = text.Trim();
            text += "\n";
            if (string.IsNullOrEmpty(text)) { return; }
            foreach (TcpClient klient in clientList)
            {
                try
                {
                    if (klient.Connected) 
                    { 
                        klient.GetStream().Write(Encoding.ASCII.GetBytes((string)text), 0, text.Length);
                    }
                    else
                    {
                        abgemeldet.Add(klient);
                    }
                }
                catch (Exception)
                {
                }            
            }
            for (int i = 0; i < abgemeldet.Count; i++) 
            {
                int index = clientList.IndexOf(abgemeldet[i]);
                if (index != -1) 
                {
                    clientList.RemoveAt(index);
                }
            }
        }

        private void empfangeVomKlienten(object uebergabe)
        {
            TcpClient Klient = (TcpClient) uebergabe;
            string ipAdresse = Klient.Client.RemoteEndPoint.ToString();
            ipAdresse = ipAdresse.Substring(0, ipAdresse.IndexOf(":"));
            string empfangen = "";
            while (true)
            {
                try
                {
                    char zeichen = (char)Klient.GetStream().ReadByte();
                    if (zeichen == '\n')
                    {
                        // Übertragung komplett
                        sendeAnAlle(ipAdresse + ": " + empfangen);
                        empfangen = "";
                    }
                    else
                    {
                        empfangen += zeichen;
                    }

                }
                catch (Exception)
                {
                    break;
                }            
            }
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            sendeAnAlle(txtSenden.Text);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult antwort;
            antwort = MessageBox.Show(this, "Wollen Sie das Programm beenden?", 
                "Progamm beenden", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (antwort != DialogResult.Yes)
            {
                e. Cancel = true;
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            stoppeServer();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            updateClientList();
        }

        private void updateClientList()
        {
            lstClient.Items.Clear();
            foreach (TcpClient klient in clientList)
            {
                lstClient.Items.Add(klient.Client.RemoteEndPoint);
            }
        }
    }
}
