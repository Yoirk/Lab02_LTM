using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22520399_LeAnhHao
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void DocFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                HienThiText.Text = content;
                fs.Close();
            }
            catch { }
        }

        private void GhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                string line = HienThiText.Text;
                HienThiText.Text = "";
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(line.ToUpper());
                sw.Flush();
                fs.Close();
            }
            catch { }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
