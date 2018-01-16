using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class BaoCao
    {
        public DataTable GetAllBaoCao()
        {
            string cmd = @"select * from baocao";
            return Connection.getData(cmd);
        }

        public DataTable GetAllBaoCaoByLoaiBaoCao(string loaibaocao)
        {
            string cmd = @"select * from baocao where loaibaocao like N'%" + loaibaocao + "%'";
            return Connection.getData(cmd);

        }
        public int InsertBaoCao(int thangbaocao, int nambaocao, string loaibaocao)
        {
            string cmd = @"insert into baocao(thangbaocao,nambaocao,ngaylap,loaibaocao) values (" + thangbaocao + "," + nambaocao + ",convert(datetime,'" + DateTime.Now.Date.ToString(@"yyyy - MM - dd") + "'),N'" + loaibaocao + "')";
            int result = Connection.ExcuteNonQuery(cmd);
            return result;
        }
    }
}
