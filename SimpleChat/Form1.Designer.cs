namespace SimpleChat
{
    partial class GeekChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeekChat));
            this.groupBoxClient1 = new System.Windows.Forms.GroupBox();
            this.localPortLabel = new System.Windows.Forms.Label();
            this.localIpLabel = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.groupBoxClient2 = new System.Windows.Forms.GroupBox();
            this.remotePortLabel = new System.Windows.Forms.Label();
            this.remoteIpLabel = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.attacth = new System.Windows.Forms.Button();
            this.groupBoxClient1.SuspendLayout();
            this.groupBoxClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient1
            // 
            this.groupBoxClient1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBoxClient1, "groupBoxClient1");
            this.groupBoxClient1.Controls.Add(this.localPortLabel);
            this.groupBoxClient1.Controls.Add(this.localIpLabel);
            this.groupBoxClient1.Controls.Add(this.textLocalPort);
            this.groupBoxClient1.Controls.Add(this.textLocalIP);
            this.groupBoxClient1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxClient1.Name = "groupBoxClient1";
            this.groupBoxClient1.TabStop = false;
            this.groupBoxClient1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // localPortLabel
            // 
            resources.ApplyResources(this.localPortLabel, "localPortLabel");
            this.localPortLabel.Name = "localPortLabel";
            // 
            // localIpLabel
            // 
            resources.ApplyResources(this.localIpLabel, "localIpLabel");
            this.localIpLabel.Name = "localIpLabel";
            // 
            // textLocalPort
            // 
            resources.ApplyResources(this.textLocalPort, "textLocalPort");
            this.textLocalPort.Name = "textLocalPort";
            // 
            // textLocalIP
            // 
            resources.ApplyResources(this.textLocalIP, "textLocalIP");
            this.textLocalIP.Name = "textLocalIP";
            // 
            // groupBoxClient2
            // 
            this.groupBoxClient2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.groupBoxClient2, "groupBoxClient2");
            this.groupBoxClient2.Controls.Add(this.remotePortLabel);
            this.groupBoxClient2.Controls.Add(this.remoteIpLabel);
            this.groupBoxClient2.Controls.Add(this.textRemotePort);
            this.groupBoxClient2.Controls.Add(this.textRemoteIP);
            this.groupBoxClient2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxClient2.Name = "groupBoxClient2";
            this.groupBoxClient2.TabStop = false;
            // 
            // remotePortLabel
            // 
            resources.ApplyResources(this.remotePortLabel, "remotePortLabel");
            this.remotePortLabel.Name = "remotePortLabel";
            // 
            // remoteIpLabel
            // 
            resources.ApplyResources(this.remoteIpLabel, "remoteIpLabel");
            this.remoteIpLabel.Name = "remoteIpLabel";
            // 
            // textRemotePort
            // 
            resources.ApplyResources(this.textRemotePort, "textRemotePort");
            this.textRemotePort.Name = "textRemotePort";
            // 
            // textRemoteIP
            // 
            resources.ApplyResources(this.textRemoteIP, "textRemoteIP");
            this.textRemoteIP.Name = "textRemoteIP";
            // 
            // textBoxSend
            // 
            resources.ApplyResources(this.textBoxSend, "textBoxSend");
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBoxSend_TextChanged);
            this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
            // 
            // messageListBox
            // 
            this.messageListBox.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.messageListBox, "messageListBox");
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.Name = "messageListBox";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // sendButton
            // 
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sendButton.Name = "sendButton";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // attacth
            // 
            resources.ApplyResources(this.attacth, "attacth");
            this.attacth.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.attacth.Name = "attacth";
            this.attacth.UseVisualStyleBackColor = true;
            this.attacth.Click += new System.EventHandler(this.button2_Click);
            // 
            // GeekChat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attacth);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.groupBoxClient2);
            this.Controls.Add(this.groupBoxClient1);
            this.Name = "GeekChat";
            this.groupBoxClient1.ResumeLayout(false);
            this.groupBoxClient1.PerformLayout();
            this.groupBoxClient2.ResumeLayout(false);
            this.groupBoxClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient1;
        private System.Windows.Forms.Label localPortLabel;
        private System.Windows.Forms.Label localIpLabel;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.GroupBox groupBoxClient2;
        private System.Windows.Forms.Label remotePortLabel;
        private System.Windows.Forms.Label remoteIpLabel;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button attacth;
    }
}

