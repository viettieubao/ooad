using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class PhieuNhapHang
    {
        public DataTable GetAllPhieuNhap()
        {
            string cmd = @"SELECT  [MAPHIEUNHAP] as [STT]
        ,[NGAYNHAP] as [Ngày nhập]
        ,(select tennhacungcap from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Nhà cung cấp]
        ,(select sodienthoai from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Số điện thoại]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM PHIEUNHAP pn";
            return Connection.getData(cmd);
        }

        public DataTable GetAllPhieuNhapByNhaCungCap(string nhacungcap)
        {
            string cmd = @"SELECT  [MAPHIEUNHAP] as [Mã phiếu nhập]
        ,[MAPHIEUGIAOHANG] AS [Mã phiếu giao hàng nhà cung cấp]
        ,[NGAYNHAP] as [Ngày nhập]
        ,[tennhacungcap] as [Nhà cung cấp]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM phieunhap, nhacungcap where phieunhap.manhacungcap = nhacungcap.manhacungcap and tennhacungcap like N'%" + nhacungcap + "%'";
            return Connection.getData(cmd);
        }

        public DataTable GetAllPhieuNhapByNgayNhap(DateTime ngaylap)
        {
            string cmd = @"SELECT  [MAPHIEUNHAP] as [Mã phiếu nhập]
        ,[MAPHIEUGIAOHANG] AS [Mã phiếu giao hàng nhà cung cấp]
        ,[NGAYNHAP] as [Ngày nhập]
        ,(select tennhacungcap from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Nhà cung cấp]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM PHIEUNHAP pn where day(ngaynhap) = " + ngaylap.Date.Day + " and month(ngaynhap) = " + ngaylap.Date.Month + " and year(ngaynhap) = " + ngaylap.Date.Year;
            return Connection.getData(cmd);
        }

        public DataTable GetChiTietPhieuNhap(int maphieunhap)
        {
            string cmd = @"SELECT maphieunhap as [Mã phiếu nhập], tensanpham as [Tên sản phẩm], gianhap as [Giá nhập], soluongnhaptheochungtu as [Số lượng nhập theo chứng từ], soluongnhapthucte as [Số lượng nhập theo thực tế], tendonvitinh as [Đơn vị tính], (soluongnhaptheochungtu * gianhap) as [Thành tiền] from chitietphieunhap, donvi, sanpham where sanpham.masanpham = chitietphieunhap.masanpham and donvi.madonvitinh = chitietphieunhap.madonvitinh and maphieunhap = " + maphieunhap;
            return Connection.getData(cmd);
        }

        public int Update(int maphieunhap,string nguoigiaohang, string sodienthoai,long tongtien,long sotiendathanhtoan,DateTime ngaynhap)
        {
            string cmd = @"UPDATE PHIEUNHAP SET NGUOIGIAOHANG=N'" + nguoigiaohang + "',sodienthoai=" + sodienthoai + ",tongtien=" + tongtien+ ",sotiendathanhtoan=" + sotiendathanhtoan + ",ngaynhap=convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "')";
            return Connection.ExcuteNonQuery(cmd);
        }

        public int Insert(string maphieugiaohang,int nhacungcap, string nguoigiaohang, string sodienthoai, long tongtien,long sotiendathanhtoan, DateTime ngaynhap,DataTable danhsachsanpham)
        {
            //them phiếu nhập vào bảng phiếu nhập
            string cmd = @"insert into phieunhap (maphieugiaohang,ngaynhap,manhacungcap,tongtienhoadon,sotiendathanhtoan,nguoigiaohang) values ('"+maphieugiaohang+"',convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "')," + nhacungcap + ","+tongtien+","+sotiendathanhtoan+",N'"+nguoigiaohang+"')";


            int result = Connection.ExcuteNonQuery(cmd);

            if (result == 1)
            //get mã phiếu nhập vừa thêm
            {
                string cmd1 = @"select max(maphieunhap) from phieunhap";

                DataTable dt = Connection.getData(cmd1);
                int maphieunhap = int.Parse(dt.Rows[0][0].ToString());

                //thêm danh sách sản phẩm của phiếu nhập vào bảng chi tiết
                foreach (DataRow row in danhsachsanpham.Rows)
                {
                    string cmd2 = @"insert into chitietphieunhap(maphieunhap,masanpham,gianhap,soluongnhaptheochungtu,soluongnhapthucte,madonvitinh) values (" + maphieunhap + ",(select masanpham from sanpham where tensanpham=N'" + row[0] + "')," + row[4] +","+row[1]+ "," + row[2] + ",(select madonvitinh from donvi where tendonvitinh=N'" + row[3] +"'))";
                   int tem = Connection.ExcuteNonQuery(cmd2);

                    //update lai so luong trong kho
                    string cmd3 = @"update sanpham set soluong= ((select soluong from sanpham where tensanpham=N'"+row[0]+"')+"+row[2]+") where tensanpham=N'"+row[0];
                    int tem2 = Connection.ExcuteNonQuery(cmd3);
                }
            }
            return result;
        }
        public DataTable Search(string nhacungcap,long tongtien, DateTime ngaynhap, int flat) //flat =1 tìm theo tên =2 tìm theo tổng tiền =3 tìm theo ngày nhập
        {
            string cmd;
            if (flat == 1)
                cmd = @"SELECT  [MAPHIEUNHAP] as [STT]
        ,[NGAYNHAP] as [Ngày nhập]
        ,(select tennhacungcap from nhacungcap cc where pn.manhacungcap=cc.manhacungcap) as [Nhà cung cấp]
        ,(select sodienthoai from nhacungcap cc where pn.manhacungcap=cc.manhacungcap) as [Số điện thoại]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM PHIEUNHAP pn join nhacungcap ncc on pn.manhacungcap=ncc.manhacungcap where tennhacungcap like N'%"+nhacungcap+"'";
            else
            {
                if (flat == 2)
                    cmd = @"SELECT  [MAPHIEUNHAP] as [STT]
        ,[NGAYNHAP] as [Ngày nhập]
        ,(select tennhacungcap from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Nhà cung cấp]
        ,(select sodienthoai from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Số điện thoại]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM PHIEUNHAP pn where tongtienhoadon="+tongtien;
                else
                {
                    cmd = @"SELECT  [MAPHIEUNHAP] as [STT]
        ,[NGAYNHAP] as [Ngày nhập]
        ,(select tennhacungcap from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Nhà cung cấp]
        ,(select sodienthoai from nhacungcap ncc where pn.manhacungcap=ncc.manhacungcap) as [Số điện thoại]
        ,[NGUOIGIAOHANG] as [Người giao hàng]
        ,[TONGTIENHOADON] as [Tổng tiền hóa đơn]
        ,[SOTIENDATHANHTOAN] as [Số tiền đã thanh toán]
        FROM PHIEUNHAP pn where ngaynhap= convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "',105)";
                }
            }
            return Connection.getData(cmd);
        }

        public DataTable GetAllNhaCC()
        {
            string cmd = @"select tennhacungcap from nhacungcap";
            return Connection.getData(cmd);
        }

        //public int InsertDanhSachSanPhamNhap(DataTable dt)
        //{
        //    int result = 0;
        //    string cmd;

        //    return result;
        //} 
    }
}
