namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai1_Client
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
            this.Title = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.PortServer = new System.Windows.Forms.TextBox();
            this.IPServer = new System.Windows.Forms.TextBox();
            this.IPWarning = new System.Windows.Forms.Label();
            this.PortWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(260, 31);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(252, 54);
            this.Title.TabIndex = 2;
            this.Title.Text = "UDP CLIENT";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(667, 492);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 37);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MessageText
            // 
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.Location = new System.Drawing.Point(33, 166);
            this.MessageText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(732, 307);
            this.MessageText.TabIndex = 6;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.BackColor = System.Drawing.Color.Transparent;
            this.IP.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(33, 96);
            this.IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(108, 30);
            this.IP.TabIndex = 7;
            this.IP.Text = "IP Server:";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.BackColor = System.Drawing.Color.Transparent;
            this.Port.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(467, 96);
            this.Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(131, 30);
            this.Port.TabIndex = 8;
            this.Port.Text = "Port Server:";
            // 
            // PortServer
            // 
            this.PortServer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortServer.Location = new System.Drawing.Point(600, 92);
            this.PortServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortServer.Name = "PortServer";
            this.PortServer.Size = new System.Drawing.Size(165, 36);
            this.PortServer.TabIndex = 10;
            // 
            // IPServer
            // 
            this.IPServer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServer.Location = new System.Drawing.Point(147, 92);
            this.IPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPServer.Name = "IPServer";
            this.IPServer.Size = new System.Drawing.Size(299, 36);
            this.IPServer.TabIndex = 11;
            // 
            // IPWarning
            // 
            this.IPWarning.AutoSize = true;
            this.IPWarning.BackColor = System.Drawing.Color.Transparent;
            this.IPWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPWarning.ForeColor = System.Drawing.Color.Red;
            this.IPWarning.Location = new System.Drawing.Point(33, 135);
            this.IPWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPWarning.Name = "IPWarning";
            this.IPWarning.Size = new System.Drawing.Size(0, 19);
            this.IPWarning.TabIndex = 12;
            // 
            // PortWarning
            // 
            this.PortWarning.AutoSize = true;
            this.PortWarning.BackColor = System.Drawing.Color.Transparent;
            this.PortWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortWarning.ForeColor = System.Drawing.Color.Red;
            this.PortWarning.Location = new System.Drawing.Point(467, 135);
            this.PortWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortWarning.Name = "PortWarning";
            this.PortWarning.Size = new System.Drawing.Size(0, 19);
            this.PortWarning.TabIndex = 13;
            // 
            // LAB3_Bai1_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.PortWarning);
            this.Controls.Add(this.IPWarning);
            this.Controls.Add(this.IPServer);
            this.Controls.Add(this.PortServer);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai1_Client";
            this.ShowIcon = false;
            this.Text = "Bài tập thực hành 3 - Nhóm 1 - Bài 1 - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox PortServer;
        private System.Windows.Forms.TextBox IPServer;
        private System.Windows.Forms.Label IPWarning;
        private System.Windows.Forms.Label PortWarning;
    }
}