namespace Server
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServerStopp = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAdresse = new System.Windows.Forms.TextBox();
            this.lstProtokoll = new System.Windows.Forms.ListBox();
            this.btnClearAusgabe = new System.Windows.Forms.Button();
            this.txtSenden = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblServerStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnServerStopp);
            this.panel1.Controls.Add(this.btnServerStart);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIPAdresse);
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 198);
            this.panel1.TabIndex = 0;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(22, 13);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(199, 29);
            this.lblServerStatus.TabIndex = 6;
            this.lblServerStatus.Text = "Server gestoppt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP-Adresse";
            // 
            // btnServerStopp
            // 
            this.btnServerStopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStopp.Location = new System.Drawing.Point(134, 142);
            this.btnServerStopp.Name = "btnServerStopp";
            this.btnServerStopp.Size = new System.Drawing.Size(112, 35);
            this.btnServerStopp.TabIndex = 3;
            this.btnServerStopp.Text = "Stopp";
            this.btnServerStopp.UseVisualStyleBackColor = true;
            this.btnServerStopp.Click += new System.EventHandler(this.btnServerStopp_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStart.Location = new System.Drawing.Point(7, 142);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(121, 35);
            this.btnServerStart.TabIndex = 2;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(101, 93);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(145, 26);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "1234";
            // 
            // txtIPAdresse
            // 
            this.txtIPAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAdresse.Location = new System.Drawing.Point(101, 56);
            this.txtIPAdresse.Name = "txtIPAdresse";
            this.txtIPAdresse.Size = new System.Drawing.Size(145, 26);
            this.txtIPAdresse.TabIndex = 0;
            this.txtIPAdresse.Text = "10.1.122.10";
            // 
            // lstProtokoll
            // 
            this.lstProtokoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProtokoll.FormattingEnabled = true;
            this.lstProtokoll.ItemHeight = 20;
            this.lstProtokoll.Location = new System.Drawing.Point(316, 26);
            this.lstProtokoll.Name = "lstProtokoll";
            this.lstProtokoll.Size = new System.Drawing.Size(314, 404);
            this.lstProtokoll.TabIndex = 1;
            // 
            // btnClearAusgabe
            // 
            this.btnClearAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAusgabe.Location = new System.Drawing.Point(245, 396);
            this.btnClearAusgabe.Name = "btnClearAusgabe";
            this.btnClearAusgabe.Size = new System.Drawing.Size(65, 34);
            this.btnClearAusgabe.TabIndex = 2;
            this.btnClearAusgabe.Text = "Clear";
            this.btnClearAusgabe.UseVisualStyleBackColor = true;
            this.btnClearAusgabe.Click += new System.EventHandler(this.btnClearAusgabe_Click);
            // 
            // txtSenden
            // 
            this.txtSenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenden.Location = new System.Drawing.Point(29, 258);
            this.txtSenden.Name = "txtSenden";
            this.txtSenden.Size = new System.Drawing.Size(243, 26);
            this.txtSenden.TabIndex = 3;
            // 
            // btnSenden
            // 
            this.btnSenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenden.Location = new System.Drawing.Point(29, 303);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 28);
            this.btnSenden.TabIndex = 4;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(677, 394);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnClientUpdate.TabIndex = 5;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // lstClient
            // 
            this.lstClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 20;
            this.lstClient.Location = new System.Drawing.Point(682, 45);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(271, 324);
            this.lstClient.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Klienten";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstClient);
            this.Controls.Add(this.btnClientUpdate);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.txtSenden);
            this.Controls.Add(this.btnClearAusgabe);
            this.Controls.Add(this.lstProtokoll);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            this.Text = "ITA22 Chat-Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServerStopp;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAdresse;
        private System.Windows.Forms.ListBox lstProtokoll;
        private System.Windows.Forms.Button btnClearAusgabe;
        private System.Windows.Forms.TextBox txtSenden;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.Label label3;
    }
}

