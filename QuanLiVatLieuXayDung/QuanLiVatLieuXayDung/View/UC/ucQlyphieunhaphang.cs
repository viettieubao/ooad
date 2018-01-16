using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QuanLiVatLieuXayDung.Controller;
using QuanLiVatLieuXayDung.View;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucQlyphieunhaphang : UserControl
    {
        PhieuNhapController phieunhapController = new PhieuNhapController();
        DataTable chitietphieunhap = null;

        public ucQlyphieunhaphang()
        {
            InitializeComponent();
            if (frmLogin.rule!="Quản lí kho")
            {
                btnThemPN.Enabled = false;
            }
            dgvDanhSachDonHangNhap.DataSource = phieunhapController.GetAllPhieuNhap();
            cbbTimtheo.SelectedIndex = 0;
        }

        private void ucLapphieunhaphang_Load(object sender, EventArgs e)
        {
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnThemPN_Click(object sender, EventArgs e)
        {
            frmThem them = new frmThem(2);
            them.ShowDialog();
        }

        private void btnTimNCC_Click(object sender, EventArgs e)
        {
            if (txtTimNCC.Text.Trim() != "")
            {
                if (cbbTimtheo.SelectedIndex == 1)
                {
                    dgvDanhSachDonHangNhap.DataSource = phieunhapController.GetAllPhieuNhapByNhaCungCap(txtTimNCC.Text);
                }
                else
                {
                }
            }
            else
            {
                dgvDanhSachDonHangNhap.DataSource = phieunhapController.GetAllPhieuNhap();
            }
        }

        private void dgvDanhSachDonHangNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtNgayNhap.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtTenNhaCungCap.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNguoiGiaoHang.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtTongTien.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtThanhToan.Text = dgvDanhSachDonHangNhap.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

            chitietphieunhap = phieunhapController.GetChiTietPhieuNhap(int.Parse(txtMaPhieuNhap.Text));
            dtgChiTietDonHang.DataSource = chitietphieunhap;
        }
    }
}
