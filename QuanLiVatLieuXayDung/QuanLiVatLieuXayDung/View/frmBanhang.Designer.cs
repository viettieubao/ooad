﻿namespace QuanLiVatLieuXayDung.View
{
    partial class frmBanhang
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
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucLapHoaDon1 = new QuanLiVatLieuXayDung.View.UC.ucLapHoaDon();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucQLKhachHang1 = new QuanLiVatLieuXayDung.View.UC.ucQLKhachHang();
            this.mnuDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(145, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucLapHoaDon1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 676);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Lập hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucLapHoaDon1
            // 
            this.ucLapHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLapHoaDon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLapHoaDon1.Location = new System.Drawing.Point(3, 3);
            this.ucLapHoaDon1.Margin = new System.Windows.Forms.Padding(4);
            this.ucLapHoaDon1.Name = "ucLapHoaDon1";
            this.ucLapHoaDon1.Size = new System.Drawing.Size(944, 670);
            this.ucLapHoaDon1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucQLKhachHang1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(950, 676);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Quản lý khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucQLKhachHang1
            // 
            this.ucQLKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQLKhachHang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucQLKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.ucQLKhachHang1.Margin = new System.Windows.Forms.Padding(4);
            this.ucQLKhachHang1.Name = "ucQLKhachHang1";
            this.ucQLKhachHang1.Size = new System.Drawing.Size(950, 676);
            this.ucQLKhachHang1.TabIndex = 0;
            // 
            // mnuDoimatkhau
            // 
            this.mnuDoimatkhau.Name = "mnuDoimatkhau";
            this.mnuDoimatkhau.Size = new System.Drawing.Size(145, 22);
            this.mnuDoimatkhau.Text = "Đổi mật khẩu";
            this.mnuDoimatkhau.Click += new System.EventHandler(this.mnuDoimatkhau_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(57, 20);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuTaikhoan
            // 
            this.mnuTaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoimatkhau,
            this.mnuThoat});
            this.mnuTaikhoan.Name = "mnuTaikhoan";
            this.mnuTaikhoan.Size = new System.Drawing.Size(70, 20);
            this.mnuTaikhoan.Text = "Tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabcontrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 705);
            this.panel2.TabIndex = 4;
            // 
            // tabcontrol
            // 
            this.tabcontrol.AccessibleName = "";
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(958, 705);
            this.tabcontrol.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaikhoan,
            this.mnuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBanhang";
            this.Text = "frmBanhang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBanhang_FormClosed);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem mnuDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuTaikhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private UC.ucQLKhachHang ucQLKhachHang1;
        private UC.ucLapHoaDon ucLapHoaDon1;
    }
}