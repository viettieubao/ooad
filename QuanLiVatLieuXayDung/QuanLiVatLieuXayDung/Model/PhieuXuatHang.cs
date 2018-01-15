using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class PhieuXuatHang
    {
        public DataTable SearchTenKhachHang(string tenKhachHang)
        {
            string cmd = @"select maphieuxuat as [Mã phiếu xuất], ngayxuat as [Ngày xuất], hoadon.mahoadon as [Mã hoá đơn], tenkhachhang as[Tên khách hàng], diachi as [Địa chỉ], sodienthoai as [Số điện thoại], nguoigiaohang as [Người giao hàng] from khachhang, phieuxuat, hoadon where khachhang.makhachhang = hoadon.makhachhang and phieuxuat.mahoadon = hoadon.mahoadon and tenkhachhang like N'%" + tenKhachHang + "%'";
            return Connection.getData(cmd);
        }
        public DataTable SearchNgayLap(DateTime ngaylap)
        {
            string cmd = @"select maphieuxuat as [Mã phiếu xuất], ngayxuat as [Ngày xuất], hoadon.mahoadon as [Mã hoá đơn], tenkhachhang as[Tên khách hàng], diachi as [Địa chỉ], sodienthoai as [Số điện thoại], nguoigiaohang as [Người giao hàng] from khachhang, phieuxuat, hoadon where khachhang.makhachhang = hoadon.makhachhang and phieuxuat.mahoadon = hoadon.mahoadon and day(ngayxuat) = " + ngaylap.Date.Day + " and month(ngayxuat) = " + ngaylap.Date.Month + " and year(ngayxuat) = " + ngaylap.Date.Year;
            return Connection.getData(cmd);
        }
        public DataTable GetChiTietPhieuXuat(int maphieuxuat)
        {
            string cmd = @"select sanpham.masanpham as [Mã sản phẩm], tensanpham as [Tên sản phẩm], soluongxuat as [Số lượng xuất], tendonvitinh as [Đơn vị tính], giaban as [Giá bán], chitietphieuxuat.tongtien as [Thành tiền] from donvi, sanpham, chitietphieuxuat, phieuxuat where donvi.madonvitinh = chitietphieuxuat.madonvitinh and sanpham.masanpham = chitietphieuxuat.masanpham and chitietphieuxuat.maphieuxuat = phieuxuat.maphieuxuat and chitietphieuxuat.maphieuxuat = " + maphieuxuat;
            return Connection.getData(cmd);
        }

        public DataTable GetAllPhieuXuat()
        {
            string cmd = @"select maphieuxuat as [Mã phiếu xuất], ngayxuat as [Ngày xuất], hoadon.mahoadon as [Mã hoá đơn], tenkhachhang as[Tên khách hàng], diachi as [Địa chỉ], sodienthoai as [Số điện thoại], nguoigiaohang as [Người giao hàng] from khachhang, phieuxuat, hoadon where khachhang.makhachhang = hoadon.makhachhang and phieuxuat.mahoadon = hoadon.mahoadon";
            return Connection.getData(cmd);
        }
        public int InsertPhieuXuatHang(int mahoadon, long tongTien, string tenNguoiGiaoHang, DataTable sanpham, List<int> maSP, List<int> donViTinh)
        {
            string cmd = @"insert into phieuxuat(ngayxuat,mahoadon,tongtien,nguoigiaohang) values (convert(datetime,'" + DateTime.Now.Date.ToString(@"yyyy - MM - dd") + "')," + mahoadon + "," + tongTien + ",'" + tenNguoiGiaoHang + "')";
            int result = Connection.ExcuteNonQuery(cmd);
            if (result == 1)
            {
                string cmd1 = @"select max(maphieuxuat) from phieuxuat";
                int maphieuxuat = int.Parse(Connection.getData(cmd1).Rows[0][0].ToString());


                for (int i = 0; i < sanpham.Rows.Count; i++)
                {
                    string cmd2 = @"insert into chitietphieuxuat(maphieuxuat,masanpham,giaban,soluongxuat,tongtien, madonvitinh) values (" + maphieuxuat + "," + maSP[i] + "," + sanpham.Rows[i][2] + "," + sanpham.Rows[i][1] + "," + int.Parse(sanpham.Rows[i][2].ToString()) * int.Parse(sanpham.Rows[i][1].ToString()) +"," + donViTinh[i] + ")";
                    int tem = Connection.ExcuteNonQuery(cmd2);
                }
            }
            return result;
        }
    }
}
