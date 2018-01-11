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
    public partial class frmThem : Form
    {
        ucLapHoaDon ucLapHoaDon;
        public frmThem()
        {
            InitializeComponent();
            ucLapHoaDon = new ucLapHoaDon();
            panel1.Controls.Add(ucLapHoaDon);
            ucLapHoaDon.Dock = DockStyle.Fill;
            ucLapHoaDon.BringToFront();
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ucLapHoaDon.Height.ToString());
        }
    }
}
