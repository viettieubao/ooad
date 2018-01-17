using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using QuanLiVatLieuXayDung.Controller;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapPhieuThuTien : UserControl
    {
        PhieuThuTienController phieuthuController = new PhieuThuTienController();
        HoaDonController hoadonController = new HoaDonController();
        public ucLapPhieuThuTien()
        {
            InitializeComponent();
            cbbTimKiem.SelectedIndex = 0;
        }

        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "")
            {
                long sotienthanhtoan = 0;
                int mahoadon = int.Parse(txtMaHoaDon.Text);
                if (long.TryParse(txtSoTienThanhToan.Text, out sotienthanhtoan))
                {
                    if (sotienthanhtoan > int.Parse(txtConNo.Text))
                    {
                        MessageBox.Show("Số tiền thu không được quá số tiền nợ", "Cảnh báo");
                        return;
                    }
                    else
                    {
                        phieuthuController.Insert(mahoadon, txtLyDoThu.Text, sotienthanhtoan);
                        long tongtien = hoadonController.GetTongTienHoaDon(mahoadon);
                        long dathanhtoan = hoadonController.GetSoTienDaTraHoaDon(mahoadon);
                        txtTongTienHoaDon.Text = tongtien.ToString();
                        txtDaThanhToan.Text = dathanhtoan.ToString();
                        txtConNo.Text = (tongtien - dathanhtoan).ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mã hoá đơn. Vui lòng tìm kiếm và chọn hoá đơn", "Cảnh báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {

                if (cbbTimKiem.SelectedIndex == 0)
                {
                    int number = 0;
                    if (int.TryParse(txtTimKiem.Text, out number))
                    {
                        dgvDanhSachHoaDon.DataSource = hoadonController.SearchMaHoaDon(number);
                    }

                }
                else
                {
                    dgvDanhSachHoaDon.DataSource = hoadonController.SearchTenKhachHang(txtTimKiem.Text);
                }
            }
            else
            {
                dgvDanhSachHoaDon.DataSource = hoadonController.GetAllHoaDon();
            }
        }

        private void dgvDanhSachHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHoaDon.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhachHang.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtNgayLap.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            int mahoadon = int.Parse(txtMaHoaDon.Text);
            long tongtien = hoadonController.GetTongTienHoaDon(mahoadon);
            long dathanhtoan = hoadonController.GetSoTienDaTraHoaDon(mahoadon);
            txtTongTienHoaDon.Text = tongtien.ToString();
            txtDaThanhToan.Text = dathanhtoan.ToString();
            txtConNo.Text = (tongtien - dathanhtoan).ToString();
        }
    }
}
