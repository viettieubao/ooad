using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiVatLieuXayDung.Model
{
    class SanPham
    {
        public DataTable GetAllSanPham()
        {
            string cmd = @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm], (select TENNHACUNGCAP from NHACUNGCAP ncc where ncc.manhacungcap=sp.nhacungcap) as [Nhà cung cấp]  ,sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvi from DONVI dv where sp.DONVIBANSI= dv.MADONVI) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvi from DONVI dv where sp.DONVIBANLE=dv.MADONVI) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where ISACTIVE =1";
            return Connection.getData(cmd);
        }

        public int UpdateSanPham(int masanpham,string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle,string giabanle, string giabansi,int soluong,int soluongtontoithieu)
        {
            string cmd = @"update sanpham set tensanpham=N'"+tensanpham+"', soluongbansitoithieu="+ soluongbansitoithieu + ",donvibansi="+donvibansi+",donvibanle="+donvibanle+",giabanle="+giabanle+",giabansi="+giabansi+",soluong="+soluong+",soluongtontoithieu="+soluongtontoithieu;
            return Connection.ExcuteNonQuery(cmd);
        }

        public DataTable GetDanhSachDonVi()
        {
            string cmd = @"select tendonvi from Donvi";
            return Connection.getData(cmd);
        }
    }
}
