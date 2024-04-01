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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void DocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            // Khi mở hộp thoại mở file, chỉ các tệp văn bản có phần mở rộng .txt sẽ được hiển thị trong danh sách các tệp có thể chọn.
            openFileDialog1.Filter = "Text Files|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    string result = "";

                    // Mỗi lần lặp qua mỗi phần tử của màng "lines", phần tử đó sẽ được gán cho biến "line" kiểu string.
                    // Điều này có nghĩa là line sẽ lưu trữ mỗi dòng trong tệp tin một cách lần lượt.
                    foreach (string line in lines)
                    {
                        result += Calculate(line) + Environment.NewLine;
                    }

                    HienThiText.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private string Calculate(string chuoidadoc)
        {
            // Chia chuỗi thành các toán tử và toán hạng riêng biệt
            string[] parts = chuoidadoc.Split(' ');
            double operand1 = double.Parse(parts[0]);
            char operation = char.Parse(parts[1]);
            double operand2 = double.Parse(parts[2]);

            
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = Math.Round(operand1 + operand2, 2);
                    break;
                case '-':
                    result = Math.Round(operand1 - operand2, 2);
                    break;
                case '*':
                    {
                        if (operand1 == 0 || operand2 == 0)
                        {
                            result = 0;
                            break;
                        }
                        result = Math.Round(operand1 * operand2, 2);
                        break;
                    }
                case '/':
                    result = Math.Round(operand1 / operand2, 2);
                    break;
                    // Thêm phép tính nếu muốn
            }

            return $"{operand1} {operation} {operand2} = {result}";
        }
        private void GhiFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, HienThiText.Text);
                    MessageBox.Show("File output đã được ghi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
