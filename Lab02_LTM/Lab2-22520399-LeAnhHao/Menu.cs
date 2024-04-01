namespace Lab2_22520399_LeAnhHao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            bai03.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            bai05.Show();   
        }
    }
}
