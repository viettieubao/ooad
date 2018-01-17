using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLiVatLieuXayDung.Model
{
    class ThamSo
    {
        public int getGiatriThamSobyName(string name)
        {
            string cmd = @"select giatri from bangthamso where thamso=N'"+name+"'";
            return int.Parse(Connection.getData(cmd).Rows[0][0].ToString());
        }
        public DataTable getAllThamSo()
        {
            string cmd = @"select thamso as [Tên Quy định], giatri as [Giá trị quy định] from bangthamso";
            return Connection.getData(cmd);
        }
        public int getGiatriThamSobyID(int name)
        {
            string cmd = @"select giatri from bangthamso where mathamso=" + name;
            return int.Parse(Connection.getData(cmd).Rows[0][0].ToString());
        }
        public int UpdateThamSo(string tenquydinh, int giatri)
        {
            string cmd = @"update bangthamso set giatri=" + giatri + "where thamso=N'" + tenquydinh + "'";
            return Connection.ExcuteNonQuery(cmd);
        }
        public int InsertThamso(string tenquydinh,int giatri)
        {
            string cmd = "insert into bangthamso (thamso,giatri) values (N'"+tenquydinh+"',"+giatri+")";
            return Connection.ExcuteNonQuery(cmd);
        }
        public DataTable SearchThamSoTheoTen(string tenquydinh)
        {
            string cmd = "select thamso as [Tên Quy định], giatri as [Giá trị quy định] from bangthamso where thamso=N'"+tenquydinh+"'";
            return Connection.getData(cmd);
        }
    }
}
