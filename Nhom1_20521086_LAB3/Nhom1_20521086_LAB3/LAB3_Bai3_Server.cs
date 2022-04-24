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
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai3_Server : Form
    {
        public LAB3_Bai3_Server()
        {
            InitializeComponent();
        }

        bool btnCloseClicked = false;
        Socket clientSocket;
        TcpListener listenerSocket;
        Thread serverThread;


        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
        public void StartUnsafeThread()
        {
            btnListen.Enabled = false;

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket = new TcpListener(ipepServer);
            while (btnCloseClicked == false)
            {
                listenerSocket.Start();
                clientSocket = listenerSocket.AcceptSocket();

                lstShow.Items.Add(new ListViewItem("New client connected\n"));
                while (clientSocket.Connected)
                {
                    string text = "";
                    int bytesReceived = 0;
                    byte[] recv = new byte[1024];

                    bytesReceived = clientSocket.Receive(recv);
                    text = Encoding.UTF8.GetString(recv);
                    text = text.Replace("\0", "");

                    if (text == "quit\r\n")
                    {
                        text = "Client disconnecting...";
                        lstShow.Items.Add(new ListViewItem(text));
                        clientSocket.Close();
                        break;
                    }
                    lstShow.Items.Add(new ListViewItem(text));

                }
            }
            serverThread.Abort();

            Exit();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            btnCloseClicked = true;
            this.Close();
        }

        public void Exit()
        {
            listenerSocket.Stop();
            clientSocket.Close();
            btnCloseClicked = false;
            btnListen.Enabled = true;
        }
    }
}
