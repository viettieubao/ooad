using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View
{
    public partial class frmBanhang : Form
    {
        public frmBanhang()
        {
            InitializeComponent();
        }

        private void mnuDoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoimatkhau frmDoimatkhau = new frmDoimatkhau();
            frmDoimatkhau.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn logout không?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void frmBanhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không", "Exit", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                frmLogin.close();
            }
        }
    }
}
