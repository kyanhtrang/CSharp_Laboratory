namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai4_Client
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
            this.MessageText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.MessageShow = new System.Windows.Forms.ListView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(124, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(352, 45);
            this.Title.TabIndex = 1;
            this.Title.Text = "CHAT ROOM - CLIENT";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(25, 400);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(450, 30);
            this.MessageText.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(500, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.BackColor = System.Drawing.Color.Transparent;
            this.ClientName.Location = new System.Drawing.Point(25, 75);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(109, 23);
            this.ClientName.TabIndex = 5;
            this.ClientName.Text = "Client Name:";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(140, 75);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(325, 27);
            this.NameInput.TabIndex = 6;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // MessageShow
            // 
            this.MessageShow.HideSelection = false;
            this.MessageShow.Location = new System.Drawing.Point(25, 110);
            this.MessageShow.Name = "MessageShow";
            this.MessageShow.Size = new System.Drawing.Size(550, 275);
            this.MessageShow.TabIndex = 7;
            this.MessageShow.UseCompatibleStateImageBehavior = false;
            this.MessageShow.View = System.Windows.Forms.View.List;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(475, 74);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // LAB3_Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.MessageShow);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai4_Client";
            this.ShowIcon = false;
            this.Text = "Bài thực hành 3 - Nhóm 1 - Bài 4 - Client";
            this.Load += new System.EventHandler(this.LAB3_Bai4_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.ListView MessageShow;
        private System.Windows.Forms.Button btnConnect;
    }
}