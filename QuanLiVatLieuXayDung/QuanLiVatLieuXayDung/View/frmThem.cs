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
        ucLapPhieuNhapHang lapPhieuNhapHang;
        ucLapPhieuXuatHang lapPhieuXuatHang;
        public frmThem(int key)
        {
            InitializeComponent();
            if (key == 1) // lap hoa don
            {
                ucLapHoaDon = new ucLapHoaDon();
                panel1.Controls.Add(ucLapHoaDon);
                ucLapHoaDon.Dock = DockStyle.Fill;
                ucLapHoaDon.BringToFront();
            }
            if (key == 2) //lap phieu nhap hang
            {
                lapPhieuNhapHang = new ucLapPhieuNhapHang();
                panel1.Controls.Add(lapPhieuNhapHang);
                lapPhieuNhapHang.Dock = DockStyle.Fill;
                lapPhieuNhapHang.BringToFront();
            }
            if (key == 3) //lap phieu xuat hang
            {
                lapPhieuXuatHang = new ucLapPhieuXuatHang();
                panel1.Controls.Add(lapPhieuXuatHang);
                lapPhieuXuatHang.Dock = DockStyle.Fill;
                lapPhieuXuatHang.BringToFront();
            }
        }

        private void frmThem_Load(object sender, EventArgs e)
        {

        }
    }
}
