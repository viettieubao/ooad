using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuanLiVatLieuXayDung.Report
{
    public partial class HoaDonOutput : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonOutput()
        {
            InitializeComponent();
        }

        public void InitData(string tenkhachhang, string diachi, int madonhang, string sodienthoai, string tongsotienbangchu)
        {
            prDiaChi.Value = diachi;
            prTenkhachhang.Value = tenkhachhang;
            prSoDienThoai.Value = sodienthoai;
            prMaDonHang.Value = madonhang;
            prTongTienBangChu.Value = tongsotienbangchu;
        }
    }
}
