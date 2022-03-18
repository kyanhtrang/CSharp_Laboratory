namespace LAB1_205210586_TrangKyAnh
{
    partial class Exercise5
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
            this.NumA = new System.Windows.Forms.Label();
            this.NumberBox1 = new System.Windows.Forms.TextBox();
            this.NumberBox2 = new System.Windows.Forms.TextBox();
            this.NumB = new System.Windows.Forms.Label();
            this.GetRes = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Label();
            this.GiaiThuaA = new System.Windows.Forms.Label();
            this.Sum3 = new System.Windows.Forms.Label();
            this.Sum2 = new System.Windows.Forms.Label();
            this.Sum1 = new System.Windows.Forms.Label();
            this.GiaiThuaB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Title.Location = new System.Drawing.Point(141, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(540, 51);
            this.Title.TabIndex = 2;
            this.Title.Text = "TÍNH TOÁN CÁC GIÁ TRỊ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // NumA
            // 
            this.NumA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumA.AutoSize = true;
            this.NumA.BackColor = System.Drawing.Color.Transparent;
            this.NumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumA.Location = new System.Drawing.Point(50, 100);
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(78, 26);
            this.NumA.TabIndex = 4;
            this.NumA.Text = "Số A: ";
            // 
            // NumberBox1
            // 
            this.NumberBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NumberBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox1.Location = new System.Drawing.Point(125, 100);
            this.NumberBox1.Name = "NumberBox1";
            this.NumberBox1.Size = new System.Drawing.Size(250, 32);
            this.NumberBox1.TabIndex = 17;
            // 
            // NumberBox2
            // 
            this.NumberBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NumberBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox2.Location = new System.Drawing.Point(500, 100);
            this.NumberBox2.Name = "NumberBox2";
            this.NumberBox2.Size = new System.Drawing.Size(250, 32);
            this.NumberBox2.TabIndex = 18;
            // 
            // NumB
            // 
            this.NumB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumB.AutoSize = true;
            this.NumB.BackColor = System.Drawing.Color.Transparent;
            this.NumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumB.Location = new System.Drawing.Point(425, 100);
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(71, 26);
            this.NumB.TabIndex = 19;
            this.NumB.Text = "Số B:";
            // 
            // GetRes
            // 
            this.GetRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRes.Location = new System.Drawing.Point(50, 150);
            this.GetRes.Name = "GetRes";
            this.GetRes.Size = new System.Drawing.Size(400, 35);
            this.GetRes.TabIndex = 20;
            this.GetRes.Text = "Tìm các giá trị";
            this.GetRes.UseVisualStyleBackColor = true;
            this.GetRes.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(500, 150);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 35);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Xóa";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(650, 150);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 35);
            this.Close.TabIndex = 23;
            this.Close.Text = "Thoát";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Res
            // 
            this.Res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Res.AutoSize = true;
            this.Res.BackColor = System.Drawing.Color.Transparent;
            this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res.ForeColor = System.Drawing.Color.OrangeRed;
            this.Res.Location = new System.Drawing.Point(50, 200);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(119, 32);
            this.Res.TabIndex = 24;
            this.Res.Text = "Kết quả";
            // 
            // GiaiThuaA
            // 
            this.GiaiThuaA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GiaiThuaA.AutoSize = true;
            this.GiaiThuaA.BackColor = System.Drawing.Color.Transparent;
            this.GiaiThuaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaiThuaA.Location = new System.Drawing.Point(50, 250);
            this.GiaiThuaA.Name = "GiaiThuaA";
            this.GiaiThuaA.Size = new System.Drawing.Size(0, 26);
            this.GiaiThuaA.TabIndex = 25;
            // 
            // Sum3
            // 
            this.Sum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sum3.AutoSize = true;
            this.Sum3.BackColor = System.Drawing.Color.Transparent;
            this.Sum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum3.Location = new System.Drawing.Point(50, 400);
            this.Sum3.Name = "Sum3";
            this.Sum3.Size = new System.Drawing.Size(0, 26);
            this.Sum3.TabIndex = 26;
            // 
            // Sum2
            // 
            this.Sum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sum2.AutoSize = true;
            this.Sum2.BackColor = System.Drawing.Color.Transparent;
            this.Sum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum2.Location = new System.Drawing.Point(50, 350);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(0, 26);
            this.Sum2.TabIndex = 27;
            // 
            // Sum1
            // 
            this.Sum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sum1.AutoSize = true;
            this.Sum1.BackColor = System.Drawing.Color.Transparent;
            this.Sum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum1.Location = new System.Drawing.Point(50, 300);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(0, 26);
            this.Sum1.TabIndex = 28;
            // 
            // GiaiThuaB
            // 
            this.GiaiThuaB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GiaiThuaB.AutoSize = true;
            this.GiaiThuaB.BackColor = System.Drawing.Color.Transparent;
            this.GiaiThuaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaiThuaB.Location = new System.Drawing.Point(450, 250);
            this.GiaiThuaB.Name = "GiaiThuaB";
            this.GiaiThuaB.Size = new System.Drawing.Size(0, 26);
            this.GiaiThuaB.TabIndex = 29;
            // 
            // Exercise5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1_205210586_TrangKyAnh.Properties.Resources.yuriy_kovalev_nN1HSDtKdlw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GiaiThuaB);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum3);
            this.Controls.Add(this.GiaiThuaA);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.GetRes);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.NumberBox2);
            this.Controls.Add(this.NumberBox1);
            this.Controls.Add(this.NumA);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Exercise5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 - 20521086 - Trang Kỳ Anh - Exercise 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NumA;
        private System.Windows.Forms.TextBox NumberBox1;
        private System.Windows.Forms.TextBox NumberBox2;
        private System.Windows.Forms.Label NumB;
        private System.Windows.Forms.Button GetRes;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label GiaiThuaA;
        private System.Windows.Forms.Label Sum3;
        private System.Windows.Forms.Label Sum2;
        private System.Windows.Forms.Label Sum1;
        private System.Windows.Forms.Label GiaiThuaB;
    }
}