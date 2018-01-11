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
    public partial class ucQlyphieunhaphang : UserControl
    {
        PhieuNhapController phieunhap;
        public ucQlyphieunhaphang()
        {
            InitializeComponent();
            phieunhap = new PhieuNhapController();

        }

        private void ucLapphieunhaphang_Load(object sender, EventArgs e)
        {
            dtgDSDonHang.DataSource = phieunhap.GetAllPhieuNhap();
            DataTable dt = phieunhap.GetAllNhaCC();
            foreach(DataRow row in dt.Rows)
            {
                cbbTenNhaCC.Items.Add(row[0]);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaSp_Click(object sender, EventArgs e)
        {

        }
    }
}
