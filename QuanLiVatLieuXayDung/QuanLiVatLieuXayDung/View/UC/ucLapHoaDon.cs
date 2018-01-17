using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraPrinting.Preview;
using QuanLiVatLieuXayDung.Controller;
using QuanLiVatLieuXayDung.View;


namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapHoaDon : UserControl
    {
        public ucLapHoaDon()
        {
            InitializeComponent();
            sanPham = new SanPhamController();
            khachhang = new KhachhangController();
            hoaDon = new HoaDonController();
        }

        SanPhamController sanPham;
        KhachhangController khachhang;
        HoaDonController hoaDon;
        private void ucQlsanpham_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {

            DataTable dt = sanPham.GetAllSanPham();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenSanPham.Items.Add(row[1]);
            }
            dt = khachhang.GetAllKhachhang();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenKhachHang.Items.Add(row[1]);
            }
        }
        long tongtiensanpham = 0;
        long thuevat = 0;
        long tongtienhoadon = 0;
        long tinhtongtiensanpham()
        {
            foreach (DataGridViewRow row in dtpData.Rows)
            {
                tongtienhoadon += int.Parse(row.Cells[3].FormattedValue.ToString()) * long.Parse(row.Cells[4].FormattedValue.ToString());
            }
            return tongtienhoadon;
        }

        private void btnThemMoiSP_Click_1(object sender, EventArgs e)
        {

            if (cbbDonVi.SelectedIndex == 0) //kiểm tra chọn giá bán sỉ hay bán lẻ
            {
                if (cbbTenSanPham.Text != "") // kiểm tra đã nhập tên sản phẩm hay chọn sản phẩm hay chưa
                {
                    if (txtSoLuong.Text != "")// kiểm tra số lượng đã nhập hay chưa
                    {
                        if (cbbDonVi.Text != "") // kiểm tra chọn bán theo bán sỉ hay bán lẻ
                        {
                            if (int.Parse(txtSoLuong.Text) >= int.Parse(txtSoLuongBanSiTT.Text)) // kiểm tra số lượng bán có lớn hơn số lượng bán sỉ tối thiểu hay không
                            {
                                
                                string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                                string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
                                dtpData.Rows.Add(row);
                                tongtiensanpham += tinhtongtiensanpham();
                                thuevat = tongtiensanpham / 10;
                                tongtienhoadon = tongtiensanpham + thuevat;
                                txtTongTien.Text = tongtienhoadon.ToString();
                                txtThueVAT.Text = thuevat.ToString();

                            }
                            else
                            {
                                MessageBox.Show("Số lượng mua phải lớn hơn số lượng bán sỉ tôi thiểu", "Lưu ý");
                            }
                        } else
                        {
                            MessageBox.Show("Bạn chưa chọn đơn vị", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                    }
                }else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm", "Lỗi");
                }
            }
            else
            {
                if (cbbTenSanPham.Text != "")
                {
                    if (txtSoLuong.Text != "")
                    {
                        if (cbbDonVi.Text != "")
                        {
                            
                            string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                            string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };

                            dtpData.Rows.Add(row);

                            tongtiensanpham += tinhtongtiensanpham();
                            thuevat = tongtiensanpham / 10;
                            tongtienhoadon = tongtiensanpham + thuevat;
                            txtThueVAT.Text = thuevat.ToString();
                            txtTongTien.Text = tongtienhoadon.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn đơn vị");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Lỗi");
                    }
                }else
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm","Lỗi");
                }
            }


        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbDonVi.SelectedIndex == 0) //kiểm tra chọn giá bán sỉ hay bán lẻ
            {
                if (cbbTenSanPham.Text != "") // kiểm tra đã nhập tên sản phẩm hay chọn sản phẩm hay chưa
                {
                    if (txtSoLuong.Text != "")// kiểm tra số lượng đã nhập hay chưa
                    {
                        if (cbbDonVi.Text != "") // kiểm tra chọn bán theo bán sỉ hay bán lẻ
                        {
                            if (int.Parse(txtSoLuong.Text) >= int.Parse(txtSoLuongBanSiTT.Text)) // kiểm tra số lượng bán có lớn hơn số lượng bán sỉ tối thiểu hay không
                            {

                                string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                                string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
                                int index = dtpData.CurrentRow.Index;
                                dtpData.Rows.RemoveAt(index);
                                dtpData.Rows.Insert(index, row);
                                tongtiensanpham += tinhtongtiensanpham();
                                thuevat = tongtiensanpham / 10;
                                tongtienhoadon = tongtiensanpham + thuevat;
                                txtTongTien.Text = tongtienhoadon.ToString();
                                txtThueVAT.Text = thuevat.ToString();

                            }
                            else
                            {
                                MessageBox.Show("Số lượng mua phải lớn hơn số lượng bán sỉ tôi thiểu", "Lưu ý");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn đơn vị", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm", "Lỗi");
                }
            }
            else
            {
                if (cbbTenSanPham.Text != "")
                {
                    if (txtSoLuong.Text != "")
                    {
                        if (cbbDonVi.Text != "")
                        {

                            string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                            string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
                            int index = dtpData.CurrentRow.Index;
                            dtpData.Rows.RemoveAt(index);
                            dtpData.Rows.Insert(index, row);
                            tongtiensanpham += tinhtongtiensanpham();
                            thuevat = tongtiensanpham / 10;
                            tongtienhoadon = tongtiensanpham + thuevat;
                            txtTongTien.Text = tongtienhoadon.ToString();
                            txtThueVAT.Text = thuevat.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn đơn vị");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Lỗi");
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtpData.Rows.RemoveAt(dtpData.CurrentRow.Index);
        }

        
        private void btnLap_Click(object sender, EventArgs e)
        {

            int makhachhang = 0;
            if (tongtienhoadon > 1000000)
            {//trường hợp hóa đơn khách hàng lớn hơn 10 triệu
                if (cbbTenKhachHang.Text != "")
                {
                    if (dtpData.Rows.Count > 0)
                    {
                        makhachhang = int.Parse(khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][0].ToString());
                        DataTable datatable = new DataTable();
                        if (dtpData.Columns.Count > 0)
                        {
                            foreach (DataGridViewColumn col in dtpData.Columns)
                            {
                                datatable.Columns.Add(col.Name);
                            }
                        }
                        if (dtpData.Rows.Count > 0)
                        {

                            foreach (DataGridViewRow row in dtpData.Rows)
                            {
                                DataRow dr;
                                dr = datatable.NewRow();

                                for (int i = 0; i < row.Cells.Count; i++)
                                {
                                    dr[i] = row.Cells[i].Value;
                                }
                                datatable.Rows.Add(dr);
                            }

                        }

                        int mahoadon=hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
                        frmView frmView = new frmView();
                        frmView.LapHoaDon(cbbTenKhachHang.Text,khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][2].ToString(),mahoadon, khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][3].ToString(),convertFromNumberToString(tongtienhoadon));
                        frmView.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn sản phẩm nào");
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng lớn hơn 10tr cần nhập thông tin khách hàng", "Lưu ý");
                }
            }
            else
            { 
                if (cbbTenKhachHang.Text != "")
                {   //trường hợp khách hàng muốn vận chuyển tận nơi
                    if (khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows.Count > 0)
                    {
                        if (dtpData.Rows.Count > 0)
                        {
                            makhachhang = int.Parse(khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][0].ToString());
                            DataTable datatable = new DataTable();
                            if (dtpData.Columns.Count > 0)
                            {
                                foreach (DataGridViewColumn col in dtpData.Columns)
                                {
                                    datatable.Columns.Add(col.Name);
                                }
                            }
                            if (dtpData.Rows.Count > 0)
                            {

                                foreach (DataGridViewRow row in dtpData.Rows)
                                {
                                    DataRow dr;
                                    dr = datatable.NewRow();

                                    for (int i = 0; i < row.Cells.Count; i++)
                                    {
                                        dr[i] = row.Cells[i].Value;
                                    }
                                    datatable.Rows.Add(dr);
                                }

                            }

                            int mahoadon = hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
                            frmView frmView = new frmView();
                            frmView.LapHoaDon(cbbTenKhachHang.Text, khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][2].ToString(), mahoadon, khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][3].ToString(), convertFromNumberToString(tongtienhoadon));
                            frmView.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn sản phẩm nào");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại.", "Lỗi!");
                    }
                }
                else
                {// trường hợp khách hàng nhập hàng tại chỗ
                    makhachhang = -1;
                    if (dtpData.Rows.Count > 0)
                    {
                        DataTable datatable = new DataTable();
                        if (dtpData.Columns.Count > 0)
                        {
                            foreach (DataGridViewColumn col in dtpData.Columns)
                            {
                                datatable.Columns.Add(col.Name);
                            }
                        }
                        if (dtpData.Rows.Count > 0)
                        {

                            foreach (DataGridViewRow row in dtpData.Rows)
                            {
                                DataRow dr;
                                dr = datatable.NewRow();

                                for (int i = 0; i < row.Cells.Count; i++)
                                {
                                    dr[i] = row.Cells[i].Value;
                                }
                                datatable.Rows.Add(dr);
                            }

                        }

                        int mahoadon = hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
                        //xuat hoa don
                        frmView frmView = new frmView();
                        frmView.LapHoaDon(cbbTenKhachHang.Text, khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][2].ToString(), mahoadon, khachhang.SearchTheoTenkhachhang(cbbTenKhachHang.Text).Rows[0][3].ToString(), convertFromNumberToString(tongtienhoadon));
                        frmView.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn sản phẩm nào");
                    }
                }
            }
        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDonVi.Items.Clear();
            cbbDonVi.Text = "";
            if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows.Count != 0)
            {
                string masanpham = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][0].ToString();
                txtMaSP.Text = masanpham;
                txtSoLuongBanSiTT.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][5].ToString();

                if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3].ToString() != sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][4].ToString())
                {
                    cbbDonVi.Items.Add(sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3]);
                    cbbDonVi.Items.Add( sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][4]);
                }
                else
                {
                    cbbDonVi.Items.Add(sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3]);
                }
                lblDVbansi.Text = "Đơn vị: "+sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("San phẩm không tồn tại","Lỗi");
            }
        }

        private void cbbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonVi.Text== sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3].ToString())
            {
                txtGiaBan.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][1].ToString();
            }
            else
            {
                txtGiaBan.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][2].ToString();
            }
        }

        
        private void dtpData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGiaBan.Text = dtpData.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtMaSP.Text = dtpData.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtSoLuong.Text = dtpData.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtSoLuongBanSiTT.Text = sanPham.GetSanPhamTheoTen(dtpData.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()).Rows[0][5].ToString();
            cbbDonVi.Text = dtpData.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            cbbTenSanPham.Text = dtpData.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            lblDVbansi.Text="Đơn vị: "+dtpData.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

        }

        static String convertFromNumberToString(long a_number)
        {
            String result = "";
            long number = a_number;
            int mod;
            int k = 0;
            while (number > 0)
            {
                mod = (int)number % 1000;
                number = (number / 1000);
                String tempt = convertFromThreeDigitNumberToString(mod, number != 0);

                if (number!=0)
                switch (k)
                {
                    case 1:
                        tempt += " nghin";
                        break;
                    case 2:
                        tempt += " trieu";
                        break;
                    case 3:
                        tempt += " ty";
                        break;
                    case 4:
                        tempt += " nghin ty";
                        break;
                    default:
                        break;
                }
                k++;
                result = tempt + " " + result;
            }

            return result;

        }

        static String convertFromThreeDigitNumberToString(int a_number, bool before = true)
        {
            int number = a_number;
            String result = "";
            bool remove = true;
            int k = 0;
            int[] array = { 0, 0, 0 };
            while (number > 0)
            {
                array[k] = number % 10;
                number = number / 10;
                k++;
            }

            if (array[2] != 0 || (array[2] == 0 && before && (array[1] != 0 || array[0] != 0)))
            {
                result += convertFromDigitToString(array[2]) + " tram ";
            }

            if ((array[2] != 0 || (array[2] == 0 && before)) && array[1] == 0 && array[0] != 0)
            {
                result += "le ";
            }

            if (array[1] != 0)
            {
                if (array[1] != 1)
                {
                    result += convertFromDigitToString(array[1]) + " muoi ";
                }
                else
                {
                    result += "muoi ";
                }
            }

            if (array[0] != 0)
            {
                if (array[0] != 5)
                {
                    result += convertFromDigitToString(array[0]);
                }
                else
                {
                    result += "lam";
                }
            }

            return result;
        }

        static String convertFromDigitToString(int number)
        {
            String result = "";
            switch (number)
            {
                case 1:
                    result = "mot";
                    break;
                case 2:
                    result = "hai";
                    break;
                case 3:
                    result = "ba";
                    break;
                case 4:
                    result = "bon";
                    break;
                case 6:
                    result = "sau";
                    break;
                case 7:
                    result = "bay";
                    break;
                case 8:
                    result = "tam";
                    break;
                case 9:
                    result = "chin";
                    break;
                case 0:
                    result = "khong";
                    break;
                default:
                    result = "nam";
                    break;
            }
            return result;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmThemKhachHang = new frmThemKhachHang();
            frmThemKhachHang.ShowDialog();
            load();
        }
    }

}
