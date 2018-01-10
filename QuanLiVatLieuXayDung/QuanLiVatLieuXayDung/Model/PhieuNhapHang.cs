﻿using System;
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
        public int Update(int maphieunhap,string nguoigiaohang, string sodienthoai,long tongtien,long sotiendathanhtoan,DateTime ngaynhap)
        {
            string cmd = @"UPDATE PHIEUNHAP SET NGUOIGIAOHANG=N'" + nguoigiaohang + "',sodienthoai=" + sodienthoai + ",tongtien=" + tongtien+ ",sotiendathanhtoan=" + sotiendathanhtoan + ",ngaynhap=convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "',105)";
            return Connection.ExcuteNonQuery(cmd);
        }

        public int Insert(int nhacungcap, string nguoigiaohang, string sodienthoai, long tongtien,long sotiendathanhtoan, DateTime ngaynhap,DataTable danhsachsanpham)
        {
            //them phiếu nhập vào bảng phiếu nhập
            string cmd = @"insert into phieunhap (ngaynhap,manhacungcap,tongtienhoadon,sotiendathanhtoan,nguoigiaohang) values (ngaynhap=convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "',105)," + nhacungcap + ","+tongtien+","+sotiendathanhtoan+",N'"+nguoigiaohang+"')";


            int result = Connection.ExcuteNonQuery(cmd);

            //get mã phiếu nhập vừa thêm
            string cmd1 = @"select maphieunhap from phieunhap where nhacungcap=" + nhacungcap + ",tongtienhoadon=" + tongtien + ",sotiendathanhtoan=" + sotiendathanhtoan + ",ngaynhap=convert(datetime,'" + ngaynhap.ToString(@"yyyy - MM - dd") + "',105),nguoigiaohang=N'" + nguoigiaohang + "'" ;

            DataTable dt = Connection.getData(cmd1);
            int maphieunhap = int.Parse(dt.Rows[0][0].ToString());

            //thêm danh sách sản phẩm của phiếu nhập vào bảng chi tiết
            foreach (DataRow row in danhsachsanpham.Rows)
            {
                string cmd2 = @"insert into table chitietphieunhap(maphieunhap,masanpham,gianhap,soluongnhaptheochungtu,soluongnhapthucte,donvitinh) values (" + maphieunhap + "," + row[0] + "," + row[1] + "," + row[3] + "," + row[4] + ")";
                Connection.ExcuteNonQuery(cmd2);
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
