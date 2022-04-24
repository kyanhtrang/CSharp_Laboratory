using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai1_Server : Form
    {
        UdpClient Server;
        Thread ServerListening;

        public LAB3_Bai1_Server()
        {
            InitializeComponent();
        }

        private Boolean ValidatePort(string port)
        {
            int PortNumber;
            Boolean PortIsInt = int.TryParse(port, out PortNumber);
            if (PortIsInt == true)
                if (PortNumber >= 1024 && PortNumber <= 49151)
                    return true;
            return false;
        }

        void openServerThread()
        {
            Server = new UdpClient(int.Parse(PortServer.Text));
            byte[] ReceiveByte;
            while (true)
            {
                IPEndPoint Client = new IPEndPoint(IPAddress.Any, 0);
                ReceiveByte = Server.Receive(ref Client);
                string msReceive = Encoding.UTF8.GetString(ReceiveByte);
                string msShow = Client.Address.ToString() + ": " + msReceive + "\r\n";
                MessageShow.Text = MessageShow.Text + msShow;
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (ValidatePort(PortServer.Text) == true)
            {

                btnListen.Enabled = false;
                btnStop.Enabled = true;
                Warning.Text = "";
                Control.CheckForIllegalCrossThreadCalls = false;
                ThreadStart threadStart = new ThreadStart(openServerThread);
                ServerListening = new Thread(threadStart);
                ServerListening.Start();
            }

            else
            {
                Warning.Text = "Port không hợp lệ \r\n" + "Không để trống, nhập trong khoảng [1024,49151]";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ServerListening.Abort();
            Server.Close();
            btnListen.Enabled = true;
            btnStop.Enabled = false;
        }

        private void LAB3_Bai1_Server_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }

        private void LAB3_Bai1_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ServerListening != null)
            {
                ServerListening.Abort();
                Server.Close();
            }
        }
    }
}
