using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Bophan { get; set; }
        public bool IsActive { get; set; }
        public string Tennhanvien { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysing { get; set; }
        public string Sodienthoai { get; set; }

        public bool GetUserByUserName(string Username, string Pass)
        {
            string command = @"select * from Nhanvien where username='" + Username + @"' and password='" + Pass + @"'";
            DataTable dt = Connection.getData(command);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Bophan = int.Parse(row["BOPHAN"].ToString());
                }
                return true;
            }
            return false;
        }
        public DataTable GetAllUser()
        {
            string command = @"select * from nhanvien";
            return Connection.getData(command);
        }
    }
}
