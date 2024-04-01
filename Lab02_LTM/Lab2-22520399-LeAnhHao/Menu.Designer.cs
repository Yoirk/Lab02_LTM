namespace Lab2_22520399_LeAnhHao
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bai1 = new Button();
            Bai2 = new Button();
            Bai3 = new Button();
            Bai4 = new Button();
            Bai5 = new Button();
            label1 = new Label();
            Thoat = new Button();
            SuspendLayout();
            // 
            // Bai1
            // 
            Bai1.Location = new Point(135, 139);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(129, 57);
            Bai1.TabIndex = 0;
            Bai1.Text = "Bài 1";
            Bai1.UseVisualStyleBackColor = true;
            Bai1.Click += Bai1_Click;
            // 
            // Bai2
            // 
            Bai2.Location = new Point(339, 139);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(129, 57);
            Bai2.TabIndex = 0;
            Bai2.Text = "Bài 2";
            Bai2.UseVisualStyleBackColor = true;
            Bai2.Click += Bai2_Click;
            // 
            // Bai3
            // 
            Bai3.Location = new Point(533, 139);
            Bai3.Name = "Bai3";
            Bai3.Size = new Size(129, 57);
            Bai3.TabIndex = 0;
            Bai3.Text = "Bài 3";
            Bai3.UseVisualStyleBackColor = true;
            Bai3.Click += Bai3_Click;
            // 
            // Bai4
            // 
            Bai4.Location = new Point(135, 236);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(129, 57);
            Bai4.TabIndex = 0;
            Bai4.Text = "Bài 4";
            Bai4.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            Bai5.Location = new Point(339, 236);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(129, 57);
            Bai5.TabIndex = 0;
            Bai5.Text = "Bài 5";
            Bai5.UseVisualStyleBackColor = true;
            Bai5.Click += Bai5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 77);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn bài cần thực hiện:";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(135, 339);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(129, 23);
            Thoat.TabIndex = 2;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(label1);
            Controls.Add(Bai3);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Controls.Add(Bai2);
            Controls.Add(Bai1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
        private Button Bai4;
        private Button Bai5;
        private Label label1;
        private Button Thoat;
    }
}
