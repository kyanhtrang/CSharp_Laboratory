using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB1_205210586_TrangKyAnh
{
    public partial class Lab01_Bai1 : Form
    {
        public Lab01_Bai1()
        {
            InitializeComponent();
        }

        private void getRes_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long Result;
            try
            {
                num1 = int.Parse(firstInt.Text.Trim());
                num2 = int.Parse(secondInt.Text.Trim());
                Result = num1 + num2;
                ResultInt.Text = Result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ.\nVui lòng nhập số nguyên!");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach(Control clear in this.Controls)
                if (clear is TextBox)
                {
                    clear.Text = String.Empty;
                }    
        }
    }
}
