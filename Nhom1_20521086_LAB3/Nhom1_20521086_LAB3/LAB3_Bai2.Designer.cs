namespace Nhom1_20521086_LAB3
{
    partial class LAB3_Bai2
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
            this.lvShow = new System.Windows.Forms.ListView();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(33, 154);
            this.lvShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(732, 368);
            this.lvShow.TabIndex = 2;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.List;
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(400, 98);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(167, 43);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 98);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(253, 31);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 54);
            this.Title.TabIndex = 5;
            this.Title.Text = "LAB 3 - BÀI 2";
            // 
            // LAB3_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom1_20521086_LAB3.Properties.Resources.background_6517956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lvShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LAB3_Bai2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập thực hành 3 - Nhóm 1 - Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Title;
    }
}