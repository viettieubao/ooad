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
            string cmd = @"select thangbaocao as [Tháng báo cáo], nambaocao as [Năm báo cáo], ngaylap as [Ngày lập], mabaocao as [Mã báo cáo], loaibaocao as [Loại báo cáo] from baocao";
            return Connection.getData(cmd);
        }

        public DataTable GetAllNamBaoCao()
        {
            string cmd = @"select distinct nambaocao from baocao";
            return Connection.getData(cmd);
        }

        public DataTable GetAllBaoCaoByLoaiBaoCao(string loaibaocao)
        {
            string cmd = @"select * from baocao where loaibaocao like N'%" + loaibaocao + "%'";
            return Connection.getData(cmd);

        }

        public DataTable SearchBaoCao(string loaibaocao, int thang, int nam)
        {
            DateTime ngaydauthang = new DateTime(nam, thang, 1);
            DateTime ngaycuoithang = new DateTime(nam, thang, DateTime.DaysInMonth(nam, thang));
            string cmd = @"select thangbaocao as [Tháng báo cáo], nambaocao as [Năm báo cáo], ngaylap as [Ngày lập], mabaocao as [Mã báo cáo], loaibaocao as [Loại báo cáo] from baocao where thangbaocao = " + thang + " and nambaocao = " + nam + " and loaibaocao = N'" + loaibaocao + "'";
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
