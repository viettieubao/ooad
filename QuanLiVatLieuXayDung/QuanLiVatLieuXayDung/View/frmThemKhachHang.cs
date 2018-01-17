using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.Controller;
namespace QuanLiVatLieuXayDung.View
{
    public partial class frmThemKhachHang : Form
    {
        KhachhangController khachhang;
        public frmThemKhachHang()
        {
            InitializeComponent();
            khachhang = new KhachhangController();
        }


        private void btnKhoaThem_Click(object sender, EventArgs e)
        {
            khachhang.InsertKhachhang(txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text);
            MessageBox.Show("Thêm thành công!");
            this.Close();
        }

        private void btnKhoaCapNhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
