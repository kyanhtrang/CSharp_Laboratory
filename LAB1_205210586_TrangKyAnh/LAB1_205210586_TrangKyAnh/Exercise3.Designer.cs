namespace LAB1_205210586_TrangKyAnh
{
    partial class Exercise3
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
            this.getRes = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.TextRes = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Title.Location = new System.Drawing.Point(308, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(196, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "ĐỌC SỐ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getRes
            // 
            this.getRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRes.Location = new System.Drawing.Point(51, 350);
            this.getRes.Name = "getRes";
            this.getRes.Size = new System.Drawing.Size(100, 35);
            this.getRes.TabIndex = 9;
            this.getRes.Text = "Đọc";
            this.getRes.UseVisualStyleBackColor = true;
            this.getRes.Click += new System.EventHandler(this.getRes_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(350, 350);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 35);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Xóa";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(675, 350);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 35);
            this.Close.TabIndex = 11;
            this.Close.Text = "Thoát";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TextRes
            // 
            this.TextRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextRes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRes.Location = new System.Drawing.Point(175, 250);
            this.TextRes.Name = "TextRes";
            this.TextRes.Size = new System.Drawing.Size(575, 32);
            this.TextRes.TabIndex = 12;
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(50, 250);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(101, 26);
            this.Result.TabIndex = 13;
            this.Result.Text = "Kết quả:";
            // 
            // Number
            // 
            this.Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Number.AutoSize = true;
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(50, 150);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(383, 26);
            this.Number.TabIndex = 14;
            this.Number.Text = "Nhập vào một số bất kỳ từ 0 đến 9:";
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(450, 150);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(300, 32);
            this.NumberBox.TabIndex = 15;
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1_205210586_TrangKyAnh.Properties.Resources.yuriy_kovalev_nN1HSDtKdlw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TextRes);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.getRes);
            this.Controls.Add(this.Title);
            this.Name = "Exercise3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 - 20521086 - Trang Kỳ Anh - Exercise 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button getRes;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox TextRes;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox NumberBox;
    }
}