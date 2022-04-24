using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_20521086_TrangKyAnh
{
    public partial class Lab02_Bai5 : Form
    {
        public Lab02_Bai5()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            PathShow.Text = folder.SelectedPath;
            DirectoryInfo directory = new DirectoryInfo(PathShow.Text);
            FileInfo[] infos = directory.GetFiles();
            foreach (FileInfo fi in infos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.Length.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.Extension });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.LastWriteTime.ToString() });
                ListShow.Items.Add(item);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control clear in this.Controls)
                if (clear is TextBox)
                {
                    clear.Text = String.Empty;
                    ListShow.Items.Clear();
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
