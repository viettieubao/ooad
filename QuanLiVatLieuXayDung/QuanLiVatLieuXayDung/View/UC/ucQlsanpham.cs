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

namespace QuanLiVatLieuXayDung.View
{
    public partial class ucQlsanpham : UserControl
    {
        public ucQlsanpham()
        {
            InitializeComponent();
            sanPham = new SanPhamController();
        }

        SanPhamController sanPham;
        private void ucQlsanpham_Load(object sender, EventArgs e)
        {
            Disable();
            dtpData.DataSource = sanPham.GetAllSanPham();
            DataTable data= sanPham.GetDanhSachDonVi();
            foreach ( DataRow row in data.Rows)
            {
                cbbDVBanle.Items.Add(row[0]);
                cbbDVBanSi.Items.Add(row[0]);
                
            }
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
            rdbGiaBanLe.Enabled = false;
            rdbGiaBanSi.Enabled = false;
            rdbGiaBanSi.Checked = true;
            txtTimTheoTen.Enabled = false;
        }

        private void dtpData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSanPham.Text = dtpData.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtMaSanPham.Text= dtpData.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtSoLuongBanSiToiThieu.Text= dtpData.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtSoLuongTon.Text= dtpData.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txtSoLuongTonToiThieu.Text= dtpData.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            txtGiaBanSi.Text= dtpData.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtGiaBanLe.Text= dtpData.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            lblDonvi.Text= "Đơn vị: "+ dtpData.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbbDVBanSi.Text= dtpData.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbbDVBanle.Text= dtpData.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable();
            Clear();
            txtMaSanPham.Enabled = false;
            cbbDVBanle.SelectedIndex = 0;
            cbbDVBanSi.SelectedIndex = 0;
        }

        private void Disable()
        {
            btnThemMoiSP.Enabled = false;
            txtGiaBanLe.Enabled = false;
            txtGiaBanSi.Enabled = false;
            txtMaSanPham.Enabled = false;
            txtSoLuongBanSiToiThieu.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtSoLuongTonToiThieu.Enabled = false;
            txtTenSanPham.Enabled = false;
            cbbDVBanle.Enabled = false;
            cbbDVBanSi.Enabled = false;
        }

        private void Enable()
        {
            btnThemMoiSP.Enabled = true;
            txtGiaBanLe.Enabled = true;
            txtGiaBanSi.Enabled = true;
            txtMaSanPham.Enabled = true;
            txtSoLuongBanSiToiThieu.Enabled = true;
            txtSoLuongTon.Enabled = true;
            txtSoLuongTonToiThieu.Enabled = true;
            txtTenSanPham.Enabled = true;
            cbbDVBanle.Enabled = true;
            cbbDVBanSi.Enabled = true;
        }
        private void Clear()
        {
            txtGiaBanLe.Text = "";
            txtGiaBanSi.Text = "";
            txtMaSanPham.Text = "";
            txtSoLuongBanSiToiThieu.Text = "";
            txtSoLuongTon.Text = ""; ;
            txtSoLuongTonToiThieu.Text = "";
            txtTenSanPham.Text = "";
        }

