namespace QLThuVien
{
    partial class frm_MuonSach
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
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.txt_MaMuonSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_TraSach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_XemTatCa = new System.Windows.Forms.Button();
            this.txt_TenDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_force = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Location = new System.Drawing.Point(197, 54);
            this.txt_MaDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.Size = new System.Drawing.Size(152, 23);
            this.txt_MaDocGia.TabIndex = 1;
            this.txt_MaDocGia.TextChanged += new System.EventHandler(this.txt_MaDocGia_TextChanged);
            // 
            // txt_MaMuonSach
            // 
            this.txt_MaMuonSach.Location = new System.Drawing.Point(485, 54);
            this.txt_MaMuonSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaMuonSach.Name = "txt_MaMuonSach";
            this.txt_MaMuonSach.Size = new System.Drawing.Size(133, 23);
            this.txt_MaMuonSach.TabIndex = 3;
            this.txt_MaMuonSach.TextChanged += new System.EventHandler(this.txt_MaMuonSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã mượn sách";
            // 
            // btn_Muon
            // 
            this.btn_Muon.Location = new System.Drawing.Point(360, 142);
            this.btn_Muon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(108, 26);
            this.btn_Muon.TabIndex = 4;
            this.btn_Muon.Text = "Mượn sách";
            this.btn_Muon.UseVisualStyleBackColor = true;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_TraSach
            // 
            this.btn_TraSach.Location = new System.Drawing.Point(240, 142);
            this.btn_TraSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TraSach.Name = "btn_TraSach";
            this.btn_TraSach.Size = new System.Drawing.Size(108, 26);
            this.btn_TraSach.TabIndex = 5;
            this.btn_TraSach.Text = "Trả sách";
            this.btn_TraSach.UseVisualStyleBackColor = true;
            this.btn_TraSach.Click += new System.EventHandler(this.btn_TraSach_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(888, 185);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(97, 198);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(251, 23);
            this.txt_Tim.TabIndex = 7;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(370, 195);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(164, 26);
            this.btn_Tim.TabIndex = 8;
            this.btn_Tim.Text = "Tìm theo số điện thoại";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_XemTatCa
            // 
            this.btn_XemTatCa.Location = new System.Drawing.Point(549, 195);
            this.btn_XemTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XemTatCa.Name = "btn_XemTatCa";
            this.btn_XemTatCa.Size = new System.Drawing.Size(108, 26);
            this.btn_XemTatCa.TabIndex = 9;
            this.btn_XemTatCa.Text = "Xem tất cả";
            this.btn_XemTatCa.UseVisualStyleBackColor = true;
            this.btn_XemTatCa.Click += new System.EventHandler(this.btn_XemTatCa_Click);
            // 
            // txt_TenDocGia
            // 
            this.txt_TenDocGia.Enabled = false;
            this.txt_TenDocGia.Location = new System.Drawing.Point(197, 94);
            this.txt_TenDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenDocGia.Name = "txt_TenDocGia";
            this.txt_TenDocGia.Size = new System.Drawing.Size(152, 23);
            this.txt_TenDocGia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên độc giả";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Enabled = false;
            this.txt_TenSach.Location = new System.Drawing.Point(485, 94);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(133, 23);
            this.txt_TenSach.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Danh sách phiếu mượn";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(41, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_force
            // 
            this.btn_force.Location = new System.Drawing.Point(718, 16);
            this.btn_force.Name = "btn_force";
            this.btn_force.Size = new System.Drawing.Size(142, 23);
            this.btn_force.TabIndex = 18;
            this.btn_force.Text = "Chi tiết sách";
            this.btn_force.UseVisualStyleBackColor = true;
            this.btn_force.Click += new System.EventHandler(this.btn_force_Click);
            // 
            // frm_MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 497);
            this.Controls.Add(this.btn_force);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_XemTatCa);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TraSach);
            this.Controls.Add(this.btn_Muon);
            this.Controls.Add(this.txt_MaMuonSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaDocGia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_MuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MuonSach";
            this.Load += new System.EventHandler(this.frm_MuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_MaDocGia;
        public System.Windows.Forms.TextBox txt_MaMuonSach;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_Muon;
        public System.Windows.Forms.Button btn_TraSach;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_Tim;
        public System.Windows.Forms.Button btn_Tim;
        public System.Windows.Forms.Button btn_XemTatCa;
        public System.Windows.Forms.TextBox txt_TenDocGia;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_TenSach;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private Button btn_back;
        private Button btn_force;
    }
}