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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDocFolder_Click(object sender, EventArgs e)
        {
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderDialog.ShowDialog();

                    // Kiểm tra xem người dùng đã chọn thư mục hay không và thư mục có trống không
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(folderDialog.SelectedPath);
                        lvDanhSach.Items.Clear(); // Xóa các mục của ListView trước đó 

                        foreach (string file in files)
                        {
                            // Lấy thông tin chi tiết của tệp sử dụng FileInfo
                            FileInfo fileInfo = new FileInfo(file);

                            // Tạo một mảng string chứa thông tin 
                            string[] row = {
                            Path.GetFileName(file), // Tên File
                            fileInfo.Length.ToString() + " bytes", // Kích thước
                            Path.GetExtension(file), // Đuôi mở rộng
                            fileInfo.CreationTime.ToString() // Ngày tạo
                        };
                            // Tạo một ListViewItem từ mảng string trên
                            ListViewItem listViewItem = new ListViewItem(row);

                            // Thêm ListViewItem vào ListView trong màn hình hiển thị
                            lvDanhSach.Items.Add(listViewItem);
                        }
                    }
                }
            }
        }
    }
}
