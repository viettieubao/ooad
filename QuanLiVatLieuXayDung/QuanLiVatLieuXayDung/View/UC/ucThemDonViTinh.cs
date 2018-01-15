using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using QuanLiVatLieuXayDung.Controller;
using System.Windows.Forms;


namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucThemDonViTinh : UserControl
    {
        DonViTinhController donviController = new DonViTinhController();
        public ucThemDonViTinh()
        {
            InitializeComponent();
            dgvDonViTinh.DataSource = donviController.GetAllDonViTinh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length != 0)
            {
                dgvDonViTinh.DataSource = donviController.GetAllDonViTinhWithTenDonVi(txtTimKiem.Text);
            }
            else
            {
                dgvDonViTinh.DataSource = donviController.GetAllDonViTinh();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length != 0)
            {
                dgvDonViTinh.DataSource = donviController.Insert(txtTenDonViTinh.Text);
                dgvDonViTinh.DataSource = donviController.GetAllDonViTinh();
            }
        }
    }
}
