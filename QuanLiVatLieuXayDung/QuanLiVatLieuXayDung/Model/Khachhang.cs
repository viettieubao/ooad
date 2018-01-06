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
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] where ISACTIVE =1";
            return Connection.getData(cmd);
        }
        public int UpdateKhachhang(int makhachhang, string tenkhachhang, string sodienthoai, string diachi, string masothue, long congno)
        {
            string cmd = @"update khachhang set tenkhachhang=N'"+tenkhachhang+ "', sodienthoai='" + sodienthoai + "',diachi=N'" + diachi + "', masothue='" + masothue + "', congno = " + congno + " where makhachhang=" + makhachhang;
            return Connection.ExcuteNonQuery(cmd);
        }

        public int InsertKhachhang (string tenkhachhang, string sodienthoai, string diachi, string masothue, long congno)
        {
            string cmd = @"insert into khachhang (tenkhachhang, sodienthoai, diachi, masothue, congno) values (N'" + tenkhachhang + "','" + sodienthoai + "',N'" + diachi + "', '" + masothue + "',  " + congno + ")";
            return Connection.ExcuteNonQuery(cmd);
        }

        public int DeleteKhachhang (int makhachhang)
        {
            string cmd = @"update khachhang set isactive =0 where makhachhang = " + makhachhang;
            return Connection.ExcuteNonQuery(cmd);
        }

        public DataTable SearchTheoMakhachhang(int makhachhang)
        {
            string cmd = @"SELECT [MAKHACHHANG] as [STT]
      ,[TENKHACHHANG] as [Tên khách hàng]
	  ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [Số điện thoại]
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] where MAKHACHHANG =" + makhachhang + @" and ISACTIVE=1";
            return Connection.getData(cmd);
        }
        public DataTable SearchTheoTenkhachhang(string tenkhachhang)
        {
            string cmd = @"SELECT [MAKHACHHANG] as [STT]
      ,[TENKHACHHANG] as [Tên khách hàng]
	  ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [Số điện thoại]
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
        FROM[OOAD].[dbo].[KHACHHANG] where TENKHACHHANG like '" + tenkhachhang + @"%' and ISACTIVE=1";
            return Connection.getData(cmd);
        }
    }
}
