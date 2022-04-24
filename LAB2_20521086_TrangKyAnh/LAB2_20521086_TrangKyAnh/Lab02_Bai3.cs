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
    public partial class Lab02_Bai3 : Form
    {
        FileStream fs;

        public Lab02_Bai3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
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
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Documents| *.txt";
            saveFileDialog.ShowDialog();

            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);

            string output = "";
            string[] lines = TextShow.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(lines[i], null);

                output += lines[i] + " = " + result.ToString() + "\r\n";
            }
            sw.WriteLine(output);
            MessageBox.Show("Saved to: " + saveFileDialog.FileName);
            sw.Close();
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
