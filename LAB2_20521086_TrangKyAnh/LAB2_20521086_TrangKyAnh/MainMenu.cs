using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_20521086_TrangKyAnh
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Lab02_Bai1_Click(object sender, EventArgs e)
        {
            Lab02_Bai1 Bai1 = new Lab02_Bai1();
            Bai1.Show();
        }

        private void Lab02_Bai2_Click(object sender, EventArgs e)
        {
            Lab02_Bai2 Bai2 = new Lab02_Bai2();
            Bai2.Show();
        }

        private void Lab02_Bai3_Click(object sender, EventArgs e)
        {
            Lab02_Bai3 Bai3 = new Lab02_Bai3();
            Bai3.Show();
        }

        private void Lab02_Bai4_Click(object sender, EventArgs e)
        {
            Lab02_Bai4 Bai4 = new Lab02_Bai4();
            Bai4.Show();
        }

        private void Lab02_Bai5_Click(object sender, EventArgs e)
        {
            Lab02_Bai5 Bai5 = new Lab02_Bai5(); 
            Bai5.Show();
        }
    }
}
