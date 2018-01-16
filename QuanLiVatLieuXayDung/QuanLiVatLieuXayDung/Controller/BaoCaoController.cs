using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class BaoCaoController
    {
        BaoCao baocao = new BaoCao();
        BaoCaoCongNoCuaHang cuahang = new BaoCaoCongNoCuaHang();
        BaoCaoCongNoKhachHang khachhang = new BaoCaoCongNoKhachHang();
        BaoCaoTon ton = new BaoCaoTon();
        BaoCaoDoanhThu doanhthu = new BaoCaoDoanhThu();

        public DataTable GetAllBaoCao()
        {
            return baocao.GetAllBaoCao();
        }

        public DataTable GetBaoCaoTon(int masp, int thangbaocao, int nambaocao)
        {
            return ton.GetChiTietBaoCaoTon(masp, thangbaocao, nambaocao);
        }

        public int InsertBaoCaoDoanhThu(int thangbaocao, int nambaocao, DataTable danhsach)
        {
            baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo doanh thu");
            return 0;
        }

        public int InsertBaoCaoTon(int thangbaocao, int nambaocao, DataTable danhsach)
        {
            baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo tồn");
            ton.Insert(danhsach);
            //DataTable 
            return 0;
        }

        public int InsertBaoCaoCongNoKhachHang(int thangbaocao, int nambaocao, DataTable danhsach)
        {
            baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo công nợ khách hàng");
            return 0;
        }

        public int InsertBaoCaoCongNoCuaHang(int thangbaocao, int nambaocao, DataTable danhsach)
        {
            baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo công nợ cửa hàng");
            return 0;
        }
    }
}
