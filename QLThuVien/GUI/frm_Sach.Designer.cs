namespace QLThuVien.GUI
{
    partial class frm_Sach
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maSach = new System.Windows.Forms.TextBox();
            this.txt_tenSach = new System.Windows.Forms.TextBox();
            this.txt_tacGia = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_theLoai = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // txt_maSach
            // 
            this.txt_maSach.Location = new System.Drawing.Point(138, 65);
            this.txt_maSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maSach.Name = "txt_maSach";
            this.txt_maSach.Size = new System.Drawing.Size(373, 23);
            this.txt_maSach.TabIndex = 1;
            // 
            // txt_tenSach
            // 
            this.txt_tenSach.Location = new System.Drawing.Point(138, 103);
            this.txt_tenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenSach.Name = "txt_tenSach";
            this.txt_tenSach.Size = new System.Drawing.Size(373, 23);
            this.txt_tenSach.TabIndex = 1;
            // 
            // txt_tacGia
            // 
            this.txt_tacGia.Location = new System.Drawing.Point(138, 138);
            this.txt_tacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tacGia.Name = "txt_tacGia";
            this.txt_tacGia.Size = new System.Drawing.Size(373, 23);
            this.txt_tacGia.TabIndex = 1;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(138, 215);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(373, 23);
            this.txt_soLuong.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 173);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cb_theLoai
            // 
            this.cb_theLoai.FormattingEnabled = true;
            this.cb_theLoai.Location = new System.Drawing.Point(138, 178);
            this.cb_theLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_theLoai.Name = "cb_theLoai";
            this.cb_theLoai.Size = new System.Drawing.Size(373, 23);
            this.cb_theLoai.TabIndex = 3;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(518, 62);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(87, 26);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(612, 63);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(87, 26);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(707, 63);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 26);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(518, 100);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(87, 26);
            this.btn_tim.TabIndex = 4;
            this.btn_tim.Text = "Tìm theo tên";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(518, 136);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(87, 26);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(612, 103);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(181, 23);
            this.txt_tim.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(16, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_force
            // 
            this.btn_force.Location = new System.Drawing.Point(639, 5);
            this.btn_force.Name = "btn_force";
            this.btn_force.Size = new System.Drawing.Size(142, 23);
            this.btn_force.TabIndex = 19;
            this.btn_force.Text = "Chi tiết sách";
            this.btn_force.UseVisualStyleBackColor = true;
            this.btn_force.Click += new System.EventHandler(this.btn_force_Click);
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 454);
            this.Controls.Add(this.btn_force);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cb_theLoai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_tacGia);
            this.Controls.Add(this.txt_tenSach);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.txt_maSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Sach";
            this.Load += new System.EventHandler(this.QL_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_maSach;
        public System.Windows.Forms.TextBox txt_tenSach;
        public System.Windows.Forms.TextBox txt_tacGia;
        public System.Windows.Forms.TextBox txt_soLuong;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cb_theLoai;
        public System.Windows.Forms.Button btn_them;
        public System.Windows.Forms.Button btn_sua;
        public System.Windows.Forms.Button btn_xoa;
        public System.Windows.Forms.Button btn_tim;
        public System.Windows.Forms.Button btn_load;
        public System.Windows.Forms.TextBox txt_tim;
        private Button btn_back;
        private Button btn_force;
    }
}