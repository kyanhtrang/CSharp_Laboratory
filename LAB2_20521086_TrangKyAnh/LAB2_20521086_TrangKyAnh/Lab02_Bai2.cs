using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_20521086_TrangKyAnh
{
    public partial class Lab02_Bai2 : Form
    {
        FileStream fs;

        public Lab02_Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int lineCount = 0, charCount = 0, wordCount = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Documents| *.txt";
            openFileDialog.ShowDialog();
            try
            {
                fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            fs.Seek(0, SeekOrigin.Begin);
            byte[] fileContents = new byte[fs.Length];
            fs.Read(fileContents, 0, (int)fs.Length);
            string s = Encoding.UTF8.GetString(fileContents);
            TextShow.Text = s;

            charCount = s.Length;
            boxCharacters.Text = charCount.ToString();
            boxFileName.Text = openFileDialog.SafeFileName.ToString();
            boxURL.Text = openFileDialog.FileName;
            s = s.Replace("\r\n", "\r");
            lineCount = TextShow.Lines.Count();
            boxLines.Text = lineCount.ToString();
            string[] source = s.Split(new char[] { '.', '!', '?', ' ', ';', ':', ',', '\r',
                                            '!', '@', '#', '$', '%', '^', '&', '*'},
                                             StringSplitOptions.RemoveEmptyEntries);
            wordCount = source.Count();
            boxWords.Text = wordCount.ToString();
            fs.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control clear in this.Controls)
                if (clear is TextBox)
                {
                    clear.Text = String.Empty;
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
