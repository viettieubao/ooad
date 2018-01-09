﻿using System;
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
        public DataTable GetAllPhieuNhap()
        {
            return phieuNhap.GetAllPhieuNhap();
        }
        public int InsertPhieuNhap(int nhacungcap, string nguoigiaohang, string sodienthoai, long tongtien, long sotiendathanhtoan, DateTime ngaynhap,DataTable danhsachsanpham)
        {
            return phieuNhap.Insert(nhacungcap, nguoigiaohang, sodienthoai, tongtien,  sotiendathanhtoan, ngaynhap,danhsachsanpham);
        }
        public int Update(int maphieunhap, string nguoigiaohang, string sodienthoai, long tongtien,  long sotiendathanhtoan, DateTime ngaynhap)
        {
            return phieuNhap.Update(maphieunhap, nguoigiaohang, sodienthoai, tongtien,  sotiendathanhtoan, ngaynhap);
        }

        public DataTable Search(string nhacungcap, long tongtien, DateTime ngaynhap, int flat)
        {
            return phieuNhap.Search(nhacungcap, tongtien, ngaynhap, flat);
        }
        public DataTable GetAllNhaCC()
        {
            return phieuNhap.GetAllNhaCC();
        }
    }
}