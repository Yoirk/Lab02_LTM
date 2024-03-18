namespace Lab2_22520399_LeAnhHao
{
    partial class Bai01
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
            DocFile = new Button();
            GhiFile = new Button();
            HienThiText = new RichTextBox();
            Thoat = new Button();
            SuspendLayout();
            // 
            // DocFile
            // 
            DocFile.Location = new Point(51, 37);
            DocFile.Name = "DocFile";
            DocFile.Size = new Size(122, 45);
            DocFile.TabIndex = 0;
            DocFile.Text = "Đọc File";
            DocFile.UseVisualStyleBackColor = true;
            DocFile.Click += DocFile_Click;
            // 
            // GhiFile
            // 
            GhiFile.Location = new Point(51, 128);
            GhiFile.Name = "GhiFile";
            GhiFile.Size = new Size(122, 41);
            GhiFile.TabIndex = 1;
            GhiFile.Text = "Ghi File";
            GhiFile.UseVisualStyleBackColor = true;
            GhiFile.Click += GhiFile_Click;
            // 
            // HienThiText
            // 
            HienThiText.Location = new Point(209, 37);
            HienThiText.Name = "HienThiText";
            HienThiText.Size = new Size(553, 368);
            HienThiText.TabIndex = 2;
            HienThiText.Text = "";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(51, 211);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(122, 51);
            Thoat.TabIndex = 3;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(HienThiText);
            Controls.Add(GhiFile);
            Controls.Add(DocFile);
            Name = "Bai01";
            Text = "Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button DocFile;
        private Button GhiFile;
        private RichTextBox HienThiText;
        private Button Thoat;
    }
}