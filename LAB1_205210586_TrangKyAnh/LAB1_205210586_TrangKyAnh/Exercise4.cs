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
    public partial class Exercise4 : Form
    {
        private Label ctrl;

        public Exercise4()
        {
            InitializeComponent();
        }

        private void GetRes_Click(object sender, EventArgs e)
        {
            try
            {
                uint number;
                ulong Res;
                number = uint.Parse(NumberBox.Text.Trim());
                switch (Select.Text)
                {
                    case "USD":
                        Res = number * 22772;
                        ShowBox.Text = Res.ToString();
                        ShowText.Text = "1 USD = 22772 VNĐ";
                        break;
                    case "EUR":
                        Res = number * 28132;
                        ShowBox.Text = Res.ToString();
                        ShowText.Text = "1 EUR = 28132";
                        break;
                    case "GBP":
                        Res = number * 31538;
                        ShowBox.Text = Res.ToString();
                        ShowText.Text = "1 GBP = 31538 VNĐ";
                        break;
                    case "SGD":
                        Res = number * 17286;
                        ShowBox.Text = Res.ToString();
                        ShowText.Text = "1 SGD = 17286 VNĐ";
                        break;
                    case "JPY":
                        Res = number * 214;
                        ShowBox.Text = Res.ToString();
                        ShowText.Text = "1 JPY = 214 VNĐ";
                        break;    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
