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
    public partial class ucLapBaoCaoCongNo : UserControl
    {
        BaoCaoCongNoCuaHangController congnocuahangController = new BaoCaoCongNoCuaHangController();
        BaoCaoCongNoKhachHangController congnokhachhangController = new BaoCaoCongNoKhachHangController();
        NhacungcapController nhacungcapController = new NhacungcapController();
        public ucLapBaoCaoCongNo()
        {
            InitializeComponent();
            cbbLoaiBaoCao.SelectedIndex = 0;
            cbbThang.SelectedIndex = 0;
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            int nam = 0;
            if (int.TryParse(txtNam.Text, out nam))
            {
                if (nam >= 1990 && nam <= 2099)
                {
                    if (cbbLoaiBaoCao.SelectedIndex == 0)
                    {
                        //congnocuahangController.Insert()
                        dgvBaoCao.DataSource = nhacungcapController.GetAllNhaCungCapConNo();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm báo cáo từ năm 1990 - 2099");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm báo cáo ở định dạng số");
            }
        }
    }
}
