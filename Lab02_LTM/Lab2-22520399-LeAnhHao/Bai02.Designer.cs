namespace Lab2_22520399_LeAnhHao
{
    partial class Bai02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DocFile = new Button();
            HienThi = new RichTextBox();
            FileName = new TextBox();
            URL = new TextBox();
            SoDong = new TextBox();
            SoTu = new TextBox();
            SoKyTu = new TextBox();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 142);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 177);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 220);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Số dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 261);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 304);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Số ký tự";
            // 
            // DocFile
            // 
            DocFile.Location = new Point(44, 44);
            DocFile.Name = "DocFile";
            DocFile.Size = new Size(168, 61);
            DocFile.TabIndex = 5;
            DocFile.Text = "Đọc File";
            DocFile.UseVisualStyleBackColor = true;
            DocFile.Click += DocFile_Click;
            // 
            // HienThi
            // 
            HienThi.Location = new Point(318, 12);
            HienThi.Name = "HienThi";
            HienThi.Size = new Size(470, 426);
            HienThi.TabIndex = 6;
            HienThi.Text = "";
            // 
            // FileName
            // 
            FileName.Location = new Point(109, 139);
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Size = new Size(160, 23);
            FileName.TabIndex = 11;
            // 
            // URL
            // 
            URL.Location = new Point(109, 174);
            URL.Name = "URL";
            URL.ReadOnly = true;
            URL.Size = new Size(160, 23);
            URL.TabIndex = 11;
            // 
            // SoDong
            // 
            SoDong.Location = new Point(109, 217);
            SoDong.Name = "SoDong";
            SoDong.ReadOnly = true;
            SoDong.Size = new Size(160, 23);
            SoDong.TabIndex = 11;
            // 
            // SoTu
            // 
            SoTu.Location = new Point(109, 258);
            SoTu.Name = "SoTu";
            SoTu.ReadOnly = true;
            SoTu.Size = new Size(160, 23);
            SoTu.TabIndex = 11;
            // 
            // SoKyTu
            // 
            SoKyTu.Location = new Point(109, 301);
            SoKyTu.Name = "SoKyTu";
            SoKyTu.ReadOnly = true;
            SoKyTu.Size = new Size(160, 23);
            SoKyTu.TabIndex = 11;
            // 
            // thoat
            // 
            thoat.Location = new Point(237, 44);
            thoat.Name = "thoat";
            thoat.Size = new Size(56, 61);
            thoat.TabIndex = 12;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(SoKyTu);
            Controls.Add(SoTu);
            Controls.Add(SoDong);
            Controls.Add(URL);
            Controls.Add(FileName);
            Controls.Add(HienThi);
            Controls.Add(DocFile);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button DocFile;
        private RichTextBox HienThi;
        private TextBox FileName;
        private TextBox URL;
        private TextBox SoDong;
        private TextBox SoTu;
        private TextBox SoKyTu;
        private Button thoat;
    }
}