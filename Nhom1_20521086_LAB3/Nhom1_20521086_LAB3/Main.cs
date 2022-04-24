using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_20521086_LAB3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            LAB3_Bai1 Bai1 = new LAB3_Bai1();
            this.Hide();
            Bai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            LAB3_Bai2 Bai2 = new LAB3_Bai2();
            this.Hide();
            Bai2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            LAB3_Bai3 Bai3 = new LAB3_Bai3();
            this.Hide();
            Bai3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            LAB3_Bai4 Bai4 = new LAB3_Bai4();
            this.Hide();
            Bai4.ShowDialog();
        }
    }
}
