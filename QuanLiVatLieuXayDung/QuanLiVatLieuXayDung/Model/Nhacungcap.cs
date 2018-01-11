using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class Nhacungcap
    {
        public DataTable GetAllNhacungcap()
        {
            string cmd = @"SELECT [MANHACUNGCAP] as [Mã nhà cung cấp]
      ,[TENNHACUNGCAP] as [Tên nhà cung cấp]
      ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [SĐT]
      ,[EMAIL] as [Email]
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
  FROM [OOAD].[dbo].[NHACUNGCAP] where isactive =1";
            return Connection.getData(cmd);
        }
        public DataTable GetAllSpncc(int manhacungcap)
        {
            string cmd = @"SELECT
       [MASANPHAM] as [Mã sản phẩm]
      , tensanpham as [Tên sản phẩm]
      ,(select tendonvitinh from donvi dv where dv.madonvitinh=sp.madonvitinhbansi) as [Đơn vị tính]
  FROM SANPHAM sp where MANHACUNGCAP =" + manhacungcap;
            return Connection.getData(cmd);
        }
        public int UpdateNhacungcap(int manhacungcap, string tennhacungcap, string diachi, string sodienthoai, string email, string masothue, long congno)
        {
            string cmd = @"update nhacungcap set tennhacungcap=N'" + tennhacungcap + "', diachi=N'"+diachi+"', sodienthoai=N'" + sodienthoai + "', email=N'" + email + "', masothue=N'"+masothue+"', congno = "+congno+" where manhacungcap=" + manhacungcap;
            return Connection.ExcuteNonQuery(cmd);
        }

        public int InsertNhacungcap (string tennhacungcap, string diachi, string sodienthoai, string email, string masothue, long congno)
        {
            string cmd = @"insert into nhacungcap (tennhacungcap, diachi, sodienthoai, email, masothue, congno) values (N'" + tennhacungcap + "',N'" + diachi + "', N'" + sodienthoai + "',N'" + email + "',N'" + masothue + "', " + congno + ")";
            return Connection.ExcuteNonQuery(cmd);
        }

        public int DeleteNhacungcap (int manhacungcap)
        {
            string cmd = @"update nhacungcap set isactive =0 where manhacungcap = " + manhacungcap;
            return Connection.ExcuteNonQuery(cmd);
        }
        public DataTable SearchTheoMancc(int manhacungcap)
        {
            string cmd = @"SELECT [MANHACUNGCAP] as [STT]
      ,[TENNHACUNGCAP] as [Tên nhà cung cấp]
      ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [SĐT]
      ,[EMAIL] as [Email]
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
      FROM [OOAD].[dbo].[NHACUNGCAP] where MANHACUNGCAP like '" + manhacungcap + @"%' and ISACTIVE=1";
            return Connection.getData(cmd);
        }
        public DataTable SearchTheoTenncc(string tennhacungcap)
        {
            string cmd = @"SELECT [MANHACUNGCAP] as [STT]
      ,[TENNHACUNGCAP] as [Tên nhà cung cấp]
      ,[DIACHI] as [Địa chỉ]
      ,[SODIENTHOAI] as [SĐT]
      ,[EMAIL] as [Email]
      ,[MASOTHUE] as [Mã số thuế]
      ,[CONGNO] as [Công nợ]
      FROM [OOAD].[dbo].[NHACUNGCAP] where TENNHACUNGCAP like N'%" + tennhacungcap + @"%' and ISACTIVE=1";
            return Connection.getData(cmd);
        }
        //public int InsertSpncc(string tensanpham, string diachi, string sodienthoai, string email, string masothue, long congno)
        //{
        //    string cmd = @"insert into nhacungcap (te, diachi, sodienthoai, email, masothue, congno) values (N'" + tennhacungcap + "',N'" + diachi + "', N'" + sodienthoai + "',N'" + email + "',N'" + masothue + "', " + congno + ")";
        //    return Connection.ExcuteNonQuery(cmd);
        //}        
        public DataTable GetIDNCCTheoTen(string tenncc)
        {
            string cmd = @"select manhacungcap from nhacungcap where tennhacungcap= N'"+tenncc+"'";
            return Connection.getData(cmd);
        }
    }
}
