using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class ThamSoController
    {
        ThamSo thamSo = new ThamSo();
        public int getGiatriThamSobyName(string name)
        {
            return thamSo.getGiatriThamSobyName(name);
        }
        public DataTable getAllThamSo()
        {
            return thamSo.getAllThamSo();
        }
        public int getGiatriThamSobyID(int name)
        {
            return thamSo.getGiatriThamSobyID(name);
        }
        public int UpdateThamSo(string tenquydinh, int giatri)
        {
            return thamSo.UpdateThamSo(tenquydinh, giatri);
        }
        public int InsertThamso(string tenquydinh, int giatri)
        {
            return thamSo.InsertThamso(tenquydinh, giatri);
        }
        public DataTable SearchThamSoTheoTen(string tenquydinh)
        {
            return thamSo.SearchThamSoTheoTen(tenquydinh);
        }
    }
}
