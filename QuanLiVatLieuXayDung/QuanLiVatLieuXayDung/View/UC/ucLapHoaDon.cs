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

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapHoaDon : UserControl
    {
        public ucLapHoaDon()
        {
            InitializeComponent();
            sanPham = new SanPhamController();
            khachhang = new KhachhangController();
            hoaDon = new HoaDonController();
        }

        SanPhamController sanPham;
        KhachhangController khachhang;
        HoaDonController hoaDon;
        private void ucQlsanpham_Load(object sender, EventArgs e)
        {
            DataTable dt = sanPham.GetAllSanPham();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenSanPham.Items.Add(row[1]);
            }
            dt = khachhang.GetAllKhachhang();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenKhachHang.Items.Add(row[1]);
            }
        }

        long tongtien = 0;
        private void btnThemMoiSP_Click_1(object sender, EventArgs e)
        {
            tongtien += long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text);

            string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
            string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
            dtpData.Rows.Add(row);

            txtTongTien.Text = tongtien.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
            string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
            int index = dtpData.CurrentRow.Index;
            dtpData.Rows.RemoveAt(index);
            dtpData.Rows.Insert(index, row);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtpData.Rows.RemoveAt(dtpData.CurrentRow.Index);
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            int makhachhang=0;
            if (tongtien > 10000000)
            {
                makhachhang = int.Parse(khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][0].ToString());
            }
            else
            {
                makhachhang = -1;
            }
            DataTable datatable = new DataTable();
            if (dtpData.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dtpData.Columns)
                {
                    datatable.Columns.Add(col.Name);
                }
            }
            if (dtpData.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dtpData.Rows)
                {
                    DataRow dr;
                    dr = datatable.NewRow();

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dr[i] = row.Cells[i].Value;
                    }
                    datatable.Rows.Add(dr);
                }
                
            }
            hoaDon.InsertHoaDon(makhachhang, tongtien, tongtien, dtpNgayLap.Value, datatable);


        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDonVi.Items.Clear();
            if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows.Count != 0)
            {
                string masanpham = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][0].ToString();
                txtMaSP.Text = masanpham;
                txtSoLuongBanSiTT.Text= sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][5].ToString();

                cbbDonVi.Items.Add(sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3]);
                cbbDonVi.Items.Add(sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][4]);
            }
            else
            {
                MessageBox.Show("San phẩm không tồn tại","Lỗi");
            }
        }

        private void cbbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonVi.Text== sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3].ToString())
            {
                txtGiaBan.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][1].ToString();
            }
            else
            {
                txtGiaBan.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][2].ToString();
            }
        }
    }
}
