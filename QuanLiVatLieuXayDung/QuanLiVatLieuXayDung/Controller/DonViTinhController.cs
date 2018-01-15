using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Controller
{
    class DonViTinhController
    {
        DonViTinh donvi = new DonViTinh();
        public int Insert(string tendonvi)
        {
            return donvi.Insert(tendonvi);
        }

        public DataTable GetAllDonViTinh()
        {
            return donvi.GetAllDonViTinh();
        }

        public DataTable GetAllDonViTinhWithTenDonVi(string tendonvi)
        {
            return donvi.GetAllDonViTinhWithTenDonVi(tendonvi);
        }
    }
}
