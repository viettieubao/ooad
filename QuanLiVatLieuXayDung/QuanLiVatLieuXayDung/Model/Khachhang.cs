using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class Khachhang
    {
        public DataTable GetAllKhachhang()
        {
            string cmd = @"SELECT [MAKHACHHANG] as [STT]
      ,[TENKHACHHANG] as [Tên khách hàng]
	  ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [Số điện thoại]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] ";
            return Connection.getData(cmd);
        }
        public int UpdateKhachhang(int makhachhang, string tenkhachhang, string sodienthoai, string diachi, long congno)
        {
            string cmd = @"update khachhang set tenkhachhang=N'"+tenkhachhang+ "', sodienthoai='" + sodienthoai + "',diachi=N'" + diachi + "', congno = " + congno + " where makhachhang=" + makhachhang;
            return Connection.ExcuteNonQuery(cmd);
        }

        public int InsertKhachhang (string tenkhachhang, string sodienthoai, string diachi)
        {
            string cmd = @"insert into khachhang (tenkhachhang, sodienthoai, diachi, congno) values (N'" + tenkhachhang + "','" + sodienthoai + "',N'" + diachi + "',  0)";
            return Connection.ExcuteNonQuery(cmd);
        }


        public DataTable SearchTheoMakhachhang(int makhachhang)
        {
            string cmd = @"SELECT [MAKHACHHANG] as [STT]
      ,[TENKHACHHANG] as [Tên khách hàng]
	  ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [Số điện thoại]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] where MAKHACHHANG =" + makhachhang ;
            return Connection.getData(cmd);
        }
        public DataTable SearchTheoTenkhachhang(string tenkhachhang)
        {
            string cmd = @"SELECT [MAKHACHHANG] as [STT]
      ,[TENKHACHHANG] as [Tên khách hàng]
	  ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [Số điện thoại]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] where TENKHACHHANG = N'" + tenkhachhang + @"'";
            return Connection.getData(cmd);
        }
    }
}
