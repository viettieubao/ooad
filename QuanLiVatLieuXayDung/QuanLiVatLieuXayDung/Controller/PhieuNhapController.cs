using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;


namespace QuanLiVatLieuXayDung.Controller
{
    class PhieuNhapController
    {
        PhieuNhapHang phieuNhap = new PhieuNhapHang();
        Nhacungcap nhacungcap = new Nhacungcap();
        public DataTable GetAllPhieuNhap()
        {
            return phieuNhap.GetAllPhieuNhap();
        }

        public DataTable GetChiTietPhieuNhap(int maphieunhap)
        {
            return phieuNhap.GetChiTietPhieuNhap(maphieunhap);
        }

        public int InsertPhieuNhap(string maphieugiaohang,int manhacungcap, string nguoigiaohang, string sodienthoai, long tongtien, long sotiendathanhtoan, DateTime ngaynhap,DataTable danhsachsanpham)
        {
            if (phieuNhap.Insert(maphieugiaohang, manhacungcap, nguoigiaohang, sodienthoai, tongtien, sotiendathanhtoan, ngaynhap, danhsachsanpham) == 1)
            {
                nhacungcap.UpdateCongNoNhaCungCap(manhacungcap, tongtien - sotiendathanhtoan);
            }
            return 0;
        }

        public int Update(int maphieunhap, string nguoigiaohang, string sodienthoai, long tongtien,  long sotiendathanhtoan, DateTime ngaynhap)
        {
            return phieuNhap.Update(maphieunhap, nguoigiaohang, sodienthoai, tongtien,  sotiendathanhtoan, ngaynhap);
        }

        public DataTable Search(string nhacungcap, long tongtien, DateTime ngaynhap, int flat)
        {
            return phieuNhap.Search(nhacungcap, tongtien, ngaynhap, flat);
        }

        public DataTable GetAllPhieuNhapByNhaCungCap(string nhacungcap)
        {
            return phieuNhap.GetAllPhieuNhapByNhaCungCap(nhacungcap);
        }

        public DataTable GetAllNhaCC()
        {
            return phieuNhap.GetAllNhaCC();
        }
    }
}
