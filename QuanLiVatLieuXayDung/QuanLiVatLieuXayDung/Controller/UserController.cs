using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    
    class UserController
    {
        Users users=new Users();
        public int rule { get; set; }
        public bool GetUserByUserName(string user,string pass)
        {
            
            bool result = users.GetUserByUserName(user, pass);
            if (result == false) return false;
            rule = users.Bophan;
            return true;
        }
        public int AddUser(string username, string tennhanvien, DateTime ngaysinh, int bophan, string diachi, string sodienthoai)
        {
            int result = users.AddUser(username,tennhanvien,ngaysinh,bophan,diachi,sodienthoai);
            return result;
        }

        public int UpdateUser(string tennhanvien, DateTime ngaysinh, int bophan, string diachi, string sodienthoai)
        {
            int result = users.UpdateUser(tennhanvien, ngaysinh, bophan, diachi, sodienthoai);
            return result;
        }
    }
}
