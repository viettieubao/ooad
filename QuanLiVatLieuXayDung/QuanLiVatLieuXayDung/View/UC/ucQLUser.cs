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
        string rule { get; set; }
        UserController user;
        int state = -1;
        public ucQLUser()
        {
            user = new UserController();
            rule = frmLogin.rule;
            InitializeComponent();
            loadall();
            cbbTimtheo.SelectedIndex = 0;
            cbbBoPhan.SelectedIndex = 1;
            Dissable();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                try
                {
                    if (txtTenNhanVien.Text != "" && txtTenTaiKhoan.Text != "")
                    {
                        int rerult = user.AddUser(txtTenTaiKhoan.Text, txtTenNhanVien.Text, dtpNgaySinh.Value, cbbBoPhan.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                        if (rerult == 1)
                        {
                            MessageBox.Show("Thêm mới tài khoản thành công", "Thành công");
                            loadall();
                            Dissable();
                            btnThem.Enabled = false;
                            btnSua.Enabled = true;
                            state = -1;
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới tài khoản thất bại", "Thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa điền đầy đủ các trường bắt buộc", "Cảnh báo");
                    }
                }
                catch
                {

                }
            }
        }
        private void loadall()
        {
            dtgDanhsach.DataSource = user.GetAll();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tennv="";
            string bophan="";
            if (cbbTimtheo.SelectedIndex == 0)
            {
                tennv = txtTim.Text;
            }
            else
                bophan = txtTim.Text;
            if (tennv != "" || bophan != "")
                dtgDanhsach.DataSource = user.Search(tennv, bophan);
            else
                loadall();
            

        }

        private void dtgDanhsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNhanVien.Text =
            dtgDanhsach.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtSoDienThoai.Text= dtgDanhsach.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtDiaChi.Text= dtgDanhsach.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtTenTaiKhoan.Text= dtgDanhsach.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            cbbBoPhan.Text = dtgDanhsach.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dtgDanhsach.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                if (txtTenNhanVien.Text != "" && txtTenTaiKhoan.Text != "")
                {
                    int result = user.UpdateUser(txtTenTaiKhoan.Text, txtTenNhanVien.Text, dtpNgaySinh.Value, cbbBoPhan.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loadall();
                        Dissable();
                        btnCapNhat.Enabled = false;
                        btnThemNhanVien.Enabled = true;
                        state = -1;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }          
                }
                else
                {
                    MessageBox.Show("Chưa điền đầy đủ các trường bắt buộc", "Cảnh báo");
                }
            }
        }
        private void Dissable()
        {
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            cbbBoPhan.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }
        private void Enable()
        {
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtTenTaiKhoan.Enabled = true;
            cbbBoPhan.Enabled = true;
            dtpNgaySinh.Enabled = true;
        }
        private void Clear()
        {
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhanVien.Text = "";
            txtTenTaiKhoan.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbbBoPhan.SelectedIndex = 0;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 0;
                Clear();
                Enable();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnThemNhanVien.Text = "Huỷ thêm";
            }
            else
            {
                state = -1;
                btnThemNhanVien.Text = "Thêm";
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                Dissable();
                Clear();
                loadall();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 0;
                Enable();
                txtTenTaiKhoan.Enabled = false;
                btnCapNhat.Enabled = true;
                btnThemNhanVien.Enabled = false;
                btnSua.Text = "Huỷ sửa";
            }
            else
            {
                state = -1;
                btnSua.Text = "Sửa";
                btnCapNhat.Enabled = false;
                btnThemNhanVien.Enabled = true;
                Dissable();
                Clear();
                loadall();
            }
        }



        private void btnActive_Click(object sender, EventArgs e)
        {
            user.Enable(txtTenTaiKhoan.Text);
            loadall();
        }

        private void btnDeActive_Click(object sender, EventArgs e)
        {
            user.Disable(txtTenTaiKhoan.Text);
            loadall();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            user.ResetMakhau(txtTenTaiKhoan.Text);
            MessageBox.Show("Đã reset về mật khẩu mặc định là 123456.");
        }
    }
}
