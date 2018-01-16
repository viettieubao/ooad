namespace QuanLiVatLieuXayDung.View.UC
{
    partial class ucLapBaoCaoDoanhThu
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
            this.btnLuuxuat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLapbaocao = new System.Windows.Forms.Button();
            this.dtgDoanhThu = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTongdoanhthu = new System.Windows.Forms.TextBox();
            this.txtTonghoadon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuxuat
            // 
            this.btnLuuxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuxuat.Location = new System.Drawing.Point(915, 61);
            this.btnLuuxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuxuat.Name = "btnLuuxuat";
            this.btnLuuxuat.Size = new System.Drawing.Size(143, 29);
            this.btnLuuxuat.TabIndex = 3;
            this.btnLuuxuat.Text = "Lưu và xuất";
            this.btnLuuxuat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(750, 61);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 29);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbNam);
            this.groupBox4.Controls.Add(this.cbbThang);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnLapbaocao);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1075, 61);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(328, 25);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(121, 21);
            this.cbbNam.TabIndex = 7;
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "Một",
            "Hai",
            "Ba",
            "Tư",
            "Năm",
            "Sáu",
            "Bảy",
            "Tám",
            "Chín",
            "Mười",
            "Mười một",
            "Mười hai"});
            this.cbbThang.Location = new System.Drawing.Point(146, 25);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng";
            // 
            // btnLapbaocao
            // 
            this.btnLapbaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapbaocao.Location = new System.Drawing.Point(513, 21);
            this.btnLapbaocao.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapbaocao.Name = "btnLapbaocao";
            this.btnLapbaocao.Size = new System.Drawing.Size(100, 28);
            this.btnLapbaocao.TabIndex = 1;
            this.btnLapbaocao.Text = "Lập báo cáo";
            this.btnLapbaocao.UseVisualStyleBackColor = true;
            // 
            // dtgDoanhThu
            // 
            this.dtgDoanhThu.AllowUserToAddRows = false;
            this.dtgDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDoanhThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgDoanhThu.Location = new System.Drawing.Point(0, 61);
            this.dtgDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDoanhThu.Name = "dtgDoanhThu";
            this.dtgDoanhThu.ReadOnly = true;
            this.dtgDoanhThu.Size = new System.Drawing.Size(1075, 327);
            this.dtgDoanhThu.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTongdoanhthu);
            this.groupBox6.Controls.Add(this.txtTonghoadon);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btnLuuxuat);
            this.groupBox6.Controls.Add(this.btnLuu);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 388);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1075, 98);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // txtTongdoanhthu
            // 
            this.txtTongdoanhthu.Location = new System.Drawing.Point(185, 46);
            this.txtTongdoanhthu.Name = "txtTongdoanhthu";
            this.txtTongdoanhthu.Size = new System.Drawing.Size(237, 20);
            this.txtTongdoanhthu.TabIndex = 6;
            // 
            // txtTonghoadon
            // 
            this.txtTonghoadon.Location = new System.Drawing.Point(185, 20);
            this.txtTonghoadon.Name = "txtTonghoadon";
            this.txtTonghoadon.Size = new System.Drawing.Size(237, 20);
            this.txtTonghoadon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số hóa đơn";
            // 
            // ucLapBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgDoanhThu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Name = "ucLapBaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1075, 486);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuuxuat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLapbaocao;
        private System.Windows.Forms.DataGridView dtgDoanhThu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTongdoanhthu;
        private System.Windows.Forms.TextBox txtTonghoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
