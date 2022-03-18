namespace LAB1_205210586_TrangKyAnh
{
    partial class Exercise4
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
            this.Select = new System.Windows.Forms.ComboBox();
            this.Money = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.display1 = new System.Windows.Forms.Label();
            this.ShowBox = new System.Windows.Forms.TextBox();
            this.GetRes = new System.Windows.Forms.Button();
            this.display2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Title.Location = new System.Drawing.Point(169, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(484, 51);
            this.Title.TabIndex = 1;
            this.Title.Text = "CHUYỂN ĐỔI TIỀN TỆ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Select
            // 
            this.Select.AllowDrop = true;
            this.Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.FormattingEnabled = true;
            this.Select.Items.AddRange(new object[] {
            "USD",
            "EUR ",
            "GBP",
            "SGD",
            "JPY"});
            this.Select.Location = new System.Drawing.Point(550, 100);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(200, 30);
            this.Select.TabIndex = 2;
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.BackColor = System.Drawing.Color.Transparent;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(25, 100);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(194, 29);
            this.Money.TabIndex = 3;
            this.Money.Text = "Số tiền cần đổi:";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.BackColor = System.Drawing.Color.Transparent;
            this.Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency.Location = new System.Drawing.Point(450, 100);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(93, 29);
            this.Currency.TabIndex = 4;
            this.Currency.Text = "Đơn vị:";
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(225, 100);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(200, 32);
            this.NumberBox.TabIndex = 16;
            // 
            // display1
            // 
            this.display1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.display1.AutoSize = true;
            this.display1.BackColor = System.Drawing.Color.Transparent;
            this.display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.Location = new System.Drawing.Point(25, 250);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(182, 29);
            this.display1.TabIndex = 17;
            this.display1.Text = "Số tiền đã đổi:";
            // 
            // ShowBox
            // 
            this.ShowBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ShowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBox.Location = new System.Drawing.Point(225, 250);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(325, 32);
            this.ShowBox.TabIndex = 18;
            // 
            // GetRes
            // 
            this.GetRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRes.Location = new System.Drawing.Point(25, 150);
            this.GetRes.Name = "GetRes";
            this.GetRes.Size = new System.Drawing.Size(725, 35);
            this.GetRes.TabIndex = 19;
            this.GetRes.Text = "Chuyển đổi";
            this.GetRes.UseVisualStyleBackColor = true;
            // 
            // display2
            // 
            this.display2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.display2.AutoSize = true;
            this.display2.BackColor = System.Drawing.Color.Transparent;
            this.display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display2.Location = new System.Drawing.Point(25, 350);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(179, 29);
            this.display2.TabIndex = 20;
            this.display2.Text = "Tỉ giá quy đổi:";
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(650, 250);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 35);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Xóa";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(650, 350);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 35);
            this.Close.TabIndex = 22;
            this.Close.Text = "Thoát";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Exercise4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1_205210586_TrangKyAnh.Properties.Resources.yuriy_kovalev_nN1HSDtKdlw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.GetRes);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Exercise4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 - 20521086 - Trang Kỳ Anh - Exercise 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox Select;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label Currency;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label display1;
        private System.Windows.Forms.TextBox ShowBox;
        private System.Windows.Forms.Button GetRes;
        private System.Windows.Forms.Label display2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
    }
}