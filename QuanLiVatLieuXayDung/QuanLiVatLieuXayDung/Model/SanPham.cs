﻿using System;
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
            string cmd = @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where ISACTIVE =1 ";
            return Connection.getData(cmd);
        }

        public int UpdateSanPham(int masanpham,string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle,long giabanle, long giabansi,int soluong,int soluongtontoithieu)
        {
            string cmd = @"update sanpham set tensanpham=N'"+tensanpham+"', soluongbansitoithieu="+ soluongbansitoithieu + ",madonvitinhbansi="+donvibansi+",madonvitinhbanle="+donvibanle+",giabanle="+giabanle+",giabansi="+giabansi+",soluong="+soluong+",soluongtontoithieu="+soluongtontoithieu +"where masanpham="+masanpham;
            return Connection.ExcuteNonQuery(cmd);
        }

        public DataTable GetDanhSachDonVi()
        {
            string cmd = @"select tendonvitinh from Donvi";
            return Connection.getData(cmd);
        }

        public int InsertSanPham(string tensanpham, int soluongbansitoithieu, int donvibansi, int donvibanle, long giabanle, long giabansi, int soluong, int soluongtontoithieu)
        {

            string cmd = @"insert into sanpham (tensanpham,soluongbansitoithieu,madonvitinhbansi,madonvitinhbanle,giabansi,giabanle,soluong,soluongtontoithieu) values (N'"+ tensanpham+"',"+soluongbansitoithieu+","+donvibansi+","+donvibanle+","+giabansi+","+giabanle+","+soluong+","+soluongtontoithieu+")";
            return Connection.ExcuteNonQuery(cmd);
        }

        public int DeleteSanPham(int masanpham)
        {
            string cmd = @"update sanpham set isactive =0 where masanpham= "+masanpham;
            return Connection.ExcuteNonQuery(cmd);
        }

        public DataTable SearchTheoTenSanPham(string tensanpham)
        {
            string cmd = @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where  ISACTIVE =1 and tensanpham like N'%" + tensanpham + @"%'";
            return Connection.getData(cmd);
        }

        public DataTable SearchTheoGiaSanPham(long from,long to, int flat) // flat =1 ban  si, = 2 ban lẻ
        {
            string cmd;
            if (flat==1) cmd= @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where sp.giabansi between "+from+" and "+to + " and ISACTIVE =1";
            else cmd = @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where sp.giabanle between " + from + " and " + to + " and ISACTIVE =1";
            return Connection.getData(cmd);
        }

        public DataTable SearchTheoTenVaGia(string tensanpham,long from,long to, int flat) // flat =1 ban  si, = 0 ban lẻ
        {
            string cmd;
            if (flat == 1)
            {
                cmd= @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where (sp.giabansi between " + from + " and " + to+ ") and (sp.tensanpham like N'%" + tensanpham + @"%') and ISACTIVE = 1";
            }
            else
            {
                cmd= @"select sp.MASANPHAM as [STT], sp.TENSANPHAM as [Tên sản phẩm],
sp.SOLUONGBANSITOITHIEU as [Số lượng bán sỉ tối thiểu], 
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANSI= dv.MADONVITINH) as [Đơn vị bán sỉ],
sp.GIABANSI as [Giá bán sỉ],
(select tendonvitinh from DONVI dv where sp.MADONVITINHBANLE=dv.MADONVITINH) as [Đơn vị bán lẻ],
sp.GIABANLE as [Giá bán lẻ], soluong as [Số lượng tồn], soluongtontoithieu as [Số lượng tồn tối thiểu]
from SANPHAM sp where (sp.giabanle between " + from + " and " + to + ") and (sp.tensanpham like N'%" + tensanpham + @"%') and ISACTIVE =1";
            }
            return Connection.getData(cmd);
        }
        public DataTable GetDvTheoSanPham(string tensanpham)
        {
            string cmd = @"select (select tendonvitinh from donvi dv where dv.madonviTINH=sp.madonvitinhbanle) as donvibanle
            ,(select tendonvitinh from donvi dv where dv.madonviTINH=sp.madonvitinhbansi) as donvibansi from sanpham sp where tensanpham=N'"+tensanpham+"'";
            return Connection.getData(cmd);
        }
        public DataTable GetSanPhamTheoTen(string tensanpham)
        {
            string cmd = @"select masanpham,giabansi,giabanle, (select tendonvitinh from donvi dv where dv.madonvitinh= sp.madonvitinhbansi), (select tendonvitinh from donvi dv where dv.madonvitinh= sp.madonvitinhbanle), soluongbansitoithieu from sanpham sp where tensanpham=N'" + tensanpham+"'";
            return Connection.getData(cmd);
        }
        public int UpdateNhaCC(int manhacungcap, string tensanpham)
        {
            string cmd = @"update sanpham set manhacungcap="+manhacungcap +"where tensanpham=N'"+tensanpham+"'";
            return Connection.ExcuteNonQuery(cmd);
        }
        public DataTable GetSanPhamTheoNhaCungCap(int nhacungcap)
        {
            string cmd = @"select tensanpham from sanpham where manhacungcap=" + nhacungcap;
            return Connection.getData(cmd);
        }

    }
}
