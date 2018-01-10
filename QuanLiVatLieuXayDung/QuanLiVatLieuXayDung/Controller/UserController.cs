using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiVatLieuXayDung.Model;
using System.Data;

namespace QuanLiVatLieuXayDung.Controller
{

    class UserController
    {
        Users users = new Users();
        public int rule { get; set; }
        public bool GetUserByUserName(string user, string pass)
        {

            bool result = users.GetUserByUserName(user, pass);
            if (result == false) return false;
            rule = users.Bophan;
            return true;
        }
        public int AddUser(string username, string tennhanvien, DateTime ngaysinh, string bophan, string diachi, string sodienthoai)
        {
            int result = users.AddUser(username, tennhanvien, ngaysinh, bophan, diachi, sodienthoai);
            return result;
        }

        public int UpdateUser(string username, string tennhanvien, DateTime ngaysinh, string bophan, string diachi, string sodienthoai)
        {
            int result = users.UpdateUser(username,tennhanvien, ngaysinh, bophan, diachi, sodienthoai);
            return result;
        }
        public DataTable GetAll()
        {
            return users.GetAllUser();
        }

        public DataTable Search(string tennhanvien, string bophan)
        {
            return users.Search(tennhanvien,bophan);
        }

        public int Disable(string username)
        {
            return users.Disable(username);
        }
        public int Enable(string username)
        {
            return users.Enable(username);
        }
    }
}