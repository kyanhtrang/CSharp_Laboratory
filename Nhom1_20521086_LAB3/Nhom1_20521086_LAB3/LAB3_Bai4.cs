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
    public partial class LAB3_Bai4 : Form
    {
        LAB3_Bai4_Server server = new LAB3_Bai4_Server();

        public LAB3_Bai4()
        {
            InitializeComponent();
        } 

        private void btnServer_Click(object sender, EventArgs e)
        {
            server.Show();
            btnServer.Enabled = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            LAB3_Bai4_Client client = new LAB3_Bai4_Client();
            client.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
