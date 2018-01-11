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
        }

        SanPhamController sanPham;
        private void ucQlsanpham_Load(object sender, EventArgs e)
        {
          
        }

        

        private void Disable()
        {
           
        }

        private void Enable()
        {
        }
        private void Clear()
        {
            
        }

        private void loadall()
        {
           
        }

        private void btnThemMoiSP_Click_1(object sender, EventArgs e)
        {
            string thanhtien = (long.Parse(txtGiaBan.Text)*int.Parse(txtSoLuong.Text)).ToString();
            string[] row = new string[] {txtMaSP.Text,cbbTenSanPham.Text,cbbDonVi.Text,txtGiaBan.Text,txtSoLuong.Text,thanhtien };
            dtpData.Rows.Add(row);
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

        }
    }
}
