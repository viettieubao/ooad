namespace QuanLiVatLieuXayDung.View.UC
{
    partial class ucQlyphieunhaphang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimtheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimNCC = new System.Windows.Forms.Button();
            this.txtTimNCC = new System.Windows.Forms.TextBox();
            this.dgvDanhSachDonHangNhap = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNguoiGiaoHang = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonHangNhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietDonHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTimtheo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimNCC);
            this.groupBox1.Controls.Add(this.txtTimNCC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1204, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbTimtheo
            // 
            this.cbbTimtheo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTimtheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimtheo.FormattingEnabled = true;
            this.cbbTimtheo.Items.AddRange(new object[] {
            "Ngày lập",
            "Tên nhà cung cấp"});
            this.cbbTimtheo.Location = new System.Drawing.Point(789, 19);
            this.cbbTimtheo.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTimtheo.Name = "cbbTimtheo";
            this.cbbTimtheo.Size = new System.Drawing.Size(212, 24);
            this.cbbTimtheo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm theo";
            // 
            // btnTimNCC
            // 
            this.btnTimNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNCC.Location = new System.Drawing.Point(534, 16);
            this.btnTimNCC.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimNCC.Name = "btnTimNCC";
            this.btnTimNCC.Size = new System.Drawing.Size(133, 27);
            this.btnTimNCC.TabIndex = 1;
            this.btnTimNCC.Text = "Tìm";
            this.btnTimNCC.UseVisualStyleBackColor = true;
            this.btnTimNCC.Click += new System.EventHandler(this.btnTimNCC_Click);
            // 
            // txtTimNCC
            // 
            this.txtTimNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimNCC.Location = new System.Drawing.Point(183, 19);
            this.txtTimNCC.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimNCC.Name = "txtTimNCC";
            this.txtTimNCC.Size = new System.Drawing.Size(339, 22);
            this.txtTimNCC.TabIndex = 0;
            // 
            // dgvDanhSachDonHangNhap
            // 
            this.dgvDanhSachDonHangNhap.AllowUserToAddRows = false;
            this.dgvDanhSachDonHangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDonHangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDonHangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDonHangNhap.Location = new System.Drawing.Point(5, 20);
            this.dgvDanhSachDonHangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDanhSachDonHangNhap.Name = "dgvDanhSachDonHangNhap";
            this.dgvDanhSachDonHangNhap.ReadOnly = true;
            this.dgvDanhSachDonHangNhap.Size = new System.Drawing.Size(1194, 211);
            this.dgvDanhSachDonHangNhap.TabIndex = 0;
            this.dgvDanhSachDonHangNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonHangNhap_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSachDonHangNhap);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(1204, 236);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đơn hàng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 817);
            this.panel1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgChiTietDonHang);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 432);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1204, 385);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết lô hàng nhập";
            // 
            // dtgChiTietDonHang
            // 
            this.dtgChiTietDonHang.AllowUserToAddRows = false;
            this.dtgChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgChiTietDonHang.Location = new System.Drawing.Point(4, 19);
            this.dtgChiTietDonHang.Margin = new System.Windows.Forms.Padding(5);
            this.dtgChiTietDonHang.Name = "dtgChiTietDonHang";
            this.dtgChiTietDonHang.ReadOnly = true;
            this.dtgChiTietDonHang.Size = new System.Drawing.Size(1196, 362);
            this.dtgChiTietDonHang.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNgayNhap);
            this.groupBox2.Controls.Add(this.txtTenNhaCungCap);
            this.groupBox2.Controls.Add(this.btnThemPN);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtThanhToan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNguoiGiaoHang);
            this.groupBox2.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1204, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu nhập hàng";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayNhap.Location = new System.Drawing.Point(837, 25);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.ReadOnly = true;
            this.txtNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.txtNgayNhap.TabIndex = 30;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(477, 23);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.ReadOnly = true;
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(200, 22);
            this.txtTenNhaCungCap.TabIndex = 29;
            // 
            // btnThemPN
            // 
            this.btnThemPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPN.Location = new System.Drawing.Point(907, 86);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(130, 38);
            this.btnThemPN.TabIndex = 28;
            this.btnThemPN.Text = "Thêm phiếu nhập";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1052, 60);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "VND";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "VND";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhToan.Location = new System.Drawing.Point(837, 56);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(200, 22);
            this.txtThanhToan.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thanh toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Location = new System.Drawing.Point(477, 57);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 22);
            this.txtTongTien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày nhập";
            // 
            // txtNguoiGiaoHang
            // 
            this.txtNguoiGiaoHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNguoiGiaoHang.Location = new System.Drawing.Point(166, 60);
            this.txtNguoiGiaoHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtNguoiGiaoHang.Name = "txtNguoiGiaoHang";
            this.txtNguoiGiaoHang.ReadOnly = true;
            this.txtNguoiGiaoHang.Size = new System.Drawing.Size(200, 22);
            this.txtNguoiGiaoHang.TabIndex = 9;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(166, 28);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(134, 22);
            this.txtMaPhieuNhap.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Người giao hàng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phiếu nhập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà cung cấp";
            // 
            // ucQlyphieunhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucQlyphieunhaphang";
            this.Size = new System.Drawing.Size(1204, 817);
            this.Load += new System.EventHandler(this.ucLapphieunhaphang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonHangNhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietDonHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTimtheo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimNCC;
        private System.Windows.Forms.TextBox txtTimNCC;
        private System.Windows.Forms.DataGridView dgvDanhSachDonHangNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguoiGiaoHang;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgChiTietDonHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
    }
}
