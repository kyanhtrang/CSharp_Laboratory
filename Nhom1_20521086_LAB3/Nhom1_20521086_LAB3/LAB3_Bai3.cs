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
    public partial class LAB3_Bai3 : Form
    {
        LAB3_Bai3_Client client = new LAB3_Bai3_Client();
        LAB3_Bai3_Server server = new LAB3_Bai3_Server();

        public LAB3_Bai3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            client.Close();
            server.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            client.Show();
            btnClient.Enabled = false;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server.Show();
            btnServer.Enabled = false;
        }
    }
}
