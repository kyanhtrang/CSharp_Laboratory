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
    }
}
