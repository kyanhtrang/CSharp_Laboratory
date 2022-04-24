namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai3_Server
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
            this.lstShow = new System.Windows.Forms.ListView();
            this.btnListen = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstShow
            // 
            this.lstShow.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShow.HideSelection = false;
            this.lstShow.Location = new System.Drawing.Point(25, 125);
            this.lstShow.Margin = new System.Windows.Forms.Padding(2);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(550, 300);
            this.lstShow.TabIndex = 6;
            this.lstShow.UseCompatibleStateImageBehavior = false;
            this.lstShow.View = System.Windows.Forms.View.List;
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(425, 75);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(150, 35);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(195, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(202, 45);
            this.Title.TabIndex = 7;
            this.Title.Text = "TCP SERVER";
            // 
            // LAB3_Bai3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.btnListen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LAB3_Bai3_Server";
            this.ShowIcon = false;
            this.Text = "Bài tập thực hành 3 - Nhóm 1 - Bài 3 - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstShow;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label Title;
    }
}