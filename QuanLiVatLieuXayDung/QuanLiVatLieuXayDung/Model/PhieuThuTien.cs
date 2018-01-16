using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class PhieuThuTien
    {
        public DataTable GetAllPhieuThuTien()
        {
            string cmd = @"select maphieuthutien as [Mã phiếu thu tiền], tenkhachhang as [Tên khách hàng], phieuthutien.mahoadon as [Mã hoá đơn], phieuthutien.ngaylap as [Ngày lập], lydothutien as [Lý do thu tiền], sotiendathu as [Số tiền đã thu] from phieuthutien, hoadon, khachhang where phieuthutien.mahoadon = hoadon.mahoadon and hoadon.makhachhang = khachhang.makhachhang";
            return Connection.getData(cmd);
        }

        public int InsertPhieuThuTien(int mahoadon, string lydothutien, long sotiendathu)
        {
            int result = 0;
            string cmd = @"insert into phieuthutien(mahoadon, ngaylap, lydothutien, sotiendathu) values (" + mahoadon + "," + DateTime.Now.Date.ToString(@"yyyy - MM - dd") + ",'" + lydothutien + "'," + sotiendathu + ")";
            return Connection.ExcuteNonQuery(cmd);
        }

        public DataTable SearchMaPhieuThuTien(int maphieuthutien)
        {
            string cmd = @"select maphieuthutien as [Mã phiếu thu tiền], tenkhachhang as [Tên khách hàng], phieuthutien.mahoadon as [Mã hoá đơn], phieuthutien.ngaylap as [Ngày lập], lydothutien as [Lý do thu tiền], sotiendathu as [Số tiền đã thu] from phieuthutien, hoadon, khachhang where phieuthutien.mahoadon = hoadon.mahoadon and hoadon.makhachhang = khachhang.makhachhang and maphieuthutien = " + maphieuthutien;
            return Connection.getData(cmd);
        }

        public DataTable SearchNgayLap(DateTime ngaylap)
        {
            string cmd = @"select maphieuthutien as [Mã phiếu thu tiền], tenkhachhang as [Tên khách hàng], phieuthutien.mahoadon as [Mã hoá đơn], phieuthutien.ngaylap as [Ngày lập], lydothutien as [Lý do thu tiền], sotiendathu as [Số tiền đã thu] from phieuthutien, hoadon, khachhang where phieuthutien.mahoadon = hoadon.mahoadon and hoadon.makhachhang = khachhang.makhachhang and year(ngaylap) = " + ngaylap.Year + " and month(ngaylap) = " + ngaylap.Month + " and day(ngaylap) = " + ngaylap.Day;
            return Connection.getData(cmd);
        }

        public DataTable SearchTenKhachHang(string tenkhachhang)
        {
            string cmd = @"select maphieuthutien as [Mã phiếu thu tiền], tenkhachhang as [Tên khách hàng], phieuthutien.mahoadon as [Mã hoá đơn], phieuthutien.ngaylap as [Ngày lập], lydothutien as [Lý do thu tiền], sotiendathu as [Số tiền đã thu] from phieuthutien,khachhang, hoadon where phieuthutien.mahoadon = hoadon.mahoadon and hoadon.makhachhang = khachhang.makhachhang and tenkhachhang like N'%" + tenkhachhang + "%'";
            return Connection.getData(cmd);
        }
    }
}
