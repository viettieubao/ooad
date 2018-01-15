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
    public partial class ucQLHoaDon : UserControl
    {
        HoaDonController hoadonController = new HoaDonController();
        public ucQLHoaDon()
        {
            InitializeComponent();
            cbbTimKiem.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                int value = 0;
                bool isNumber = int.TryParse(txtTimKiem.Text, out value);
                if (cbbTimKiem.SelectedIndex == 0)
                {
                    dgvDanhSachHoaDon.DataSource = hoadonController.SearchMaHoaDon(value);
                }
                else if (cbbTimKiem.SelectedIndex == 1)
                {
                    int day, month, year;
                    string[] array = txtTimKiem.Text.Split('/');
                    if (array.Length == 3)
                    {
                        if (int.TryParse(array[0], out day) && int.TryParse(array[1], out month) && int.TryParse(array[2], out year))
                        {
                            DateTime date = new DateTime(year, month, day);
                            dgvDanhSachHoaDon.DataSource = hoadonController.SearchNgayLap(date);
                        }
                    }
                }
                else if (cbbTimKiem.SelectedIndex == 2)
                {

                }
                else if (cbbTimKiem.SelectedIndex == 3)
                {
                    dgvDanhSachHoaDon.DataSource = hoadonController.SearchTenKhachHang(txtTimKiem.Text);
                }
            }
        }

        private void dgvDanhSachHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHoaDon.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhachHang.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtNgayLap.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtTongTienHoaDon.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtMaHoaDon.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

            dgvChiTietHoaDon.DataSource = hoadonController.GetChiTietHoaDon(int.Parse(dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()));
        }
    }
}
