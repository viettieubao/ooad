using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.Controller;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucQLPhieuXuatHang : UserControl
    {
        PhieuXuatHangController phieuxuatController = new PhieuXuatHangController();
        DataTable chiTietPhieuXuat = null;

        public ucQLPhieuXuatHang()
        {
            InitializeComponent();
            cbbTimKiem.SelectedIndex = 0;
            dgvDanhSachPhieuXuat.DataSource = phieuxuatController.GetAllPhieuXuat();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                if (cbbTimKiem.SelectedIndex == 1)
                {
                    dgvDanhSachPhieuXuat.DataSource = phieuxuatController.SearchTenKhachHang(txtTimKiem.Text);
                }
                else
                {
                }
            }
            else
            {
                dgvDanhSachPhieuXuat.DataSource = phieuxuatController.GetAllPhieuXuat();
            }
        }

        private void dgvDanhSachPhieuXuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuXuat.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtNgayXuat.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtMaHoaDon.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtTenKhachHang.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtDiaChi.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtSoDienThoai.Text = dgvDanhSachPhieuXuat.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

            chiTietPhieuXuat = phieuxuatController.GetChiTietPhieuXuat(int.Parse(txtMaPhieuXuat.Text));
            dgvChiTietPhieuXuat.DataSource = chiTietPhieuXuat;
        }
    }
}
