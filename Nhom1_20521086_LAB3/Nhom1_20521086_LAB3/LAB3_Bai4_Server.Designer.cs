namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai4_Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.MessageShow = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(120, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(360, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "CHAT ROOM - SERVER";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(425, 82);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(150, 35);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // MessageShow
            // 
            this.MessageShow.HideSelection = false;
            this.MessageShow.Location = new System.Drawing.Point(25, 125);
            this.MessageShow.Name = "MessageShow";
            this.MessageShow.Size = new System.Drawing.Size(550, 300);
            this.MessageShow.TabIndex = 4;
            this.MessageShow.UseCompatibleStateImageBehavior = false;
            this.MessageShow.View = System.Windows.Forms.View.List;
            // 
            // LAB3_Bai4_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.MessageShow);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai4_Server";
            this.ShowIcon = false;
            this.Text = "Bài thực hành 3 - Nhóm 1 - Bài 4 - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView MessageShow;
    }
}