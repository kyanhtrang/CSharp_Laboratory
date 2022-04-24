namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai3_Client
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
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.lblRemoteIP = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(25, 215);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(550, 175);
            this.txtMessages.TabIndex = 17;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.BackColor = System.Drawing.Color.Transparent;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(25, 190);
            this.lblMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(74, 20);
            this.lblMessages.TabIndex = 16;
            this.lblMessages.Text = "Messages";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(475, 400);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(475, 145);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 35);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(475, 95);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(165, 150);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(300, 27);
            this.txtPort.TabIndex = 12;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.BackColor = System.Drawing.Color.Transparent;
            this.lblRemotePort.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemotePort.Location = new System.Drawing.Point(25, 150);
            this.lblRemotePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(110, 23);
            this.lblRemotePort.TabIndex = 11;
            this.lblRemotePort.Text = "Remote Port:";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoteIP.Location = new System.Drawing.Point(165, 98);
            this.txtRemoteIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(300, 27);
            this.txtRemoteIP.TabIndex = 10;
            // 
            // lblRemoteIP
            // 
            this.lblRemoteIP.AutoSize = true;
            this.lblRemoteIP.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoteIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoteIP.Location = new System.Drawing.Point(25, 100);
            this.lblRemoteIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoteIP.Name = "lblRemoteIP";
            this.lblRemoteIP.Size = new System.Drawing.Size(132, 23);
            this.lblRemoteIP.TabIndex = 9;
            this.lblRemoteIP.Text = "IP Remote host:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(203, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(194, 45);
            this.Title.TabIndex = 18;
            this.Title.Text = "TCP CLIENT";
            // 
            // LAB3_Bai3_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblRemotePort);
            this.Controls.Add(this.txtRemoteIP);
            this.Controls.Add(this.lblRemoteIP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai3_Client";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập thực hành 3 - Nhóm 1 - Bài 3 - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label lblRemoteIP;
        private System.Windows.Forms.Label Title;
    }
}