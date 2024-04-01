namespace Lab2_22520399_LeAnhHao
{
    partial class Bai05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvDanhSach = new ListView();
            TenFile = new ColumnHeader();
            KichThuoc = new ColumnHeader();
            DuoiFile = new ColumnHeader();
            NgayTao = new ColumnHeader();
            Thoat = new Button();
            btnDocFolder = new Button();
            SuspendLayout();
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { TenFile, KichThuoc, DuoiFile, NgayTao });
            lvDanhSach.GridLines = true;
            lvDanhSach.ImeMode = ImeMode.Off;
            lvDanhSach.Location = new Point(-1, 0);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(605, 450);
            lvDanhSach.TabIndex = 0;
            lvDanhSach.TileSize = new Size(10, 10);
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            // 
            // TenFile
            // 
            TenFile.Text = "Tên";
            TenFile.Width = 150;
            // 
            // KichThuoc
            // 
            KichThuoc.Text = "Kích Thước";
            KichThuoc.Width = 150;
            // 
            // DuoiFile
            // 
            DuoiFile.Text = "Đuôi mở rộng";
            DuoiFile.Width = 150;
            // 
            // NgayTao
            // 
            NgayTao.Text = "Ngày tạo";
            NgayTao.Width = 150;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(649, 142);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(122, 45);
            Thoat.TabIndex = 5;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // btnDocFolder
            // 
            btnDocFolder.Location = new Point(649, 68);
            btnDocFolder.Name = "btnDocFolder";
            btnDocFolder.Size = new Size(122, 45);
            btnDocFolder.TabIndex = 4;
            btnDocFolder.Text = "Đọc thư mục";
            btnDocFolder.UseVisualStyleBackColor = true;
            btnDocFolder.Click += btnDocFolder_Click;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(btnDocFolder);
            Controls.Add(lvDanhSach);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvDanhSach;
        private Button Thoat;
        private Button btnDocFolder;
        private ColumnHeader TenFile;
        private ColumnHeader KichThuoc;
        private ColumnHeader DuoiFile;
        private ColumnHeader NgayTao;
    }
}