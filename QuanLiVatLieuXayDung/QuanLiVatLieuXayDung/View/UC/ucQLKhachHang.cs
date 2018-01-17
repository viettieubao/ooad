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
    public partial class ucQLKhachHang : UserControl
    {
        KhachhangController khachhangController = new KhachhangController();
        HoaDonController hoadonController = new HoaDonController();
        DataTable chitietkhachhang = null;
        int state = -1;
        public ucQLKhachHang()
        {
            InitializeComponent();
            if (frmLogin.rule == "admin")
            {
                btnThemKhachHang.Enabled = false;
                btnSuaKhachHang.Enabled = false;
            }
            btnKhoaCapNhat.Enabled = false;
            btnKhoaThem.Enabled = false;
            Lock();
            txtCongNo.ReadOnly = true;
            dgvDanhSachKhachHang.DataSource = khachhangController.GetAllKhachhang();
        }

        private void Lock()
        {
            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
        }

        private void ClearTextbox()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void Unlock()
        {
            txtTenKhachHang.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachKhachHang.DataSource = khachhangController.SearchTheoTenkhachhang(txtTimKiem.Text);
        }

        private void dgvDanhSachHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhachHang.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtSoDienThoai.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtDiaChi.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCongNo.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            chitietkhachhang = hoadonController.SearchMaKhachHang(int.Parse(txtMaKhachHang.Text));
            dgvDanhSachHoaDon.DataSource = chitietkhachhang;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 0;
                btnSuaKhachHang.Enabled = false;
                btnKhoaThem.Enabled = true;
                btnKhoaCapNhat.Enabled = false;
                btnThemKhachHang.Text = "Huỷ thêm";
                ClearTextbox();
                Unlock();
            }
            else
            {
                state = -1;
                Lock();
                btnSuaKhachHang.Enabled = true;
                btnKhoaThem.Enabled = false;
                btnKhoaCapNhat.Enabled = false;
                btnThemKhachHang.Text = "Thêm khách hàng";

                txtMaKhachHang.Text = dgvDanhSachKhachHang.CurrentRow.Cells[0].FormattedValue.ToString();
                txtTenKhachHang.Text = dgvDanhSachKhachHang.CurrentRow.Cells[1].FormattedValue.ToString();
                txtSoDienThoai.Text = dgvDanhSachKhachHang.CurrentRow.Cells[3].FormattedValue.ToString();
                txtDiaChi.Text = dgvDanhSachKhachHang.CurrentRow.Cells[2].FormattedValue.ToString();
                txtCongNo.Text = dgvDanhSachKhachHang.CurrentRow.Cells[4].FormattedValue.ToString();
                Lock();
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 1;
                btnThemKhachHang.Enabled = false;
                btnKhoaThem.Enabled = false;
                btnKhoaCapNhat.Enabled = true;
                btnSuaKhachHang.Text = "Huỷ sửa";
                Unlock();
            }
            else
            {
                state = -1;
                Lock();
                btnThemKhachHang.Enabled = true;
                btnKhoaThem.Enabled = false;
                btnKhoaCapNhat.Enabled = false;
                btnSuaKhachHang.Text = "Sửa";

                txtMaKhachHang.Text = dgvDanhSachKhachHang.CurrentRow.Cells[0].FormattedValue.ToString();
                txtTenKhachHang.Text = dgvDanhSachKhachHang.CurrentRow.Cells[1].FormattedValue.ToString();
                txtSoDienThoai.Text = dgvDanhSachKhachHang.CurrentRow.Cells[3].FormattedValue.ToString();
                txtDiaChi.Text = dgvDanhSachKhachHang.CurrentRow.Cells[2].FormattedValue.ToString();
                txtCongNo.Text = dgvDanhSachKhachHang.CurrentRow.Cells[4].FormattedValue.ToString();
                Lock();
            }
        }

        private void btnKhoaCapNhat_Click(object sender, EventArgs e)
        {
            state = -1;
            btnKhoaCapNhat.Enabled = false;
            btnKhoaThem.Enabled = false;
            btnThemKhachHang.Enabled = true;
            btnSuaKhachHang.Text = "Sửa";
            khachhangController.UpdateKhachhang(int.Parse(txtMaKhachHang.Text), txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text);
            dgvDanhSachKhachHang.DataSource = khachhangController.SearchTheoTenkhachhang(txtTimKiem.Text);
            Lock();
        }

        private void btnKhoaThem_Click(object sender, EventArgs e)
        {
            state = -1;
            btnKhoaCapNhat.Enabled = false;
            btnKhoaThem.Enabled = false;
            btnSuaKhachHang.Enabled = true;
            btnThemKhachHang.Text = "Thêm khách hàng";
            khachhangController.InsertKhachhang(txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text);
            dgvDanhSachKhachHang.DataSource = khachhangController.SearchTheoTenkhachhang(txtTimKiem.Text);
            Lock();
        }
    }
}
