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

    }
}
