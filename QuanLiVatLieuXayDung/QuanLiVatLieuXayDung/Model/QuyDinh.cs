using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class QuyDinh
    {
        public DataTable GetAllQuyDinh()
        {
            string cmd = @"select * from thamso";
            return Connection.getData(cmd);
        }

        public int Insert(string tenquydinh, string value)
        {
            //string cmd = @"select * from thamso";
            //return Connection.getData(cmd);
            return 0;
        }
    }
}
