namespace QuanLiVatLieuXayDung.View
{
    partial class frmKetoan
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ucQLBaoCao1 = new QuanLiVatLieuXayDung.View.UC.ucQLBaoCao();
            this.ucQLPhieuThuTien1 = new QuanLiVatLieuXayDung.View.UC.ucQLPhieuThuTien();
            this.tabcontrol.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.AccessibleName = "";
            this.tabcontrol.Controls.Add(this.tabPage5);
            this.tabcontrol.Controls.Add(this.tabPage6);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1038, 541);
            this.tabcontrol.TabIndex = 0;
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(145, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
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
            this.panel2.Size = new System.Drawing.Size(1038, 541);
            this.panel2.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaikhoan,
            this.mnuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ucQLPhieuThuTien1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1030, 512);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Quản lý phiếu thu tiền";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ucQLBaoCao1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1000, 676);
            this.tabPage6.TabIndex = 8;
            this.tabPage6.Text = "Quản lí báo cáo";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ucQLBaoCao1
            // 
            this.ucQLBaoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQLBaoCao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucQLBaoCao1.Location = new System.Drawing.Point(0, 0);
            this.ucQLBaoCao1.Margin = new System.Windows.Forms.Padding(4);
            this.ucQLBaoCao1.Name = "ucQLBaoCao1";
            this.ucQLBaoCao1.Size = new System.Drawing.Size(1000, 676);
            this.ucQLBaoCao1.TabIndex = 0;
            // 
            // ucQLPhieuThuTien1
            // 
            this.ucQLPhieuThuTien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQLPhieuThuTien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucQLPhieuThuTien1.Location = new System.Drawing.Point(3, 3);
            this.ucQLPhieuThuTien1.Margin = new System.Windows.Forms.Padding(4);
            this.ucQLPhieuThuTien1.Name = "ucQLPhieuThuTien1";
            this.ucQLPhieuThuTien1.Size = new System.Drawing.Size(1024, 506);
            this.ucQLPhieuThuTien1.TabIndex = 0;
            // 
            // frmKetoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmKetoan";
            this.Text = "frmKetoan";
            this.tabcontrol.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuTaikhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage5;
        private UC.ucQLPhieuThuTien ucQLPhieuThuTien1;
        private System.Windows.Forms.TabPage tabPage6;
        private UC.ucQLBaoCao ucQLBaoCao1;
    }
}