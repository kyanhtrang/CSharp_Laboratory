using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6_20521086_TrangKyAnh
{
    public partial class LAB6_20521086_TrangKyAnh : Form
    {
        public LAB6_20521086_TrangKyAnh()
        {
            InitializeComponent();
        }

        FtpWebRequest request = null;
        FtpWebResponse response = null;
        Stream ftpStream = null;
        int length = 1024;

        private List<string> ListFiles()
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(txtServer.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();
                request = null;

                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<string> listFile = ListFiles();
            for (int i = 0; i < listFile.Count; i++)
            {
                lvl.Items.Add(listFile[i]);
            }
        }

        private void lvl_ItemActivate(object sender, EventArgs e)
        {
            Download();
        }


        private void Download()
        {
            try
            {
                string str = lvl.SelectedItems[0].Text;
                request = (FtpWebRequest)WebRequest.Create(txtServer.Text + "/" + str);
                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);

                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();
                saveFileDialog1.FileName = str;
                DialogResult result = saveFileDialog1.ShowDialog();
                byte[] byteBuffer = new byte[length];
                int bytesRead = ftpStream.Read(byteBuffer, 0, length);
                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    try
                    {
                        while (bytesRead > 0)
                        {
                            fs.Write(byteBuffer, 0, bytesRead);
                            bytesRead = ftpStream.Read(byteBuffer, 0, length);
                        }
                        MessageBox.Show("Downloaded file successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                ftpStream.Close();
                response.Close();
                request = null;
            }
            catch
            {
                MessageBox.Show("Select a file before downloading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtFile.Text != string.Empty)
            {
                lblWrong.Text = "";
                FileInfo fi = new FileInfo(txtFile.Text);

                request = (FtpWebRequest)WebRequest.Create(txtServer.Text + "/" + fi.Name);

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);

                ftpStream = request.GetRequestStream();
                FileStream file = File.OpenRead(txtFile.Text);

                byte[] buffer = new byte[length];
                int byteRead = 0;

                do
                {
                    byteRead = file.Read(buffer, 0, length);
                    ftpStream.Write(buffer, 0, byteRead);
                } while (byteRead != 0);

                file.Close();
                ftpStream.Close();
                request = null;

                MessageBox.Show("Upload Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblWrong.Text = "Pick a file before uploading!";
            }
        }
    }
}

