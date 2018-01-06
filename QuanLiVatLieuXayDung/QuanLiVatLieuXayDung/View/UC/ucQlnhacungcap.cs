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
        public ucQlnhacungcap()
        {
            InitializeComponent();
            nhacungcap = new NhacungcapController();
        }
        NhacungcapController nhacungcap;
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
            if(txtMancc.Text!="") dtgSpncc.DataSource = nhacungcap.GetAllSpncc(int.Parse(txtMancc.Text));
        }
        private void Disable()
        {
            btnThemmoi.Enabled = false;
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
            btnThemmoi.Enabled = true;
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
            Enable();
            Clear();
            btnCapnhat.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Enable();
            btnThemmoi.Enabled = false;
            txtMancc.Enabled = false;
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
            int result = nhacungcap.UpdateNhacungcap(int.Parse(txtMancc.Text), txtTenncc.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMsthue.Text, long.Parse(txtCongno.Text));
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
    }
}
