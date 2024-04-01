namespace Lab2_22520399_LeAnhHao
{
    partial class Bai03
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
            HienThiText = new RichTextBox();
            DocFile = new Button();
            Thoat = new Button();
            GhiFile = new Button();
            SuspendLayout();
            // 
            // HienThiText
            // 
            HienThiText.Location = new Point(203, 41);
            HienThiText.Name = "HienThiText";
            HienThiText.Size = new Size(553, 368);
            HienThiText.TabIndex = 4;
            HienThiText.Text = "";
            // 
            // DocFile
            // 
            DocFile.Location = new Point(45, 41);
            DocFile.Name = "DocFile";
            DocFile.Size = new Size(122, 45);
            DocFile.TabIndex = 3;
            DocFile.Text = "Đọc File";
            DocFile.UseVisualStyleBackColor = true;
            DocFile.Click += DocFile_Click;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(45, 215);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(122, 51);
            Thoat.TabIndex = 6;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // GhiFile
            // 
            GhiFile.Location = new Point(45, 132);
            GhiFile.Name = "GhiFile";
            GhiFile.Size = new Size(122, 41);
            GhiFile.TabIndex = 5;
            GhiFile.Text = "Ghi File";
            GhiFile.UseVisualStyleBackColor = true;
            GhiFile.Click += GhiFile_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(GhiFile);
            Controls.Add(HienThiText);
            Controls.Add(DocFile);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox HienThiText;
        private Button DocFile;
        private Button Thoat;
        private Button GhiFile;
    }
}