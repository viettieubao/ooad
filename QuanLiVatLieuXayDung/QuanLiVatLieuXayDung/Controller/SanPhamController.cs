using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class SanPhamController
    {
        SanPham sanPham = new SanPham();
        public DataTable GetAllSanPham()
        {
            return sanPham.GetAllSanPham();
        }
        public int UpdateSanPham(int masanpham, string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle, long giabanle, long giabansi, int soluong,int soluongtontoithieu)
        {
            return sanPham.UpdateSanPham(masanpham,tensanpham, soluongbansitoithieu, donvibansi,donvibanle,giabanle,giabansi,soluong,soluongtontoithieu);
        }
        public DataTable GetDanhSachDonVi()
        {
            return sanPham.GetDanhSachDonVi();
        }

        public int InsertSanPham(string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle, long giabanle, long giabansi, int soluong, int soluongtontoithieu)
        {
            return sanPham.InsertSanPham(tensanpham, soluongbansitoithieu, donvibansi, donvibanle, giabansi, giabanle, soluong, soluongtontoithieu);
        }

        public int Delete(int masanpham)
        {
            return sanPham.DeleteSanPham(masanpham);
        }

        public DataTable SearchTheoTenSanPham(string tensanpham)
        {
            return sanPham.SearchTheoTenSanPham(tensanpham);
        }

        public DataTable SearchTheoGiaSanPham(long from, long to, int flat)
        {
            return sanPham.SearchTheoGiaSanPham(from, to, flat);
        }

        public DataTable SearchTheoTenVaGia(string tensanpham, long from, long to, int flat)
        {
            return sanPham.SearchTheoTenVaGia(tensanpham, from, to, flat);
        }

    }
}
