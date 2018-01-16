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
    public partial class ucQlnhacungcap : UserControl
    {
        int state = -1;
        public ucQlnhacungcap()
        {
            InitializeComponent();
            nhacungcap = new NhacungcapController();
            sanPham = new SanPhamController();
        }
        NhacungcapController nhacungcap;
        SanPhamController sanPham;
        private void ucQlnhacungcap_Load(object sender, EventArgs e)
        {
            Disable();
            dtgNcc.DataSource = nhacungcap.GetAllNhacungcap();
        }
        private void loadall()
        {
            dtgNcc.DataSource = nhacungcap.GetAllNhacungcap();
        }
        private void dtgNcc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMancc.Text = dtgNcc.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenncc.Text = dtgNcc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtDiachi.Text = dtgNcc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtSdt.Text = dtgNcc.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtEmail.Text = dtgNcc.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtMsthue.Text = dtgNcc.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtCongno.Text = dtgNcc.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            if(txtMancc.Text!="")
                dtgSpncc.DataSource = nhacungcap.GetAllSpncc(int.Parse(txtMancc.Text));
        }
        private void Disable()
        {
            btnThemNCC.Enabled = false;
            btnCapnhat.Enabled = false;
            txtMancc.Enabled = false;
            txtTenncc.Enabled = false;
            txtDiachi.Enabled = false;
            txtMsthue.Enabled = false;
            txtSdt.Enabled = false;
            txtEmail.Enabled = false;
            txtCongno.Enabled = false;
        }

        private void Enable()
        {
            btnThemNCC.Enabled = false;
            btnCapnhat.Enabled = true;
            txtTenncc.Enabled = true;
            txtDiachi.Enabled = true;
            txtMsthue.Enabled = true;
            txtSdt.Enabled = true;
            txtEmail.Enabled = true;
            txtCongno.Enabled = true;
        }
        private void Clear()
        {
            txtTenncc.Text = "";
            txtDiachi.Text = "";
            txtMsthue.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtCongno.Text = "";
            txtMancc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 0;
                Enable();
                Clear();
                btnSua.Enabled = false;
                btnThem.Text = "Huỷ thêm";
                btnThemNCC.Enabled = true;
            }
            else
            {
                state = -1;
                Disable();
                loadall();
                btnSua.Enabled = true;
                btnThem.Text = "Thêm";
                btnThemNCC.Enabled = false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                state = 0;
                Enable();
                txtMancc.Enabled = false;
                btnCapnhat.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Text = "Huỷ sửa";
            }
            else
            {
                state = -1;
                Disable();
                loadall();
                btnCapnhat.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Text = "Sửa";
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Lựa chọn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = nhacungcap.DeleteNhacungcap(int.Parse(txtMancc.Text));

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
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            long congno;
            if (txtCongno.Text == "") congno = 0;
            else congno = long.Parse(txtCongno.Text);
            int result = nhacungcap.InsertNhacungcap(txtTenncc.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMsthue.Text, congno);
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
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                int result = nhacungcap.UpdateNhacungcap(int.Parse(txtMancc.Text), txtTenncc.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMsthue.Text, long.Parse(txtCongno.Text));
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                    Disable();
                    loadall();
                    state = -1;
                    btnCapnhat.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Text = "Sửa";
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dtgNcc.DataSource = nhacungcap.GetAllNhacungcap();
            }
            else
            {
                if (rdbMancc.Checked == true && rdbTenncc.Checked == false) //tìm theo mã ncc
                {
                    int tem;
                    if (int.TryParse(txtTim.Text, out tem) == false)
                    {
                        MessageBox.Show("Mã sản phẩm phải là số nguyên.");
                    } else
                    dtgNcc.DataSource = nhacungcap.SearchTheoMancc (int.Parse(txtTim.Text));
                }
                if (rdbTenncc.Checked == true && rdbMancc.Checked == false) //tìm theo tên ncc
                {
                    dtgNcc.DataSource = nhacungcap.SearchTheoTenncc(txtTim.Text);
                }
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                long congno;
                if (txtCongno.Text == "") congno = 0;
                else congno = long.Parse(txtCongno.Text);
                int result = nhacungcap.InsertNhacungcap(txtTenncc.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMsthue.Text, congno);
                if (result == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    Disable();
                    loadall();
                    btnSua.Enabled = true;
                    btnThem.Text = "Thêm";
                    btnThemNCC.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham.GetSanPhamTheoTen(cbbTensp.Text).Rows.Count != 0)
            {
                sanPham.UpdateNhaCC(int.Parse(txtMancc.Text), cbbTensp.Text);
                MessageBox.Show("Thêm thành công", "Thành công");
                if (txtMancc.Text != "")
                    dtgSpncc.DataSource = nhacungcap.GetAllSpncc(int.Parse(txtMancc.Text));
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thất bại");
            }

        }

        private void dtgSpncc_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
