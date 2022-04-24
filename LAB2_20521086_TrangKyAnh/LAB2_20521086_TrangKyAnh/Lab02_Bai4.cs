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
    public partial class Lab02_Bai4 : Form
    {
        public Lab02_Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            MSSVShow.Enabled = false;
            NameShow.Enabled = false;
            DthShow.Enabled = false;
            VanShow.Enabled = false;
            ToanShow.Enabled = false;
            Input.Enabled = false;
            Output.Enabled = false;
            btnWrite2in.Enabled = false;
            btnRead.Enabled = false;
        }

        private bool CheckInput()
        {
            return float.TryParse(ToanShow.Text, out _)
                && float.TryParse(VanShow.Text, out _)
                && DthShow.Text != ""
                && NameShow.Text != ""
                && MSSVShow.Text != "";
        }

        private void btnWrite2in_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string[] content = { MSSVShow.Text, NameShow.Text, DthShow.Text, ToanShow.Text, VanShow.Text, "\r\n" };

                FileStream fsw = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                fsw.Close();

                File.AppendAllLines(fsw.Name, content);

                FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
                Input.Text = sr.ReadToEnd();
                sr.Close();
                fsr.Close();

                Number.Text = (int.Parse(Number.Text) - 1).ToString();
                BeNothing();
            }
            else
            {
                MessageBox.Show("Xin Nhập đủ và đúng định dạng thông tin");
                return;
            }
            if (Number.Text == "0")
            {
                btnWrite.Enabled = true;

                Number.Enabled = true;
                MSSVShow.Enabled = false;
                NameShow.Enabled = false;
                DthShow.Enabled = false;
                VanShow.Enabled = false;
                ToanShow.Enabled = false;

                btnWrite2in.Enabled = false;
                btnRead.Enabled = true;
                BeNothing();
            }
        }

        private void BeNothing()
        {
            ToanShow.Text = "";
            VanShow.Text = "";
            DthShow.Text = "";
            NameShow.Text = "";
            MSSVShow.Text = "";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Number.Text, out _))
            {
                btnWrite.Enabled = false;
                Number.Enabled = true;
                MSSVShow.Enabled = true;
                NameShow.Enabled = true;
                DthShow.Enabled = true;
                VanShow.Enabled = true;
                ToanShow.Enabled = true;
                Input.Enabled = true;
                Output.Enabled = true;
                btnWrite2in.Enabled = true;
                btnRead.Enabled = false;
                Number.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xin Nhập số lượng sinh viên");
            }
            if (Number.Text == "0")
            {
                btnWrite.Enabled = true;

                Number.Enabled = true;
                MSSVShow.Enabled = false;
                NameShow.Enabled = false;
                DthShow.Enabled = false;
                VanShow.Enabled = false;
                ToanShow.Enabled = false;

                btnWrite2in.Enabled = false;
                btnRead.Enabled = true;
                BeNothing();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("..\\input.txt", string.Empty);
            File.WriteAllText("..\\output.txt", string.Empty);
            Input.Text = "";
            Output.Text = "";
            BeNothing();
            MSSVShow.Enabled = false;
            NameShow.Enabled = false;
            DthShow.Enabled = false;
            VanShow.Enabled = false;
            ToanShow.Enabled = false;
            btnWrite2in.Enabled = false;
            btnRead.Enabled = false;
            Number.Enabled = true;
            btnWrite.Enabled = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
            string content = sr.ReadToEnd();

            sr.Close();
            fsr.Close();

            string[] Lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            if (Lines.Length != 0 && Lines[0] != "")
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i] == "" && float.TryParse(Lines[i - 1], out _)
                                       && float.TryParse(Lines[i - 2], out _)
                                       && float.TryParse(Lines[i - 3], out _)
                                       && !float.TryParse(Lines[i - 4], out _)
                                       && float.TryParse(Lines[i - 5], out _))
                    {
                        Lines[i] = ((float.Parse(Lines[i - 1]) + float.Parse(Lines[i - 2])) / 2).ToString();
                        i++;
                    }
                }

            File.AppendAllLines("..\\output.txt", Lines);

            fsr = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
            sr = new StreamReader(fsr, Encoding.UTF8);
            Output.Text = sr.ReadToEnd();
            sr.Close();
            fsr.Close();
        }

        private bool MustBeNum(char num)
        {
            return char.IsDigit(num) || num == '.';
        }
        private bool MustBeLetter(char letter)
        {
            return char.IsLetter(letter) || char.IsWhiteSpace(letter);
        }
        private void tbMSSV_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in MSSVShow.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); MSSVShow.Text = ""; return; }
            }
        }

        private void tbHoTen_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in NameShow.Text)
            {
                if (!MustBeLetter(item)) { MessageBox.Show("Tên không có số"); NameShow.Text = ""; return; }
            }
        }

        private void tbDienThoai_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in DthShow.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); DthShow.Text = ""; return; }
            }
        }

        private void tbDiemToan_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in ToanShow.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); ToanShow.Text = ""; return; }
            }
        }

        private void tbDiemVan_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in VanShow.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); VanShow.Text = ""; return; }
            }
        }
    }
}
