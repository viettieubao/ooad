using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace QuanLiVatLieuXayDung.Model
{
    class BaoCaoDoanhThu
    {
        public DataTable GetAllDoanhthu()
        {
            string cmd = @"	Select sp.MASANPHAM, sp.TENSANPHAM, sum(SOLUONGSANPHAM) as [Số Lượng], sum(THANHTIEN) as [Thành Tiền]
	        From [OOAD].[dbo].[SANPHAM] sp, [OOAD].[dbo].[CHITIETHOADON] c, [OOAD].[dbo].[HOADON] hd
            Where sp.MASANPHAM=c.MASANPHAM and hd.MAHOADON=c.MaHOADON and 
			Group by sp.MASANPHAM, sp.TENSANPHAM";
            return Connection.getData(cmd);
        }
        public DataTable TongHoaDon()
        {
            string cmd = @" Select count(MAHOADON) From [OOAD].[dbo].[HOADON]";
            return Connection.getData(cmd);
        }
        public DataTable GetAllBaoCaoCuaHang(int thangbaocao, int nambaocao)
        {
            DateTime ngaydauthang = new DateTime(nambaocao, thangbaocao, 1);
            DateTime ngaycuoithang = new DateTime(nambaocao, thangbaocao, DateTime.DaysInMonth(nambaocao, thangbaocao));
            DateTime today = DateTime.Now;


            string cmd = @"select tensanpham as [Sản phẩm]," +
                "tennhacungcap as [Tên nhà cung cấp]," +
                "(soluong + select sum(soluongnhapthucte) from chitietphieunhap, phieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + today + "') as [Số lượng tồn đầu tháng], " +
                "(soluong + select sum(soluongnhapthucte) from chitietphieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaycuoithang + "' and '" + today + "') as [Số lượng tồn cuối tháng], " +
                "(select sum(soluongnhapthucte) from chitietphieunhap, phieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + ngaycuoithang + "') as [Số lượng nhập trong tháng], " +
                "(select sum(soluongxuat) from chitietphieuxuat, phieuxuat where phieuxuat.maphieuxuat = chitietphieuxuat.maphieuxuat and chitietphieuxuat.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + ngaycuoithang + "') as [Số lượng xuất trong tháng], " +
                "From sanpham, nhacungcap where sanpham.manhacungcap = nhacungcap.manhacungcap";

            return Connection.getData(cmd);
        }
    }
}
