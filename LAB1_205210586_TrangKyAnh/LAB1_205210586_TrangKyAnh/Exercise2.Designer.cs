namespace LAB1_205210586_TrangKyAnh
{
    partial class Exercise2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Firstnum = new System.Windows.Forms.Label();
            this.Secondnum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Thirdnum = new System.Windows.Forms.Label();
            this.Maxnum = new System.Windows.Forms.Label();
            this.Minnum = new System.Windows.Forms.Label();
            this.firstInt = new System.Windows.Forms.TextBox();
            this.SecondInt = new System.Windows.Forms.TextBox();
            this.ThirdInt = new System.Windows.Forms.TextBox();
            this.MaxRes = new System.Windows.Forms.TextBox();
            this.MinRes = new System.Windows.Forms.TextBox();
            this.getRes = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM SỐ LỚN NHẤT - NHỎ NHẤT";
            // 
            // Firstnum
            // 
            this.Firstnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstnum.AutoSize = true;
            this.Firstnum.BackColor = System.Drawing.Color.Transparent;
            this.Firstnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnum.Location = new System.Drawing.Point(50, 100);
            this.Firstnum.Name = "Firstnum";
            this.Firstnum.Size = new System.Drawing.Size(141, 26);
            this.Firstnum.TabIndex = 3;
            this.Firstnum.Text = "Số thứ nhất:";
            // 
            // Secondnum
            // 
            this.Secondnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Secondnum.AutoSize = true;
            this.Secondnum.BackColor = System.Drawing.Color.Transparent;
            this.Secondnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondnum.Location = new System.Drawing.Point(50, 150);
            this.Secondnum.Name = "Secondnum";
            this.Secondnum.Size = new System.Drawing.Size(127, 26);
            this.Secondnum.TabIndex = 4;
            this.Secondnum.Text = "Số thứ hai:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(50, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thirdnum
            // 
            this.Thirdnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thirdnum.AutoSize = true;
            this.Thirdnum.BackColor = System.Drawing.Color.Transparent;
            this.Thirdnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thirdnum.Location = new System.Drawing.Point(50, 200);
            this.Thirdnum.Name = "Thirdnum";
            this.Thirdnum.Size = new System.Drawing.Size(121, 26);
            this.Thirdnum.TabIndex = 6;
            this.Thirdnum.Text = "Số thứ ba:";
            // 
            // Maxnum
            // 
            this.Maxnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Maxnum.AutoSize = true;
            this.Maxnum.BackColor = System.Drawing.Color.Transparent;
            this.Maxnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxnum.Location = new System.Drawing.Point(50, 325);
            this.Maxnum.Name = "Maxnum";
            this.Maxnum.Size = new System.Drawing.Size(140, 26);
            this.Maxnum.TabIndex = 7;
            this.Maxnum.Text = "Số lớn nhất:";
            // 
            // Minnum
            // 
            this.Minnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Minnum.AutoSize = true;
            this.Minnum.BackColor = System.Drawing.Color.Transparent;
            this.Minnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minnum.Location = new System.Drawing.Point(50, 375);
            this.Minnum.Name = "Minnum";
            this.Minnum.Size = new System.Drawing.Size(147, 26);
            this.Minnum.TabIndex = 8;
            this.Minnum.Text = "Số nhỏ nhất:";
            // 
            // firstInt
            // 
            this.firstInt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstInt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.firstInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstInt.Location = new System.Drawing.Point(250, 100);
            this.firstInt.Name = "firstInt";
            this.firstInt.Size = new System.Drawing.Size(400, 32);
            this.firstInt.TabIndex = 9;
            // 
            // SecondInt
            // 
            this.SecondInt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondInt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SecondInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondInt.Location = new System.Drawing.Point(250, 150);
            this.SecondInt.Name = "SecondInt";
            this.SecondInt.Size = new System.Drawing.Size(400, 32);
            this.SecondInt.TabIndex = 10;
            // 
            // ThirdInt
            // 
            this.ThirdInt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThirdInt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ThirdInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdInt.Location = new System.Drawing.Point(250, 200);
            this.ThirdInt.Name = "ThirdInt";
            this.ThirdInt.Size = new System.Drawing.Size(400, 32);
            this.ThirdInt.TabIndex = 11;
            // 
            // MaxRes
            // 
            this.MaxRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxRes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRes.Location = new System.Drawing.Point(250, 325);
            this.MaxRes.Name = "MaxRes";
            this.MaxRes.Size = new System.Drawing.Size(520, 32);
            this.MaxRes.TabIndex = 12;
            // 
            // MinRes
            // 
            this.MinRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinRes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinRes.Location = new System.Drawing.Point(250, 375);
            this.MinRes.Name = "MinRes";
            this.MinRes.Size = new System.Drawing.Size(520, 32);
            this.MinRes.TabIndex = 13;
            // 
            // getRes
            // 
            this.getRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRes.Location = new System.Drawing.Point(675, 100);
            this.getRes.Name = "getRes";
            this.getRes.Size = new System.Drawing.Size(100, 35);
            this.getRes.TabIndex = 14;
            this.getRes.Text = "Tìm";
            this.getRes.UseVisualStyleBackColor = true;
            this.getRes.Click += new System.EventHandler(this.getRes_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(675, 150);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 35);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Xóa";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(675, 200);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 35);
            this.Close.TabIndex = 16;
            this.Close.Text = "Thoát";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1_205210586_TrangKyAnh.Properties.Resources.yuriy_kovalev_nN1HSDtKdlw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.getRes);
            this.Controls.Add(this.MinRes);
            this.Controls.Add(this.MaxRes);
            this.Controls.Add(this.ThirdInt);
            this.Controls.Add(this.SecondInt);
            this.Controls.Add(this.firstInt);
            this.Controls.Add(this.Minnum);
            this.Controls.Add(this.Maxnum);
            this.Controls.Add(this.Thirdnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Secondnum);
            this.Controls.Add(this.Firstnum);
            this.Controls.Add(this.label1);
            this.Name = "Exercise2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 - 20521086 - Trang Kỳ Anh - Exercise 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Firstnum;
        private System.Windows.Forms.Label Secondnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Thirdnum;
        private System.Windows.Forms.Label Maxnum;
        private System.Windows.Forms.Label Minnum;
        private System.Windows.Forms.TextBox firstInt;
        private System.Windows.Forms.TextBox SecondInt;
        private System.Windows.Forms.TextBox ThirdInt;
        private System.Windows.Forms.TextBox MaxRes;
        private System.Windows.Forms.TextBox MinRes;
        private System.Windows.Forms.Button getRes;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
    }
}