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
    public partial class LAB3_Bai4_Client : Form
    {
        IPEndPoint IPServer;
        TcpClient client;
        StreamReader read;
        StreamWriter write;

        public LAB3_Bai4_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Connect()
        {
            IPServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new TcpClient();
            try
            {
                client.Connect(IPServer);
                read = new StreamReader(client.GetStream());
                write = new StreamWriter(client.GetStream());
                Thread listen = new Thread(new ThreadStart(Receive));
                listen.IsBackground = true;
                listen.Start();
                SendConnection();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        void SendConnection()
        {
            write.WriteLine(NameInput.Text + " connected to server");
            write.Flush();
            MessageText.Text = "";
        }

        void Send(string str)
        {
            if (str != string.Empty)
            {
                write.WriteLine(NameInput.Text + ": " + str);
                write.Flush();
                MessageText.Text = "";
            }
        }

        void Receive()
        {

            while (true)
            {
                if (read.EndOfStream == false)
                {
                    byte[] data = new byte[1024 * 5000];
                    string message = read.ReadLine();
                    AddMessage(message);
                }
            }
        }

        void AddMessage(string s)
        {
            MessageShow.Items.Add(new ListViewItem() { Text = s });
            MessageText.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            Connect();
            btnConnect.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(MessageText.Text);
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (NameInput.Text != "")
                btnConnect.Enabled = true;
            else
                btnConnect.Enabled = false;
        }

        private void LAB3_Bai4_Client_Load(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnSend.Enabled = false;
        }
    }
}
