using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiVatLieuXayDung.Model;
using System.Data;

namespace QuanLiVatLieuXayDung.Controller
{
    class PhieuXuatHangController
    {
        PhieuXuatHang phieuxuat = new PhieuXuatHang();
        HoaDon hoadon = new HoaDon();
        public int InsertPhieuXuatHang(int mahoadon, long tongTien, string tenNguoiGiaoHang, DataTable sanpham, List<int> maSP, List<int> donViTinh)
        {
            int result = 0;
            result = phieuxuat.InsertPhieuXuatHang(mahoadon, tongTien, tenNguoiGiaoHang, sanpham, maSP, donViTinh);
            hoadon.UpdateSoLuongDaXuat(mahoadon, sanpham, maSP);
            return result;
        }

        public DataTable SearchTenKhachHang(string tenKhachHang)
        {
            return phieuxuat.SearchTenKhachHang(tenKhachHang);
        }

        public DataTable SearchNgayLap(DateTime ngaylap)
        {
            return phieuxuat.SearchNgayLap(ngaylap);
        }

        public DataTable GetChiTietPhieuXuat(int maphieuxuat)
        {
            return phieuxuat.GetChiTietPhieuXuat(maphieuxuat);
        }

        public DataTable GetAllPhieuXuat()
        {
            return phieuxuat.GetAllPhieuXuat();
        }
    }
}
