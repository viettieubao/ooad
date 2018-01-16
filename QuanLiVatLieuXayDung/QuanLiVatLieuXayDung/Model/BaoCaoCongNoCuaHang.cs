using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class BaoCaoCongNoCuaHang
    {
        public DataTable GetAllBaoCaoCuaHang(int thangbaocao, int nambaocao)
        {
            DateTime ngaydauthang = new DateTime(nambaocao, thangbaocao, 1);
            DateTime ngaycuoithang = new DateTime(nambaocao, thangbaocao, DateTime.DaysInMonth(nambaocao, thangbaocao));
            DateTime today = DateTime.Now;


            string cmd = @"select tensanpham," +
                "tennhacungcap," +
                "(soluong + select sum(soluongnhapthucte) from chitietphieunhap, phieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + today + "'), " +
                "(soluong + select sum(soluongnhapthucte) from chitietphieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaycuoithang + "' and '" + today + "'), " +
                "(select sum(soluongnhapthucte) from chitietphieunhap, phieunhap where phieunhap.maphieunhap = chitietphieunhap.maphieunhap and chitietphieunhap.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + ngaycuoithang + "'), " +
                "(select sum(soluongxuat) from chitietphieuxuat, phieuxuat where phieuxuat.maphieuxuat = chitietphieuxuat.maphieuxuat and chitietphieuxuat.masanpham = sanpham.masanpham and ngaylap between '" + ngaydauthang + "' and '" + ngaycuoithang + "'), " +
                "From sanpham, nhacungcap where sanpham.manhacungcap = nhacungcap.manhacungcap";

            return Connection.getData(cmd);
        }
        public int InsertChiTietBaoCao(DataTable nhacungcap)
        {
            string cmd1 = @"select max(mabaocao) from baocao";
            int mabaocao = -1; 
            mabaocao = int.Parse(Connection.getData(cmd1).Rows[0][0].ToString());

            if (mabaocao != -1)
            {
                for (int i = 0; i < nhacungcap.Rows.Count; i++)
                {
                    string cmd2 = @"insert into baocaocongnocuahang(mabaocao,manhacungcap,sotienno) values (" + mabaocao + "," + nhacungcap.Rows[i][1] + "," + nhacungcap.Rows[i][2] + ")";
                    int tem = Connection.ExcuteNonQuery(cmd2);
                }
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
