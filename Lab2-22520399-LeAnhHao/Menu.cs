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
    }
}
