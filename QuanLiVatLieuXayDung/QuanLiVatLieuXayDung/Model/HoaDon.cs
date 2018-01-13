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
            string cmd = @"";
            return Connection.getData(cmd);
        }
        public DataTable GetChiTietHoaDon(int mahoadon)
        {
            string cmd = @"";
            return Connection.getData(cmd);
        }
        public int InsertHoaDon(int makhachang,long tongtien, long thuevat, DateTime ngaylap,DataTable sanpham)
        {
            string cmd = @"insert into hoadon(makhachhang,ngaynhap,tongtien,thuevat) values ("+makhachang+",convert(datetime, '"+ ngaylap.ToString(@"yyyy - MM - dd") +"', 105),"+tongtien+","+thuevat+")";
            int result = Connection.ExcuteNonQuery(cmd);
            if (result == 1)
            {
                string cmd1 = @"select mahoadon from hoadon where makhachhang="+makhachang+ "and ngaynhap=convert(datetime, '" + ngaylap.ToString(@"yyyy - MM - dd") + "', 105) and tongtien="+tongtien+"and thuevat="+thuevat;
                int mahoadon = int.Parse(Connection.getData(cmd).Rows[0][0].ToString());

                foreach (DataRow row in sanpham.Rows)
                {
                    string cmd2 = @"insert into chitiethoadon (mahoadon,masanpham,soluongsanpham,madonvitinh,thanhtien) values ("+mahoadon+","+row[0]+","+row[4]+",(select madonvitinh from donvi dv where dv.tendonvitinh='"+row[2]+"',"+row[5]+")";
                    int tem = Connection.ExcuteNonQuery(cmd2);
                }
            }
            return result;
        }
    }
}
