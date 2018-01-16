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
    public partial class ucQLPhieuThuTien : UserControl
    {
        PhieuThuTienController phieuthutienController = new PhieuThuTienController();
        public ucQLPhieuThuTien()
        {
            InitializeComponent();
            cbbTimKiem.SelectedIndex = 0;
            dgvDanhSachPhieuThuTien.DataSource = phieuthutienController.GetAllPhieuThuTien();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                if (cbbTimKiem.SelectedIndex == 0)
                {
                    int maphieuthutien = 0;
                    if (int.TryParse(txtTimKiem.Text, out maphieuthutien))
                    {
                        dgvDanhSachPhieuThuTien.DataSource = phieuthutienController.GetAllPhieuThuTienByMaPhieuThuTien(maphieuthutien);
                    }
                    else
                    {
                        MessageBox.Show("Mã phiếu thu tiền tìm kiếm phải ở định dạng số", "Cảnh báo");
                    }
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
                            dgvDanhSachPhieuThuTien.DataSource = phieuthutienController.GetAllPhieuThuTienByNgayLap(date);
                        }
                        else
                        {
                            MessageBox.Show("Ngày lập tìm kiếm sai định dạng");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày lập tìm kiếm sai định dạng");
                        return;
                    }
                }
                else if (cbbTimKiem.SelectedIndex == 2)
                {
                    dgvDanhSachPhieuThuTien.DataSource = phieuthutienController.GetAllPhieuThuTienByTenKhachHang(txtTimKiem.Text);
                }
            }
            else
            {
                dgvDanhSachPhieuThuTien.DataSource = phieuthutienController.GetAllPhieuThuTien();
            }
        }

        private void dgvDanhSachPhieuThuTien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachPhieuThuTien.Rows.Count > 0)
            {
                txtMaPhieuThuTien.Text = dgvDanhSachPhieuThuTien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenKhachHang.Text = dgvDanhSachPhieuThuTien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtNgayLap.Text = dgvDanhSachPhieuThuTien.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                txtLyDoThuTien.Text = dgvDanhSachPhieuThuTien.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtSoTienThu.Text = dgvDanhSachPhieuThuTien.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            }
        }
    }
}
