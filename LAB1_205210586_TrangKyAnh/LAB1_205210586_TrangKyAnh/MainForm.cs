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
            Exercise1 exercise1 = new Exercise1();
            exercise1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Exercise2 exercise2 = new Exercise2();
            exercise2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Exercise3 exercise3 = new Exercise3();
            exercise3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Exercise4 exercise4 = new Exercise4(); 
            exercise4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Exercise5 exercise5 = new Exercise5();
            exercise5.Show();
        }
    }
}
