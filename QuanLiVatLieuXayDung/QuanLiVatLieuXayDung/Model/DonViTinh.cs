using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class DonViTinh
    {
        public int Insert(string tendonvi)
        {
            string cmd = @"insert into donvi(tendonvitinh) values (N'" + tendonvi + "')";
            int result = Connection.ExcuteNonQuery(cmd);
            return result;
        }
        public DataTable GetAllDonViTinh()
        {
            string cmd = @"select tendonvitinh  as [Tên đơn vị tính] from donvi";
            return Connection.getData(cmd);
        }

        public DataTable GetAllDonViTinhWithTenDonVi(string tendonvi)
        {
            string cmd = @"select tendonvitinh as [Tên đơn vị tính] from donvi where tendonvitinh like N'%" + tendonvi + "%'";
            return Connection.getData(cmd);
        }
        //public int InsertBaoCaoTon(int masanpham, long tongTien, string tenNguoiGiaoHang, DataTable sanpham, List<int> maSP, List<int> donViTinh)
        //{
        //    string cmd = @"insert into baocao(thangbaocao,nambaocao,tongtien,nguoigiaohang) values (convert(datetime,'" + DateTime.Now.Date.ToString(@"yyyy - MM - dd") + "')," + mahoadon + "," + tongTien + ",'" + tenNguoiGiaoHang + "')";
        //    int result = Connection.ExcuteNonQuery(cmd);
        //    if (result == 1)
        //    {
        //        string cmd1 = @"select max(maphieuxuat) from phieuxuat";
        //        int maphieuxuat = int.Parse(Connection.getData(cmd1).Rows[0][0].ToString());


        //        for (int i = 0; i < sanpham.Rows.Count; i++)
        //        {
        //            string cmd2 = @"insert into chitietphieuxuat(maphieuxuat,masanpham,giaban,soluongxuat,tongtien, madonvitinh) values (" + maphieuxuat + "," + maSP[i] + "," + sanpham.Rows[i][2] + "," + sanpham.Rows[i][1] + "," + int.Parse(sanpham.Rows[i][2].ToString()) * int.Parse(sanpham.Rows[i][1].ToString()) + "," + donViTinh[i] + ")";
        //            int tem = Connection.ExcuteNonQuery(cmd2);
        //        }
        //    }
        //    return result;
        //}
    }
}
