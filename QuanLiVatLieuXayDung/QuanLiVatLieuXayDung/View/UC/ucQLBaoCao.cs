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
    public partial class ucQLBaoCao : UserControl
    {
        BaoCaoController baocaoController = new BaoCaoController();
        public ucQLBaoCao()
        {
            InitializeComponent();
            dgvDanhSachBaoCao.DataSource = baocaoController.GetAllBaoCao();
            cbbThang.SelectedIndex = 0;
            cbbNam.DataSource = baocaoController.GetAllNamBaoCao();
            cbbNam.DisplayMember = "nambaocao";
            cbbNam.SelectedIndex = 0;
            cbbLoaiBaoCao.Items.Clear();
            if (frmLogin.rule == "admin")
            {
                cbbLoaiBaoCao.Items.Add("Báo cáo tồn");
                cbbLoaiBaoCao.Items.Add("Báo cáo doanh thu");
                cbbLoaiBaoCao.Items.Add("Báo cáo công nợ khách hàng");
                cbbLoaiBaoCao.Items.Add("Báo cáo công nợ cửa hàng");
                cbbLoaiBaoCao.SelectedIndex = 0;
            }
            else
            {
                cbbLoaiBaoCao.Items.Add("Báo cáo doanh thu");
                cbbLoaiBaoCao.Items.Add("Báo cáo công nợ khách hàng");
                cbbLoaiBaoCao.Items.Add("Báo cáo công nợ cửa hàng");
                cbbLoaiBaoCao.SelectedIndex = 0;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int nam = 0;
            if (cbbNam.Items.Count > 0)
            {
                if (int.TryParse(cbbNam.Text, out nam))
                {
                    dgvDanhSachBaoCao.DataSource = baocaoController.SearchBaoCao(cbbLoaiBaoCao.Text, cbbThang.SelectedIndex + 1, int.Parse(cbbNam.Text));
                }
            }
        }
    }
}
