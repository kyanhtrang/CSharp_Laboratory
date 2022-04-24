namespace LAB2_20521086_TrangKyAnh
{
    partial class Lab02_Bai5
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
            this.ListShow = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = new System.Windows.Forms.Label();
            this.PathShow = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Title.Location = new System.Drawing.Point(218, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(363, 46);
            this.Title.TabIndex = 2;
            this.Title.Text = "DUYỆT THƯ MỤC";
            // 
            // ListShow
            // 
            this.ListShow.AutoArrange = false;
            this.ListShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Size,
            this.Type,
            this.Date});
            this.ListShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListShow.HideSelection = false;
            this.ListShow.Location = new System.Drawing.Point(25, 150);
            this.ListShow.Name = "ListShow";
            this.ListShow.Scrollable = false;
            this.ListShow.Size = new System.Drawing.Size(750, 275);
            this.ListShow.TabIndex = 3;
            this.ListShow.TabStop = false;
            this.ListShow.UseCompatibleStateImageBehavior = false;
            this.ListShow.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 250;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date Modified";
            this.Date.Width = 150;
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.BackColor = System.Drawing.Color.Transparent;
            this.Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Path.Location = new System.Drawing.Point(25, 105);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(57, 22);
            this.Path.TabIndex = 4;
            this.Path.Text = "Path: ";
            // 
            // PathShow
            // 
            this.PathShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathShow.Location = new System.Drawing.Point(75, 100);
            this.PathShow.Name = "PathShow";
            this.PathShow.Size = new System.Drawing.Size(400, 28);
            this.PathShow.TabIndex = 5;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(500, 100);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 32);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Mở";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(600, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(700, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab02_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2_20521086_TrangKyAnh.Properties.Resources.gradienta_OzfD79w8ptA_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.PathShow);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.ListShow);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.Name = "Lab02_Bai5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB 2 - 20521086 - Trang Kỳ Anh - Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListView ListShow;
        private System.Windows.Forms.ColumnHeader FileName;
        private new System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.TextBox PathShow;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}