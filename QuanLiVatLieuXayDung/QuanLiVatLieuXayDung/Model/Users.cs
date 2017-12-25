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
        public string Bophan { get; set; }
        public bool IsActive { get; set; }
        public string Tennhanvien { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysing { get; set; }
        public string Sodienthoai { get; set; }

        public bool GetUserByUserName(string Username, string Pass)
        {
            string command = @"select * from User where username='" + Username + @"' and password='" + Pass + @"'";
            DataTable dt = Connection.getData(command);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
        public DataTable GetAllUser()
        {
            string command = @"select username, tennhanvien, ngaysinh, sodienthoai, diachi from User";
            return Connection.getData(command);
        }
    }
}
