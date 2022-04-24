using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai1_Client : Form
    {
        public LAB3_Bai1_Client()
        {
            InitializeComponent();
        }

        private Boolean ValidatekPort(string PortString)
        {
            int PortNumber;
            Boolean PortIsInt = int.TryParse(PortString, out PortNumber);
            if (PortIsInt == true)
                if (PortNumber >= 1024 && PortNumber <= 49151)
                    return true;
            return false;
        }


        private Boolean ValidateIPv4(string IPString)
        {
            if (String.IsNullOrWhiteSpace(IPString))
            {
                return false;
            }

            string[] splitValues = IPString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            IPAddress ipAddress;

            return IPAddress.TryParse(IPString, out ipAddress);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ;
            if (ValidateIPv4(IPServer.Text) == true && ValidatekPort(PortServer.Text) == true)
            {
                IPWarning.Text = "";
                PortWarning.Text = "";
                UdpClient Client = new UdpClient();

                byte[] SendByte = Encoding.UTF8.GetBytes(MessageText.Text);

                Client.Send(SendByte, SendByte.Length, IPServer.Text, int.Parse(PortServer.Text));

                MessageText.Text = "";
            }

            else
            {
                if (ValidateIPv4(IPServer.Text) == false)
                    IPWarning.Text = "*IP hợp lệ \r\n" +
                                          "từ 0.0.0.0 đến 255.255.255.255";

                if (ValidatekPort(PortServer.Text) == false)
                    PortWarning.Text = "*Port hợp lệ \r\n" +
                                            "trong khoảng [1024,49151]";
            }
        }

    }
}
