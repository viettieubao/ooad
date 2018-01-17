using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class HoaDon
    {
        public DataTable GetAllHoaDon()
        {
            string cmd = @"select mahoadon as [Mã hoá đơn], tenkhachhang as [Tên khách hàng], ngaylap as [Ngày lập], diachi as [Địa chỉ], sodienthoai as [Số điện thoại] from hoadon, khachhang where hoadon.makhachhang = khachhang.makhachhang order by mahoadon asc";
            return Connection.getData(cmd);
        }

        public int InsertHoaDon(int makhachang, long tongtien, long thuevat, DateTime ngaylap, DataTable sanpham)
        {
            string cmd = @"insert into hoadon(makhachhang,ngaylap,tongtien,thuevat) values (" + makhachang + ",convert(datetime, '" + ngaylap.ToString(@"yyyy - MM - dd ") + "')," + tongtien + "," + thuevat + ")";
            int result = Connection.ExcuteNonQuery(cmd);
            int mahoadon = -1;
            if (result == 1)
            {
                string cmd1 = @"select max(mahoadon) from hoadon ";
                mahoadon = int.Parse(Connection.getData(cmd1).Rows[0][0].ToString());

                foreach (DataRow row in sanpham.Rows)
                {
                    string cmd2 = @"insert into chitiethoadon (mahoadon,masanpham,soluongsanpham,madonvitinh,thanhtien) values (" + mahoadon + "," + row[0] + "," + row[4] + ",(select madonvitinh from donvi dv where dv.tendonvitinh=N'" + row[2] + "')," + row[5] + ")";
                    int tem = Connection.ExcuteNonQuery(cmd2);
                }
            }
            return mahoadon;
        }


        public DataTable GetHoaDonWithMaDonHang(int maDonHang)
        {
            string cmd = @"select mahoadon as [Mã hoá đơn], tenkhachhang as [Tên khách hàng], ngaylap as [Ngày lập], diachi as [Địa chỉ], sodienthoai as [Số điện thoại] from hoadon, khachhang where hoadon.makhachhang = khachhang.makhachhang and mahoadon = " + maDonHang;
            return Connection.getData(cmd);
        }
        public DataTable GetHoaDonWithMaKhachHang(int makhachhang)
        {
            string cmd = @"select mahoadon as [Mã hoá đơn], tenkhachhang as [Tên khách hàng], ngaylap as [Ngày lập], diachi as [Địa chỉ], sodienthoai as [Số điện thoại] from hoadon, khachhang where hoadon.makhachhang = khachhang.makhachhang and khachhang.makhachhang = " + makhachhang;
            return Connection.getData(cmd);
        }
        public DataTable GetHoaDonWithNgayLap(DateTime ngaylap)
        {
            string cmd = @"select mahoadon as [Mã hoá đơn], tenkhachhang as [Tên khách hàng], ngaylap as [Ngày lập], diachi as [Địa chỉ], sodienthoai as [Số điện thoại] from hoadon, khachhang where hoadon.makhachhang = khachhang.makhachhang and day(ngaylap) = " + ngaylap.Date.Day + " and month(ngaylap) = " + ngaylap.Date.Month + " and year(ngaylap) = " + ngaylap.Date.Year;
            return Connection.getData(cmd);
        }
        public DataTable GetHoaDonWithTenKhachHang(string tenKhachHang)
        {
            string cmd = @"select mahoadon as [Mã hoá đơn], tenkhachhang as [Tên khách hàng], ngaylap as [Ngày lập], diachi as [Địa chỉ], sodienthoai as [Số điện thoại] from hoadon, khachhang where hoadon.makhachhang = khachhang.makhachhang and khachhang.tenkhachhang like N'%" + tenKhachHang + "%'";
            return Connection.getData(cmd);
        }

        public DataTable GetChiTietHoaDon_Show(int maDonHang)
        {
            string cmd = @" select masanpham as [Mã sản phẩm], (select sp.TENSANPHAM from SANPHAM sp where sp.MASANPHAM=cthd.MASANPHAM) as [Tên sản phẩm],
 CTHD.SOLUONGSANPHAM as [Số lượng], 
 (SELECT dv.tendonvitinh from donvi dv where dv.MADONVITINH =cthd.MADONVITINH) as  [Đơn vị tính],
 cthd.THANHTIEN as [Thành tiền],
 (cthd.THANHTIEN/cthd.SOLUONGSANPHAM) as [Giá bán]
 from CHITIETHOADON cthd where cthd.MAHOADON= " + maDonHang;
            return Connection.getData(cmd);
        }

        public int UpdateSoLuongDaXuat(int maHoaDon, DataTable sanPham, List<int> maSP)
        {
            for (int i = 0; i < sanPham.Rows.Count; i++)
            {
                string cmd = @"update chitiethoadon set soluongsanphamdaxuat = soluongsanphamdaxuat + " + sanPham.Rows[i][1] + " where mahoadon =  " + maHoaDon + " and masanpham = " + maSP[i];
                Connection.ExcuteNonQuery(cmd);
            }

            return 0;
        }
        public DataTable GetChiTietHoaDon(int maDonHang)
        {
            string cmd = @"select chitiethoadon.masanpham, tensanpham, madonvitinhbansi, giabansi, giabanle, madonvitinhbanle, chitiethoadon.madonvitinh, tendonvitinh, soluongsanpham, soluongsanphamdaxuat from chitiethoadon, sanpham, donvi where sanpham.masanpham = chitiethoadon.masanpham and donvi.madonvitinh = chitiethoadon.madonvitinh and mahoadon = " + maDonHang;
            return Connection.getData(cmd);
        }
    }
}
