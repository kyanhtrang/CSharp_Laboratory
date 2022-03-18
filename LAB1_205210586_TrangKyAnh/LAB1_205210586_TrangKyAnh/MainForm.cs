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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai1 exercise1 = new Lab01_Bai1();
            exercise1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai2 exercise2 = new Lab01_Bai2();
            exercise2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab01_Bai3 exercise3 = new Lab01_Bai3();
            exercise3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab01_Bai4 exercise4 = new Lab01_Bai4(); 
            exercise4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai5 exercise5 = new Lab01_Bai5();
            exercise5.Show();
        }
    }
}
