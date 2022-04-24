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
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai2 : Form
    {
        Thread serverThread;

        public LAB3_Bai2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            StartListen();
            MessageBox.Show("Listening...");
            btnListen.Enabled = false;
        }

        public void StartListen()
        {
            serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private Boolean CMDIsClose(string MssgFromCMD)
        {
            if (MssgFromCMD.Length == 1)
            {
                char[] c = MssgFromCMD.ToCharArray();
                int ascii = (int)c[0];
                if (ascii == 10)
                    return true;
            }
            return false;
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listnerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listnerSocket.Bind(ipepServer);
            listnerSocket.Listen(-1);
            clientSocket = listnerSocket.Accept();
            lvShow.Items.Add(new ListViewItem("Telnet running on 127.0.0.1:8080"));
            while (clientSocket.Connected)
            {

                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);

                } while (text[text.Length - 1] != '\n');

                if (CMDIsClose(text) == false)
                    lvShow.Items.Add(new ListViewItem(text));
                else
                    break;
            }
            listnerSocket.Close();
            btnListen.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
