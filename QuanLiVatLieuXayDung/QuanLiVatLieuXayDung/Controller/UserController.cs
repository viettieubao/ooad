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
    }
}
