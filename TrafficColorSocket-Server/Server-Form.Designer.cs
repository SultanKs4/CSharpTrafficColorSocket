namespace TrafficColorSocket_Server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonListen = new System.Windows.Forms.Button();
            this.panelMerah = new System.Windows.Forms.Panel();
            this.panelKuning = new System.Windows.Forms.Panel();
            this.panelHijau = new System.Windows.Forms.Panel();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(80, 10);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAddress.TabIndex = 3;
            this.textBoxIPAddress.Text = "192.168.40.8";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(80, 36);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.Text = "16359";
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(90, 72);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(75, 23);
            this.buttonListen.TabIndex = 5;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // panelMerah
            // 
            this.panelMerah.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelMerah.Location = new System.Drawing.Point(16, 140);
            this.panelMerah.Name = "panelMerah";
            this.panelMerah.Size = new System.Drawing.Size(228, 35);
            this.panelMerah.TabIndex = 6;
            // 
            // panelKuning
            // 
            this.panelKuning.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelKuning.Location = new System.Drawing.Point(16, 181);
            this.panelKuning.Name = "panelKuning";
            this.panelKuning.Size = new System.Drawing.Size(228, 35);
            this.panelKuning.TabIndex = 7;
            // 
            // panelHijau
            // 
            this.panelHijau.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelHijau.Location = new System.Drawing.Point(16, 222);
            this.panelHijau.Name = "panelHijau";
            this.panelHijau.Size = new System.Drawing.Size(228, 35);
            this.panelHijau.TabIndex = 7;
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Enabled = false;
            this.textBoxPesan.Location = new System.Drawing.Point(80, 114);
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.ReadOnly = true;
            this.textBoxPesan.Size = new System.Drawing.Size(123, 20);
            this.textBoxPesan.TabIndex = 8;
            this.textBoxPesan.Text = "Semua Lampu Mati";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 270);
            this.Controls.Add(this.textBoxPesan);
            this.Controls.Add(this.panelHijau);
            this.Controls.Add(this.panelKuning);
            this.Controls.Add(this.panelMerah);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Traffic Color Socket Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Panel panelMerah;
        private System.Windows.Forms.Panel panelKuning;
        private System.Windows.Forms.Panel panelHijau;
        private System.Windows.Forms.Timer timerServer;
        private System.Windows.Forms.TextBox textBoxPesan;
    }
}

