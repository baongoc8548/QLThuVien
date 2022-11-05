namespace QLThuVien.GUI
{
    partial class frm_DocGia
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maDocGia = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_force = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_maDocGia
            // 
            this.txt_maDocGia.Location = new System.Drawing.Point(146, 60);
            this.txt_maDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maDocGia.Name = "txt_maDocGia";
            this.txt_maDocGia.Size = new System.Drawing.Size(388, 23);
            this.txt_maDocGia.TabIndex = 1;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(146, 94);
            this.txt_hoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(388, 23);
            this.txt_hoTen.TabIndex = 1;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(146, 130);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(388, 23);
            this.txt_diaChi.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(146, 166);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(388, 23);
            this.txt_sdt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 134);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(16, 204);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(87, 26);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(205, 204);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 26);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(110, 204);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(87, 26);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(299, 204);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(87, 26);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm theo tên";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(541, 204);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(87, 26);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(394, 207);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(141, 23);
            this.txt_tim.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_force
            // 
            this.btn_force.Location = new System.Drawing.Point(487, 16);
            this.btn_force.Name = "btn_force";
            this.btn_force.Size = new System.Drawing.Size(142, 23);
            this.btn_force.TabIndex = 8;
            this.btn_force.Text = "Quản lý mượn trả sách";
            this.btn_force.UseVisualStyleBackColor = true;
            this.btn_force.Click += new System.EventHandler(this.btn_force_Click);
            // 
            // frm_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 421);
            this.Controls.Add(this.btn_force);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_maDocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.QL_DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_maDocGia;
        public System.Windows.Forms.TextBox txt_hoTen;
        public System.Windows.Forms.TextBox txt_diaChi;
        public System.Windows.Forms.TextBox txt_sdt;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_them;
        public System.Windows.Forms.Button btn_xoa;
        public System.Windows.Forms.Button btn_sua;
        public System.Windows.Forms.Button btn_tim;
        public System.Windows.Forms.Button btn_load;
        public System.Windows.Forms.TextBox txt_tim;
        private Button btn_back;
        private Button btn_force;
    }
}