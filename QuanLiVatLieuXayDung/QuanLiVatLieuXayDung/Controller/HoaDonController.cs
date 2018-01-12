using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class HoaDonController
    {
        HoaDon hoaDon = new HoaDon();
        public int InsertHoaDon(int makhachang, long tongtien, long thuevat, DateTime ngaylap, DataTable sanpham)
        {
            return hoaDon.InsertHoaDon(makhachang, tongtien, thuevat, ngaylap, sanpham);
        }
    }
}
