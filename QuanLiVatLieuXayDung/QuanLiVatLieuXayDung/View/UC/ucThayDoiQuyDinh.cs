using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucThayDoiQuyDinh : UserControl
    {
        public ucThayDoiQuyDinh()
        {
            InitializeComponent();
            txtGia.Enabled = false;
            btnXacnhan.Enabled = false;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Thay đổi thành công");
                txtGia.Enabled = false;
                btnXacnhan.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                txtGia.Text = "";
                txtGia.Enabled = false;
                btnXacnhan.Enabled = false;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            btnXacnhan.Enabled = true;
            txtGia.Enabled = true;
        }
    }
}
