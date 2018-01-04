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
    }
}
