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
            dtpData.DataSource = sanPham.GetAllSanPham();
        }
    }
}
