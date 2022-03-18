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
    public partial class Exercise5 : Form
    {
        public Exercise5()
        {
            InitializeComponent();
        }

        private void GetRes_Click(object sender, EventArgs e)
        {
            try
            {
                long a, b;
                long s1 = 0, s2 = 0, s3 = 0, res1 = 1, res2 = 1;

                a = int.Parse(NumberBox1.Text.Trim());
                b = int.Parse(NumberBox2.Text.Trim());

                for (int i = 1; i <= a; i++)
                {
                    res1 *= i;
                }
                GiaiThuaA.Text = "A! = " + res1.ToString();

                for (int i = 1; i <= b; i++)
                {
                    res2 *= i;
                }
                GiaiThuaB.Text = "B! = " + res2.ToString();

                for (int i = 1; i <= a; i++)
                {
                    s1 += (int)i;
                }
                Sum1.Text = "S1 = " + s1.ToString();

                for(int i = 1; i <= b; i++)
                {
                    s2 += (int)i;
                    s3 += (long)Math.Pow(a, i);
                }
                Sum2.Text = "S2 = " + s2.ToString();
                Sum3.Text = "S3 = " + s3.ToString();
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
