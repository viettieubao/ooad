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
        public DataTable SearchTenKhachHang(string tenKhachHang)
        {
            return hoaDon.GetHoaDonWithTenKhachHang(tenKhachHang);
        }
        public DataTable SearchMaKhachHang(int makhachhang)
        {
            return hoaDon.GetHoaDonWithMaKhachHang(makhachhang);
        }
        public DataTable SearchMaHoaDon(int maHoaDon)
        {
            return hoaDon.GetHoaDonWithMaDonHang(maHoaDon);
        }
        public DataTable SearchNgayLap(DateTime ngaylap)
        {
            return hoaDon.GetHoaDonWithNgayLap(ngaylap);
        }

        public DataTable GetChiTietHoaDon(int maHoaDon)
        {
            return hoaDon.GetChiTietHoaDon(maHoaDon);
        }

    }
}
