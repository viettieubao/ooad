using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using QuanLiVatLieuXayDung.Controller;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapBaoCaoDoanhThu : UserControl
    {
        int nam = -1;
        BaoCaoController baocaoController = new BaoCaoController();
        BaoCaoDoanhThuController doanhthuController = new BaoCaoDoanhThuController();
        public ucLapBaoCaoDoanhThu()
        {
            InitializeComponent();
            cbbThang.SelectedIndex = 0;
        }

        private void btnLapbaocao_Click(object sender, EventArgs e)
        {
            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Năm báo cáo không được bỏ trống");
                return;
            }

            if (int.TryParse(txtNam.Text, out nam))
            {
                if (nam <= 2099 && nam >= 1990)
                {
                    //DataTable data = baocaoController.
                }
                else
                {
                    MessageBox.Show("Năm báo cáo phải trong khoảng năm 1990 - 2099");
                }
            }
            else
            {
                MessageBox.Show("Năm báo cáo phải ở định dạng số");
            }
        }
    }
}
