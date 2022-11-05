namespace QLThuVien
{
    partial class frm_SachChiTiet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.rbt_DangMuon = new System.Windows.Forms.RadioButton();
            this.rbt_Con = new System.Windows.Forms.RadioButton();
            this.btn_XemTatCa = new System.Windows.Forms.Button();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.txt_KetQua = new System.Windows.Forms.Label();
            this.txt_MaMuonSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(555, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên sách";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(149, 49);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(127, 23);
            this.txt_Tim.TabIndex = 2;
            // 
            // rbt_DangMuon
            // 
            this.rbt_DangMuon.AutoSize = true;
            this.rbt_DangMuon.Location = new System.Drawing.Point(345, 134);
            this.rbt_DangMuon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_DangMuon.Name = "rbt_DangMuon";
            this.rbt_DangMuon.Size = new System.Drawing.Size(111, 19);
            this.rbt_DangMuon.TabIndex = 3;
            this.rbt_DangMuon.TabStop = true;
            this.rbt_DangMuon.Text = "Đang cho mượn";
            this.rbt_DangMuon.UseVisualStyleBackColor = true;
            this.rbt_DangMuon.CheckedChanged += new System.EventHandler(this.rbt_DangMuon_CheckedChanged);
            // 
            // rbt_Con
            // 
            this.rbt_Con.AutoSize = true;
            this.rbt_Con.Location = new System.Drawing.Point(239, 134);
            this.rbt_Con.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_Con.Name = "rbt_Con";
            this.rbt_Con.Size = new System.Drawing.Size(47, 19);
            this.rbt_Con.TabIndex = 4;
            this.rbt_Con.TabStop = true;
            this.rbt_Con.Text = "Còn";
            this.rbt_Con.UseVisualStyleBackColor = true;
            this.rbt_Con.CheckedChanged += new System.EventHandler(this.rbt_Con_CheckedChanged);
            // 
            // btn_XemTatCa
            // 
            this.btn_XemTatCa.Location = new System.Drawing.Point(476, 129);
            this.btn_XemTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XemTatCa.Name = "btn_XemTatCa";
            this.btn_XemTatCa.Size = new System.Drawing.Size(120, 28);
            this.btn_XemTatCa.TabIndex = 5;
            this.btn_XemTatCa.Text = "Xem tất cả";
            this.btn_XemTatCa.UseVisualStyleBackColor = true;
            this.btn_XemTatCa.Click += new System.EventHandler(this.btn_XemTatCa_Click);
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(292, 44);
            this.btn_KiemTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(78, 29);
            this.btn_KiemTra.TabIndex = 6;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.AutoSize = true;
            this.txt_KetQua.Location = new System.Drawing.Point(46, 82);
            this.txt_KetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(68, 15);
            this.txt_KetQua.TabIndex = 7;
            this.txt_KetQua.Text = "Kết quả tim";
            // 
            // txt_MaMuonSach
            // 
            this.txt_MaMuonSach.Location = new System.Drawing.Point(415, 383);
            this.txt_MaMuonSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaMuonSach.Name = "txt_MaMuonSach";
            this.txt_MaMuonSach.Size = new System.Drawing.Size(79, 23);
            this.txt_MaMuonSach.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã mượn sách";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(517, 380);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 28);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xoá sách";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(39, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_SachChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 419);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaMuonSach);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.btn_XemTatCa);
            this.Controls.Add(this.rbt_Con);
            this.Controls.Add(this.rbt_DangMuon);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_SachChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SachChiTiet";
            this.Load += new System.EventHandler(this.frm_SachChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Tim;
        public System.Windows.Forms.RadioButton rbt_DangMuon;
        public System.Windows.Forms.RadioButton rbt_Con;
        public System.Windows.Forms.Button btn_XemTatCa;
        public System.Windows.Forms.Button btn_KiemTra;
        public System.Windows.Forms.Label txt_KetQua;
        public System.Windows.Forms.TextBox txt_MaMuonSach;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_Xoa;
        private Button btn_back;
    }
}