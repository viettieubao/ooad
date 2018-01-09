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
    public partial class ucQlkhachhang : UserControl
    {
        KhachhangController khachhang;
        public ucQlkhachhang()
        {
            InitializeComponent();
            khachhang = new KhachhangController();
            Disable();
            dtgKhachhang.DataSource = khachhang.GetAllKhachhang();
        }
        private void ucQlkhachhang_Load(object sender, EventArgs e)
        {
            
        }
        private void loadall()
        {
            dtgKhachhang.DataSource = khachhang.GetAllKhachhang();
        }
   
        private void Enable()
        {
            btnThemmoi.Enabled = true;
            btnCapnhat.Enabled = true;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtMsthue.Enabled = true;
            txtSdt.Enabled = true;
            txtCongno.Enabled = true;
        }
        private void Disable()
        {
            btnThemmoi.Enabled = false;
            btnCapnhat.Enabled = false;
            txtMakhachhang.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMsthue.Enabled = false;
            txtSdt.Enabled = false;
            txtCongno.Enabled = false;
        }
        private void Clear()
        {
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtMsthue.Text = "";
            txtSdt.Text = "";
            txtCongno.Text = "";
            txtMakhachhang.Text = "";
        }
        private void dtgKhachhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtMakhachhang.Text = dtgKhachhang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTen.Text = dtgKhachhang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtSdt.Text = dtgKhachhang.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtDiachi.Text = dtgKhachhang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtMsthue.Text = dtgKhachhang.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtCongno.Text = dtgKhachhang.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable();
            Clear();
            btnCapnhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enable();
            btnThemmoi.Enabled = false;
            txtMakhachhang.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Lựa chọn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = khachhang.DeleteKhachhang(int.Parse(txtMakhachhang.Text));

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
            int result = khachhang.InsertKhachhang(txtTen.Text, txtDiachi.Text, txtSdt.Text, txtMsthue.Text, congno);
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
                int result = khachhang.UpdateKhachhang(int.Parse(txtMakhachhang.Text), txtTen.Text, txtDiachi.Text, txtSdt.Text, txtMsthue.Text, long.Parse(txtCongno.Text));
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dtgKhachhang.DataSource = khachhang.GetAllKhachhang();
            }
            else
            {
                if (rdbMakhachhang.Checked == true) //tìm theo mã khách hàng
                {
                    int tem;
                    if (int.TryParse(txtTim.Text, out tem) == false)
                    {
                        MessageBox.Show("Mã khách hàng phải là số nguyên.");
                    }
                    else
                        dtgKhachhang.DataSource = khachhang.SearchTheoMakhachhang(int.Parse(txtTim.Text));
                }
                if (rdbTenkhachhang.Checked == true) //tìm theo tên khách hàng
                {
                    dtgKhachhang.DataSource = khachhang.SearchTheoTenkhachhang(txtTim.Text);
                }
            }
        }
    }
}
