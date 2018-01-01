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
        public DateTime Ngaysinh { get; set; }
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

        public int AddUser(string username, string tennhanvien,DateTime ngaysinh, int bophan, string diachi,string sodienthoai)
        {
           
            string cmd = @"insert into NHANVIEN (USERNAME,TENNHANVIEN,NGAYSINH,BOPHAN,SODIENTHOAI,DIACHI) VALUES('" + username + "',N'" + tennhanvien + "',convert(datetime,'"+ ngaysinh.ToString(@"yyyy - MM - dd") +"',105)," + bophan + ",N'" + diachi + "','" + sodienthoai + @"')";    
            return Connection.ExcuteNonQuery(cmd); //=1 thành công =0 thất bại
        }
        public int UpdateUser(string tennhanvien,DateTime ngaysinh,int bophan,string diachi,string sodienthoai)
        {
            
            string cmd = "UPDATE NHANVIEN SET TENNHANVIEN='"+tennhanvien+"', NGAYSINH="+ngaysinh.ToString("yyyy-MM-dd") +", BOPHAN="+bophan+"DIACHI='"+diachi+"', SODIENTHOAI="+sodienthoai;
            return Connection.ExcuteNonQuery(cmd);
        }
    }
}
