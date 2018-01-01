using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.View.UC;

namespace QuanLiVatLieuXayDung.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ucQlsanpham ucQlsanpham;
        ucQLHoaDon ucQLHoadon;
        ucQLUser ucQLUser;
        private void Form1_Load(object sender, EventArgs e)
        {
            int rule = frmLogin.rule;
            //ucQlsanpham = new ucQlsanpham();
            //panel1.Controls.Add(ucQlsanpham);
            //ucQlsanpham.Dock = DockStyle.Fill;
            //ucQlsanpham.BringToFront();

            //ucQLHoadon = new ucQLHoaDon();
            //panel1.Controls.Add(ucQLHoadon);
            //ucQLHoadon.Dock = DockStyle.Fill;
            //ucQLHoadon.BringToFront();

            ucQLUser = new ucQLUser();
            panel1.Controls.Add(ucQLUser);
            ucQLUser.Dock = DockStyle.Fill;
            ucQLUser.BringToFront();
        }
    }
}
