using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;
namespace QuanLiVatLieuXayDung.Controller
{
    class KhachhangController
    {
        Khachhang khachhang = new Khachhang();
        public DataTable GetAllKhachhang()
        {
            return khachhang.GetAllKhachhang();
        }
        public int UpdateKhachhang(int makhachhang, string tenkhachhang, string sodienthoai, string diachi, string masothue, long congno)
        {
            return khachhang.UpdateKhachhang(makhachhang, tenkhachhang, sodienthoai, diachi, masothue, congno);
        }
        public int InsertKhachhang(string tenkhachhang, string sodienthoai, string diachi, string masothue, long congno)
        {
            return khachhang.InsertKhachhang(tenkhachhang, sodienthoai, diachi, masothue, congno);
        }
        public int DeleteKhachhang(int makhachhang)
        {
            return khachhang.DeleteKhachhang(makhachhang);
        }
        public DataTable SearchTheoMakhachhang(int makhachhang)
        {
            return khachhang.SearchTheoMakhachhang(makhachhang);
        }
        public DataTable SearchTheoTenkhachhang(string tenkhachhang)
        {
            return khachhang.SearchTheoTenkhachhang(tenkhachhang);
        }
    }
}
