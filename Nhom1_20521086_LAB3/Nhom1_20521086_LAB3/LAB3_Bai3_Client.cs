using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai3_Client : Form
    {
        public LAB3_Bai3_Client()
        {
            InitializeComponent();
        }

        static TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress tempIP;
            int tempInt;
            if (txtPort.TextLength != 0 && txtRemoteIP.TextLength != 0)
                if (IPAddress.TryParse(txtRemoteIP.Text, out tempIP) && Int32.TryParse(txtPort.Text, out tempInt))
                    NewClient(txtRemoteIP.Text, Int32.Parse(txtPort.Text));
                else MessageBox.Show("Nhập đúng kiểu dữ liệu IP và port");
            else MessageBox.Show("Vui lòng nhập IP và port");

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            CloseClient();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                MessageBox.Show("Server closed connection");
                CloseClient();
            }
            else
                SendData();
        }
        public void NewClient(string ip, int port)
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse(ip);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            try
            {
                tcpClient.Connect(ipEndPoint);
                ns = tcpClient.GetStream();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập không đúng địa chỉ");
            }


        }
        public void SendData()
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(txtMessages.Text + "\r\n");
            ns.Write(data, 0, data.Length);
            ns.Flush();
            txtMessages.Text = "";
        }
        public void CloseClient()
        {
            Byte[] dataClose;
            dataClose = System.Text.Encoding.UTF8.GetBytes("quit\r\n");



            ns.Write(dataClose, 0, dataClose.Length);

            ns.Close();
            tcpClient.Close();
        }

    }
}
