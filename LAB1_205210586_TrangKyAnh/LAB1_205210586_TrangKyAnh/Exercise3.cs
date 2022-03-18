using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_205210586_TrangKyAnh
{
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void getRes_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                string Result;
                number = int.Parse(NumberBox.Text.Trim());
                switch (number)
                {
                    case 0:
                        TextRes.Text = "Không";
                        break;
                    case 1:
                        TextRes.Text = "Một";
                        break;
                    case 2:
                        TextRes.Text = "Hai";
                        break;
                    case 3:
                        TextRes.Text = "Ba";
                        break;
                    case 4:
                        TextRes.Text = "Bốn";
                        break;
                    case 5:
                        TextRes.Text = "Năm";
                        break;
                    case 6:
                        TextRes.Text = "Sáu";
                        break ;
                    case 7:
                        TextRes.Text = "Bảy";
                        break;
                    case 8:
                        TextRes.Text = "Tám";
                        break;
                    case 9:
                        TextRes.Text = "Chín";
                        break;
                    default:
                        TextRes.Text = "Chỉ đọc được số từ 0 đến 9";
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ.\nVui lòng nhập số nguyên!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (Control clear in this.Controls)
                if (clear is TextBox)
                {
                    clear.Text = String.Empty;
                }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
