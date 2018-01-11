using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class NhacungcapController
    {
        Nhacungcap nhacungcap = new Nhacungcap();
        public DataTable GetAllNhacungcap()
        {
            return nhacungcap.GetAllNhacungcap();
        }
        public DataTable GetAllSpncc(int manhacungcap)
        {
            return nhacungcap.GetAllSpncc(manhacungcap);
        }

        public int UpdateNhacungcap(int manhacungcap, string tennhacungcap, string diachi, string sodienthoai, string email, string masothue, long congno)
        {
            return nhacungcap.UpdateNhacungcap(manhacungcap, tennhacungcap, diachi, sodienthoai, email, masothue, congno);
        }

        public int InsertNhacungcap(string tennhacungcap, string diachi, string sodienthoai, string email, string masothue, long congno)
        {
            return nhacungcap.InsertNhacungcap(tennhacungcap, diachi, sodienthoai, email, masothue, congno);
        }

        public int DeleteNhacungcap(int manhacungcap)
        {
            return nhacungcap.DeleteNhacungcap(manhacungcap);
        }
        public DataTable SearchTheoMancc(int manhacungcap)
        {
            return nhacungcap.SearchTheoMancc(manhacungcap);
        }
  
        public DataTable SearchTheoTenncc(string tennhacungcap)
        {
            return nhacungcap.SearchTheoTenncc(tennhacungcap);
        }
        public DataTable GetIDNCCTheoTen(string tenncc)
        {
            return nhacungcap.GetIDNCCTheoTen(tenncc);
        }
    }
            
}
