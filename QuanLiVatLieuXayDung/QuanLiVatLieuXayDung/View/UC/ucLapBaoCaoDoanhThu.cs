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
        int thang = -1;
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
            thang = cbbThang.SelectedIndex + 1;
            if (int.TryParse(txtNam.Text, out nam))
            {
                if (nam <= 2099 && nam >= 1990)
                {
                    txtTonghoadon.Text = doanhthuController.TongHoaDon(thang, nam).ToString();
                    txtTongdoanhthu.Text = doanhthuController.TongDoanhThu(thang, nam).ToString();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int nambaocao = 0;
            if (int.TryParse(txtNam.Text, out nambaocao) && nambaocao != nam)
            {
                MessageBox.Show("Vui lòng chọn Lập báo cáo trước khi lưu báo cáo");
                return;
            }
            if (cbbThang.SelectedIndex + 1 != thang)
            {
                MessageBox.Show("Vui lòng chọn Lập báo cáo trước khi lưu báo cáo");
                return;
            }
            int sohoadon = 0, sodoanhthu = 0;
            if (int.TryParse(txtTonghoadon.Text, out sohoadon) && int.TryParse(txtTongdoanhthu.Text, out sodoanhthu))
            {
                baocaoController.InsertBaoCaoDoanhThu(thang, nam, sohoadon, sodoanhthu);
            }
        }
    }
}
