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
                cbbDonVi.Items.Add(row[0]);
                cbbDVBanle.Items.Add(row[0]);
                cbbDVBanSi.Items.Add(row[0]);
                
            }
        }

        private void dtpData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSanPham.Text = dtpData.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtMaSanPham.Text= dtpData.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtNhaCungCap.Text= dtpData.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtSoLuongBanSiToiThieu.Text= dtpData.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtSoLuongTon.Text= dtpData.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            txtSoLuongTonToiThieu.Text= dtpData.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            txtGiaBanSi.Text= dtpData.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtGiaBanLe.Text= dtpData.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            cbbDonVi.Text= dtpData.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            cbbDVBanSi.Text= dtpData.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            cbbDVBanle.Text= dtpData.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable();
            Clear();
        }

        private void Disable()
        {
            txtGiaBanLe.Enabled = false;
            txtGiaBanSi.Enabled = false;
            txtMaSanPham.Enabled = false;
            txtNhaCungCap.Enabled = false;
            txtSoLuongBanSiToiThieu.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtSoLuongTonToiThieu.Enabled = false;
            txtTenSanPham.Enabled = false;
            cbbDonVi.Enabled = false;
            cbbDVBanle.Enabled = false;
            cbbDVBanSi.Enabled = false;
        }

        private void Enable()
        {
            txtGiaBanLe.Enabled = true;
            txtGiaBanSi.Enabled = true;
            txtMaSanPham.Enabled = true;
            txtNhaCungCap.Enabled = true;
            txtSoLuongBanSiToiThieu.Enabled = true;
            txtSoLuongTon.Enabled = true;
            txtSoLuongTonToiThieu.Enabled = true;
            txtTenSanPham.Enabled = true;
            cbbDonVi.Enabled = true;
            cbbDVBanle.Enabled = true;
            cbbDVBanSi.Enabled = true;
        }
        private void Clear()
        {
            txtGiaBanLe.Text = "";
            txtGiaBanSi.Text = "";
            txtMaSanPham.Text = "";
            txtNhaCungCap.Text = "";
            txtSoLuongBanSiToiThieu.Text = "";
            txtSoLuongTon.Text = ""; ;
            txtSoLuongTonToiThieu.Text = "";
            txtTenSanPham.Text = "";
        }
    }
}
