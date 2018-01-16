using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class BaoCaoDoanhThuController
    {
        BaoCaoDoanhThu Baocaodoanhthu = new BaoCaoDoanhThu();
        public DataTable GetAllDoanhthu()
        {
            return Baocaodoanhthu.GetAllDoanhthu();
        }
        public DataTable TongHoaDon(int thang, int nam)
        {
            return Baocaodoanhthu.TongHoaDon(thang, nam);
        }
    }
}
