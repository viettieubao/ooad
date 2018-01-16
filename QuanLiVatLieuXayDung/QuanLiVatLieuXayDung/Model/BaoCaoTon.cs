using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using QuanLiVatLieuXayDung.Model;

namespace QuanLiVatLieuXayDung.Model
{
    class BaoCaoTon
    {
        public DataTable GetChiTietBaoCaoTon(int masp, int thangbaocao, int nambaocao)
        {
            DateTime ngaydauthang = new DateTime(nambaocao, thangbaocao, 1);
            DateTime ngaycuoithang = new DateTime(nambaocao, thangbaocao, DateTime.DaysInMonth(nambaocao, thangbaocao));
            DateTime today = DateTime.Now;


            string cmd = @"select sp.masanpham as [Mã sản phẩm]," +
                "sp.tensanpham as [Tên sản phẩm]," +
                "tennhacungcap as [Nhà cung cấp]," +
                "(sp.soluong - " + GetSoLuongNhap(masp, ngaydauthang, today) + "+" + GetSoLuongXuat(masp, ngaydauthang, today) + ") as [Số lượng tồn đầu tháng], " +
                "(sp.soluong - " + GetSoLuongNhap(masp, ngaycuoithang, today) + "+" + GetSoLuongXuat(masp, ngaycuoithang, today) + ") as [Số lượng tồn cuối tháng], " +
                "(" + GetSoLuongNhap(masp, ngaydauthang, ngaycuoithang) + ") as [Số lượng nhập trong tháng], " +
                "(" + GetSoLuongXuat(masp, ngaydauthang, ngaycuoithang) + ")  as [Số lượng xuất trong tháng]" +
                "From sanpham sp, nhacungcap where sp.manhacungcap = nhacungcap.manhacungcap and sp.masanpham = " + masp;

            return Connection.getData(cmd);
        }

        public int Insert(DataTable danhsach)
        {
            string cmd1 = @"select max(mabaocao) from baocao";
            int mabaocao = int.Parse(Connection.getData(cmd1).Rows[0][0].ToString());


            for (int i = 0; i < danhsach.Rows.Count; i++)
            {
                string cmd2 = @"insert into baocaoton(mabaocao,masanpham,soluongtondauthang,soluongtoncuoithang,soluongnhaptrongthang, soluongbanratrongthang) values (" + mabaocao + "," + int.Parse(danhsach.Rows[i][0].ToString()) + "," + int.Parse(danhsach.Rows[i][3].ToString()) + "," + int.Parse(danhsach.Rows[i][4].ToString()) + "," + int.Parse(danhsach.Rows[i][5].ToString()) + "," + int.Parse(danhsach.Rows[i][6].ToString()) + ")";
                int tem = Connection.ExcuteNonQuery(cmd2);
                if (tem != 1)
                {
                    return tem;
                }
            }
            return 1;
        }

        private int GetSoLuongNhap(int masp, DateTime from, DateTime to)
        {
            string cmd = @"select sum(soluongnhapthucte) from chitietphieunhap, phieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and ngaynhap between convert(datetime, '" + from.ToString("yyyy-MM-dd") + "') and convert(datetime, '" + to.ToString("yyyy-MM-dd") + "') and chitietphieunhap.masanpham = " + masp;
            DataTable tempt = Connection.getData(cmd);
            if (tempt.Rows[0][0].ToString() != "")
            {
                return (int)tempt.Rows[0][0];
            }
            return 0;
        }

        private int GetSoLuongXuat(int masp, DateTime from, DateTime to)
        {
            string cmd = @"select sum(soluongxuat) from chitietphieuxuat, phieuxuat where phieuxuat.maphieuxuat = chitietphieuxuat.maphieuxuat and ngayxuat between convert(datetime, '" + from.ToString("yyyy-MM-dd") + "') and convert(datetime,'" + to.ToString("yyyy-MM-dd") + "') and chitietphieuxuat.masanpham = " + masp;
            DataTable tempt = Connection.getData(cmd);
            if (tempt.Rows[0][0].ToString() != "")
            {
                return (int)tempt.Rows[0][0];
            }
            return 0;
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
