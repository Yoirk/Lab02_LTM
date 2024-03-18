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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void DocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
            StreamReader srReader = new StreamReader(fs);
            // tên file
            FileName.Text = openFileDialog.SafeFileName.ToString();
            // URL
            URL.Text = fs.Name.ToString();
            // Hiển thị lên RichTextBox
            string content = srReader.ReadToEnd();
            HienThi.Text = content;
            // Đếm số ký tự
            int CharCount = content.Length;
            SoKyTu.Text = CharCount.ToString();
            // Đếm số dòng
            content = content.Replace("\r\n", "\r");
            int LineCount = HienThi.Lines.Count();
            SoDong.Text = LineCount.ToString();
            // Đếm số từ
            string[] source = content.Split(new char[] { '.', '?', '!', '\r', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int WordCount = source.Count();
            SoTu.Text = WordCount.ToString();
            fs.Close();
            
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
