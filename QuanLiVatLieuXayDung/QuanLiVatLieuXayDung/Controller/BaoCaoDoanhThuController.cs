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
        public int TongHoaDon(int thang, int nam)
        {
            DataTable dt = Baocaodoanhthu.TongHoaDon(thang, nam);
            int result = 0;
            if (int.TryParse(dt.Rows[0][0].ToString(), out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        public int TongDoanhThu(int thang, int nam)
        {
            DataTable dt = Baocaodoanhthu.GetTongDoanhThu(thang, nam);
            int result = 0;
            if (int.TryParse(dt.Rows[0][0].ToString(), out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
