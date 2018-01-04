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
        public int UpdateSanPham(int masanpham, string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle, string giabanle, string giabansi, int soluong,int soluongtontoithieu)
        {
            return sanPham.UpdateSanPham(masanpham,tensanpham, soluongbansitoithieu, donvibansi,donvibanle,giabanle,giabansi,soluong,soluongtontoithieu);
        }
        public DataTable GetDanhSachDonVi()
        {
            return sanPham.GetDanhSachDonVi();
        }
    }
}
