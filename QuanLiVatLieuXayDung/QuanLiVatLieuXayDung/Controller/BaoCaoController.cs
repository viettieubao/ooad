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

        public DataTable GetAllNamBaoCao()
        {
            return baocao.GetAllNamBaoCao();
        }

        public DataTable GetBaoCaoTon(int masp, int thangbaocao, int nambaocao)
        {
            return ton.GetChiTietBaoCaoTon(masp, thangbaocao, nambaocao);
        }

        public int InsertBaoCaoDoanhThu(int thangbaocao, int nambaocao, int sohoadon, long sotiendoanhthu)
        {
            int result = 0;
            if (baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo doanh thu") != 0)
            {
                doanhthu.Insert(sohoadon, sotiendoanhthu);
            }
            return 0;
        }

        public int InsertBaoCaoTon(int thangbaocao, int nambaocao, DataTable danhsach)
        {
            int result = 0;
            if (baocao.InsertBaoCao(thangbaocao, nambaocao, "Báo cáo tồn") != 0)
            {
                result = ton.Insert(danhsach);
            }
            //DataTable 
            return result;
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

        public DataTable SearchBaoCao(string loaibaocao, int thang, int nam)
        {
            return baocao.SearchBaoCao(loaibaocao, thang, nam);
        }
    }
}
