namespace QuanLiVatLieuXayDung.View.UC
{
    partial class ucLapBaoCaoTon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLuuXuat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvChiTietBaoCao = new System.Windows.Forms.DataGridView();
            this.clmnMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoLuongTonDauThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoLuongTonCuoiThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoLuongNhapTrongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoLuongXuatTrongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoCao)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbThang);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtNam);
            this.groupBox4.Controls.Add(this.btnLapBaoCao);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1075, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // cbbThang
            // 
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "Một",
            "Hai",
            "Ba",
            "Bốn",
            "Năm",
            "Sáu",
            "Bảy",
            "Tám",
            "Chín",
            "Mười",
            "Mười Một",
            "Mười Hai"});
            this.cbbThang.Location = new System.Drawing.Point(216, 24);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(173, 24);
            this.cbbThang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNam.Location = new System.Drawing.Point(470, 24);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(173, 23);
            this.txtNam.TabIndex = 5;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCao.Location = new System.Drawing.Point(697, 21);
            this.btnLapBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(100, 28);
            this.btnLapBaoCao.TabIndex = 1;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLuuXuat);
            this.groupBox6.Controls.Add(this.btnLuu);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 436);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1075, 50);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnLuuXuat
            // 
            this.btnLuuXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuXuat.Location = new System.Drawing.Point(552, 18);
            this.btnLuuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuXuat.Name = "btnLuuXuat";
            this.btnLuuXuat.Size = new System.Drawing.Size(143, 28);
            this.btnLuuXuat.TabIndex = 3;
            this.btnLuuXuat.Text = "Lưu và xuất";
            this.btnLuuXuat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(381, 18);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 28);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvChiTietBaoCao
            // 
            this.dgvChiTietBaoCao.AllowUserToAddRows = false;
            this.dgvChiTietBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnMaSanPham,
            this.clmnTenSanPham,
            this.clmnTenNhaCungCap,
            this.clmnSoLuongTonDauThang,
            this.clmnSoLuongTonCuoiThang,
            this.clmnSoLuongNhapTrongThang,
            this.clmnSoLuongXuatTrongThang});
            this.dgvChiTietBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietBaoCao.Location = new System.Drawing.Point(4, 19);
            this.dgvChiTietBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietBaoCao.Name = "dgvChiTietBaoCao";
            this.dgvChiTietBaoCao.ReadOnly = true;
            this.dgvChiTietBaoCao.Size = new System.Drawing.Size(1067, 387);
            this.dgvChiTietBaoCao.TabIndex = 0;
            // 
            // clmnMaSanPham
            // 
            this.clmnMaSanPham.HeaderText = "Mã sản phẩm";
            this.clmnMaSanPham.Name = "clmnMaSanPham";
            this.clmnMaSanPham.ReadOnly = true;
            // 
            // clmnTenSanPham
            // 
            this.clmnTenSanPham.HeaderText = "Sản phẩm";
            this.clmnTenSanPham.Name = "clmnTenSanPham";
            this.clmnTenSanPham.ReadOnly = true;
            // 
            // clmnTenNhaCungCap
            // 
            this.clmnTenNhaCungCap.HeaderText = "Nhà cung cấp";
            this.clmnTenNhaCungCap.Name = "clmnTenNhaCungCap";
            this.clmnTenNhaCungCap.ReadOnly = true;
            // 
            // clmnSoLuongTonDauThang
            // 
            this.clmnSoLuongTonDauThang.HeaderText = "Số lượng tồn đầu tháng";
            this.clmnSoLuongTonDauThang.Name = "clmnSoLuongTonDauThang";
            this.clmnSoLuongTonDauThang.ReadOnly = true;
            // 
            // clmnSoLuongTonCuoiThang
            // 
            this.clmnSoLuongTonCuoiThang.HeaderText = "Số lượng tồn cuối tháng";
            this.clmnSoLuongTonCuoiThang.Name = "clmnSoLuongTonCuoiThang";
            this.clmnSoLuongTonCuoiThang.ReadOnly = true;
            // 
            // clmnSoLuongNhapTrongThang
            // 
            this.clmnSoLuongNhapTrongThang.HeaderText = "Số lượng nhập trong tháng";
            this.clmnSoLuongNhapTrongThang.Name = "clmnSoLuongNhapTrongThang";
            this.clmnSoLuongNhapTrongThang.ReadOnly = true;
            // 
            // clmnSoLuongXuatTrongThang
            // 
            this.clmnSoLuongXuatTrongThang.HeaderText = "Số lượng xuất trong tháng";
            this.clmnSoLuongXuatTrongThang.Name = "clmnSoLuongXuatTrongThang";
            this.clmnSoLuongXuatTrongThang.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvChiTietBaoCao);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 76);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1075, 410);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết";
            // 
            // ucLapBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucLapBaoCaoTon";
            this.Size = new System.Drawing.Size(1075, 486);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoCao)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLuuXuat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvChiTietBaoCao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoLuongTonDauThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoLuongTonCuoiThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoLuongNhapTrongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoLuongXuatTrongThang;
    }
}
