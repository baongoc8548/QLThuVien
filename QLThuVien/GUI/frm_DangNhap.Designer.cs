namespace QLThuVien.GUI
{
    partial class frm_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(156, 40);
            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(122, 23);
            this.txt_tenDangNhap.TabIndex = 1;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(156, 92);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(122, 23);
            this.txt_matKhau.TabIndex = 2;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(63, 142);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(87, 26);
            this.btn_dangNhap.TabIndex = 2;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(179, 142);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 26);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}