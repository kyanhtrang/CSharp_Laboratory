namespace LAB2_20521086_TrangKyAnh
{
    partial class Lab02_Bai2
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
            this.FileName = new System.Windows.Forms.Label();
            this.TextShow = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.Label();
            this.Lines = new System.Windows.Forms.Label();
            this.Characters = new System.Windows.Forms.Label();
            this.Words = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxFileName = new System.Windows.Forms.TextBox();
            this.boxCharacters = new System.Windows.Forms.TextBox();
            this.boxWords = new System.Windows.Forms.TextBox();
            this.boxLines = new System.Windows.Forms.TextBox();
            this.boxURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Title.Location = new System.Drawing.Point(175, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(450, 46);
            this.Title.TabIndex = 1;
            this.Title.Text = "ĐỌC THÔNG TIN FILE";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.BackColor = System.Drawing.Color.Transparent;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileName.Location = new System.Drawing.Point(25, 75);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(93, 22);
            this.FileName.TabIndex = 2;
            this.FileName.Text = "File name:";
            // 
            // TextShow
            // 
            this.TextShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShow.Location = new System.Drawing.Point(375, 75);
            this.TextShow.Multiline = true;
            this.TextShow.Name = "TextShow";
            this.TextShow.Size = new System.Drawing.Size(375, 375);
            this.TextShow.TabIndex = 3;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.BackColor = System.Drawing.Color.Transparent;
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.URL.Location = new System.Drawing.Point(25, 125);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(51, 22);
            this.URL.TabIndex = 4;
            this.URL.Text = "URL:";
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.BackColor = System.Drawing.Color.Transparent;
            this.Lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lines.Location = new System.Drawing.Point(25, 175);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(82, 22);
            this.Lines.TabIndex = 5;
            this.Lines.Text = "Số dòng:";
            // 
            // Characters
            // 
            this.Characters.AutoSize = true;
            this.Characters.BackColor = System.Drawing.Color.Transparent;
            this.Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Characters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Characters.Location = new System.Drawing.Point(25, 275);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(75, 22);
            this.Characters.TabIndex = 5;
            this.Characters.Text = "Số kí tự:";
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.BackColor = System.Drawing.Color.Transparent;
            this.Words.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Words.Location = new System.Drawing.Point(25, 225);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(57, 22);
            this.Words.TabIndex = 6;
            this.Words.Text = "Số từ:\r\n";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(29, 325);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(325, 50);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(25, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "XÓA";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(200, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // boxFileName
            // 
            this.boxFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFileName.Location = new System.Drawing.Point(125, 75);
            this.boxFileName.Name = "boxFileName";
            this.boxFileName.Size = new System.Drawing.Size(225, 28);
            this.boxFileName.TabIndex = 10;
            // 
            // boxCharacters
            // 
            this.boxCharacters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCharacters.Location = new System.Drawing.Point(125, 275);
            this.boxCharacters.Name = "boxCharacters";
            this.boxCharacters.Size = new System.Drawing.Size(225, 28);
            this.boxCharacters.TabIndex = 11;
            // 
            // boxWords
            // 
            this.boxWords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWords.Location = new System.Drawing.Point(125, 225);
            this.boxWords.Name = "boxWords";
            this.boxWords.Size = new System.Drawing.Size(225, 28);
            this.boxWords.TabIndex = 12;
            // 
            // boxLines
            // 
            this.boxLines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLines.Location = new System.Drawing.Point(125, 175);
            this.boxLines.Name = "boxLines";
            this.boxLines.Size = new System.Drawing.Size(225, 28);
            this.boxLines.TabIndex = 13;
            // 
            // boxURL
            // 
            this.boxURL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxURL.Location = new System.Drawing.Point(125, 125);
            this.boxURL.Name = "boxURL";
            this.boxURL.Size = new System.Drawing.Size(225, 28);
            this.boxURL.TabIndex = 14;
            // 
            // Lab02_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2_20521086_TrangKyAnh.Properties.Resources.gradienta_OzfD79w8ptA_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 478);
            this.Controls.Add(this.boxURL);
            this.Controls.Add(this.boxLines);
            this.Controls.Add(this.boxWords);
            this.Controls.Add(this.boxCharacters);
            this.Controls.Add(this.boxFileName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.TextShow);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.Name = "Lab02_Bai2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB 2 - 20521086 - Trang Kỳ Anh - Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox TextShow;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label Lines;
        private System.Windows.Forms.Label Characters;
        private System.Windows.Forms.Label Words;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox boxFileName;
        private System.Windows.Forms.TextBox boxCharacters;
        private System.Windows.Forms.TextBox boxWords;
        private System.Windows.Forms.TextBox boxLines;
        private System.Windows.Forms.TextBox boxURL;
    }
}