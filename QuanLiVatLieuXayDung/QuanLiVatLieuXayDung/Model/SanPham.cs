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
            string cmd = @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm], sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvi from DONVI dv where sp.DONVIBANSI= dv.MADONVI) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvi from DONVI dv where sp.DONVIBANLE=dv.MADONVI) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng hiện có]
from SANPHAM sp where ISACTIVE =1";
            return Connection.getData(cmd);
        }

    }
}
