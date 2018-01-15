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

        long tongtien = 0;
        long thuevat = 0;
        long tongtienhoadon = 0;

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
                                tongtien += long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text);
                                thuevat = tongtien / 10;
                                tongtienhoadon = tongtien + thuevat;
                                string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                                string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
                                dtpData.Rows.Add(row);
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
                            tongtien += long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text);
                            thuevat = tongtien / 10;
                            tongtienhoadon = tongtien + thuevat;
                            string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                            string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };

                            dtpData.Rows.Add(row);
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
                if (int.Parse(txtSoLuong.Text) >= int.Parse(txtSoLuongBanSiTT.Text))
                {
                    
                    tongtien += long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text);
                    thuevat = tongtien / 10;
                    tongtienhoadon = tongtien + thuevat;
                    string thanhtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text)).ToString();
                    string[] row = new string[] { txtMaSP.Text, cbbTenSanPham.Text, cbbDonVi.Text, txtGiaBan.Text, txtSoLuong.Text, thanhtien };
                    dtpData.Rows.Add(row);
                    txtTongTien.Text = tongtienhoadon.ToString();
                    txtThueVAT.Text = thuevat.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng mua phải lớn hơn số lượng bán sỉ tôi thiểu", "Lưu ý");
                }
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtpData.Rows.RemoveAt(dtpData.CurrentRow.Index);
        }

        
        private void btnLap_Click(object sender, EventArgs e)
        {

            DocumentViewer documentViewer = new DocumentViewer();
           // documentViewer.PrintingSystem.PrintingDocument;
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
                        hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
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
                            hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
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
                        hoaDon.InsertHoaDon(makhachhang, tongtienhoadon, thuevat, dtpNgayLap.Value, datatable);
                    }else
                    {
                        MessageBox.Show("Bạn chưa chọn sản phẩm nào");
                    }
                }
            }
        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDonVi.Items.Clear();
            if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows.Count != 0)
            {
                string masanpham = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][0].ToString();
                txtMaSP.Text = masanpham;
                txtSoLuongBanSiTT.Text = sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][5].ToString();

                if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3].ToString() != sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][4].ToString())
                {
                    cbbDonVi.Items.Add("Bán sỉ: " + sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3]);
                    cbbDonVi.Items.Add("Bán lẻ: " + sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][4]);
                }
                else
                {
                    cbbDonVi.Items.Add("Bán sỉ và bán lẻ: " + sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows[0][3]);
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


        long thanhtientemp = 0;
        
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
    }
}
