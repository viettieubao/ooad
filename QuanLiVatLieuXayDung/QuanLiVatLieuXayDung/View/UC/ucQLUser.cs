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
    public partial class ucQLUser : UserControl
    {
        int rule { get; set; }
        UserController user;
        public ucQLUser()
        {
            user = new UserController();
            rule = frmLogin.rule;
            InitializeComponent();
            txtDiaChi.Text=(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
            txtSoDienThoai.Text = rule.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int rerult =user.AddUser(txtTenTaiKhoan.Text, txtTenNhanVien.Text, dtpNgaySinh.Value, cbbBoPhan.SelectedIndex, txtDiaChi.Text, txtSoDienThoai.Text);
                if (rerult == 1)
                {
                    MessageBox.Show("Thêm mới tài khoản thành công", "Thành công");
                }
                else
                {
                    MessageBox.Show("Thêm mới tài khoản thất bại", "Thất bại");
                }
            }
            catch
            {

            }
        }
    }
}
