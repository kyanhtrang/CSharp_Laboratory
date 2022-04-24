namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai1_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB3_Bai1_Server));
            this.Title = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.PortServer = new System.Windows.Forms.TextBox();
            this.Warning = new System.Windows.Forms.Label();
            this.MessageShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(202, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(211, 45);
            this.Title.TabIndex = 1;
            this.Title.Text = "UDP SERVER";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(475, 80);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(365, 80);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 35);
            this.btnListen.TabIndex = 7;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.BackColor = System.Drawing.Color.Transparent;
            this.Port.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(25, 85);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 23);
            this.Port.TabIndex = 8;
            this.Port.Text = "Port Server:";
            // 
            // PortServer
            // 
            this.PortServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortServer.Location = new System.Drawing.Point(150, 83);
            this.PortServer.Name = "PortServer";
            this.PortServer.Size = new System.Drawing.Size(200, 27);
            this.PortServer.TabIndex = 9;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.Color.Transparent;
            this.Warning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(25, 110);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 13);
            this.Warning.TabIndex = 10;
            // 
            // MessageShow
            // 
            this.MessageShow.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageShow.Location = new System.Drawing.Point(25, 135);
            this.MessageShow.Multiline = true;
            this.MessageShow.Name = "MessageShow";
            this.MessageShow.Size = new System.Drawing.Size(550, 300);
            this.MessageShow.TabIndex = 11;
            // 
            // LAB3_Bai1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.MessageShow);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.PortServer);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai1_Server";
            this.ShowIcon = false;
            this.Text = "Bài tập thực hành 3 - Nhóm 1 - Bài 1 - Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LAB3_Bai1_Server_FormClosed);
            this.Load += new System.EventHandler(this.LAB3_Bai1_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox PortServer;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.TextBox MessageShow;
    }
}