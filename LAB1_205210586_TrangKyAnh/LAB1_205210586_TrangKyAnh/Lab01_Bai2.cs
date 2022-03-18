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
    public partial class Lab01_Bai2 : Form
    {
        public Lab01_Bai2()
        {
            InitializeComponent();
        }

        private void getRes_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, Max, Min;
            try
            {
                num1 = double.Parse(firstInt.Text.Trim());
                num2 = double.Parse(SecondInt.Text.Trim());
                num3 = double.Parse(ThirdInt.Text.Trim());
                Max = Min = num1;
                if(num2 > Max)
                {
                    Max = num2;
                }    
                if(num3 > Max)
                {
                    Max = num3;
                }    
                if(num2 < Min)
                {
                    Min = num2;
                }    
                if(num3 < Min)
                {
                    Min = num3;
                }    
                MaxRes.Text = Max.ToString();
                MinRes.Text = Min.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.\nVui lòng chỉ nhập số!");
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