        private void btnThemMoiSP_Click(object sender, EventArgs e)
        {
            long giabansi, giabanle;
            int soluongton, soluongtontoithieu, soluongbansitoithieu;
            if (txtGiaBanLe.Text == "") giabanle = 0;
            else giabanle = long.Parse(txtGiaBanLe.Text);

            if (txtGiaBanSi.Text == "") giabansi = 0;
            else giabansi = long.Parse(txtGiaBanSi.Text);

            if (txtSoLuongTon.Text == "") soluongton = 0;
            else soluongton = int.Parse(txtSoLuongTon.Text);

            if (txtSoLuongTonToiThieu.Text == "") soluongtontoithieu = 0;
            else soluongtontoithieu = int.Parse(txtSoLuongTonToiThieu.Text);

            if (txtSoLuongBanSiToiThieu.Text == "") soluongbansitoithieu = 0;
            else soluongbansitoithieu = int.Parse(txtSoLuongBanSiToiThieu.Text);

            int result= sanPham.InsertSanPham(txtTenSanPham.Text, soluongbansitoithieu, cbbDVBanSi.SelectedIndex+1, cbbDVBanle.SelectedIndex+1, giabanle, giabansi, soluongton, soluongtontoithieu);
            
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                Disable();
                loadall();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void loadall()
        {
            dtpData.DataSource = sanPham.GetAllSanPham();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            int tem;
            long tem2;
            if (int.TryParse(txtSoLuongTon.Text,out tem) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên.");
            }else if (int.TryParse(txtSoLuongBanSiToiThieu.Text,out tem)==false)
            {
                MessageBox.Show("Số lượng tồn tối thiểu phải là số nguyên.");
            }
            else if (int.TryParse(txtSoLuongTonToiThieu.Text,out tem)==false)
            {
                MessageBox.Show("Số lượng tồn tối thiểu phải là số nguyên.");
            }
            else if (long.TryParse(txtGiaBanLe.Text,out tem2) == false)
            {
                MessageBox.Show("Giá bán lẻ phải là số nguyên.");
            }
            else if (long.TryParse(txtGiaBanSi.Text,out tem2) == false)
            {
                MessageBox.Show("Giá bán sỉ phải là số nguyên.");
            }
            else
            {
                int result =sanPham.UpdateSanPham(int.Parse(txtMaSanPham.Text), txtTenSanPham.Text, int.Parse(txtSoLuongBanSiToiThieu.Text), cbbDVBanSi.SelectedIndex+1, cbbDVBanle.SelectedIndex+1, long.Parse(txtGiaBanLe.Text), long.Parse(txtGiaBanSi.Text), int.Parse(txtSoLuongTon.Text), int.Parse(txtSoLuongTonToiThieu.Text));
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                    Disable();
                    loadall();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }


            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enable();
            txtMaSanPham.Enabled = false;
        }
        int flat = 0; // cờ hiệu tìm kiếm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa","Lựa chọn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = sanPham.Delete(int.Parse(txtMaSanPham.Text));
                
                if (result == 1)
                {
                    MessageBox.Show("Đã xóa.", "Thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại");
                }
                loadall();
            }
            
        }

        private void rdbGiaBanSi_Enter(object sender, EventArgs e)
        {
            rdbGiaBanLe.Checked = false;
            flat = 1;
        }

        private void rdbGiaBanLe_Enter(object sender, EventArgs e)
        {
            rdbGiaBanSi.Checked = false;
            flat = 0;
        }

        private void cbTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbTimTheoTen.CheckState == CheckState.Checked)
            {
                txtTimTheoTen.Enabled = true;
            }
            else
            {
                txtTimTheoTen.Enabled = false;
            }
        }

        private void CbTimTheoGia_CheckedChanged(object sender, EventArgs e)
        {
            if (CbTimTheoGia.CheckState == CheckState.Checked)
            {
                txtFrom.Enabled = true;
                txtTo.Enabled = true;
                rdbGiaBanLe.Enabled = true;
                rdbGiaBanSi.Enabled = true;
            }
            else
            {
                txtFrom.Enabled = false;
                txtTo.Enabled = false;
                rdbGiaBanLe.Enabled = false;
                rdbGiaBanSi.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTimTheoTen.CheckState == CheckState.Checked &&CbTimTheoGia.CheckState==CheckState.Unchecked ) //tìm theo tên
            {
                dtpData.DataSource = sanPham.SearchTheoTenSanPham(txtTimTheoTen.Text);
            }
            if (CbTimTheoGia.CheckState == CheckState.Checked && cbTimTheoTen.CheckState == CheckState.Unchecked)//tìm theo giá
            {
                dtpData.DataSource = sanPham.SearchTheoGiaSanPham(long.Parse(txtFrom.Text), long.Parse(txtTo.Text), flat);
            }else if (CbTimTheoGia.CheckState == CheckState.Checked && cbTimTheoTen.CheckState == CheckState.Checked)//tìm theo tên và giá
            {
                dtpData.DataSource = sanPham.SearchTheoTenVaGia(txtTimTheoTen.Text, long.Parse(txtFrom.Text), long.Parse(txtTo.Text), flat);
            }
            else if (CbTimTheoGia.CheckState==CheckState.Unchecked&&cbTimTheoTen.CheckState==CheckState.Unchecked)
            {
                loadall();
            }
        }
    }
}
