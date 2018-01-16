using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class PhieuThuTienController
    {
        PhieuThuTien phieuthutien = new PhieuThuTien();
        public DataTable GetAllPhieuThuTien()
        {
            return phieuthutien.GetAllPhieuThuTien();
        }
        public int Insert(int mahoadon, string lydothutien, long sotiendathu)
        {
            return phieuthutien.InsertPhieuThuTien(mahoadon, lydothutien, sotiendathu);
        }
        public DataTable GetAllPhieuThuTienByMaPhieuThuTien(int maphieuthutien)
        {
            return phieuthutien.SearchMaPhieuThuTien(maphieuthutien);
        }
        public DataTable GetAllPhieuThuTienByNgayLap(DateTime ngaylap)
        {
            return phieuthutien.SearchNgayLap(ngaylap);
        }
        public DataTable GetAllPhieuThuTienByTenKhachHang(string tenkhachhang)
        {
            return phieuthutien.SearchTenKhachHang(tenkhachhang);
        }
    }
}
