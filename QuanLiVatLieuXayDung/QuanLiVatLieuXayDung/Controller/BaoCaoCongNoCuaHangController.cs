using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiVatLieuXayDung.Model;
using System.Data;

namespace QuanLiVatLieuXayDung.Controller
{
    class BaoCaoCongNoCuaHangController
    {
        BaoCaoCongNoCuaHang congno = new BaoCaoCongNoCuaHang();
        public int Insert(DataTable nhacungcap)
        {
            return congno.InsertChiTietBaoCao(nhacungcap);
        }
    }
}
