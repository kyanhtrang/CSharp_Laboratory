using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai4_Server : Form
    {
        List<TcpClient> clientList;
        StreamWriter write;
        Thread ListenConnectionThread;
        private TcpListener SverListenConnection;

        public LAB3_Bai4_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void ListenConnection()
        {
            SverListenConnection.Start();
            while (true)
            {
                if (SverListenConnection.Pending() == true)
                {
                    TcpClient client = SverListenConnection.AcceptTcpClient();
                    clientList.Add(client);
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(client);
                }
            }       
        }

        private void Broadcast(string str)
        {
            foreach (TcpClient item in clientList)
            {
                write = new StreamWriter(item.GetStream());
                write.WriteLine(str);
                write.Flush();
            }
            AddMessage(str);
        }

        void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            StreamReader ReceiveMess = new StreamReader(client.GetStream());
            while (true)
            {
                if (ReceiveMess.EndOfStream == false)
                {
                    string message = ReceiveMess.ReadLine();
                    Broadcast(message);
                }
            }

        }

        void AddMessage(string s)
        {
            MessageShow.Items.Add(new ListViewItem() { Text = s });
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            clientList = new List<TcpClient>();
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 8080);
            SverListenConnection = new TcpListener(IP);
            ListenConnectionThread = new Thread(new ThreadStart(ListenConnection));
            ListenConnectionThread.IsBackground = true;
            ListenConnectionThread.Start();
        }
    }
}
