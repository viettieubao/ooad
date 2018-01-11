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
using QuanLiVatLieuXayDung.Controller;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapPhieuNhapHang : UserControl
    {
        public ucLapPhieuNhapHang()
        {
            InitializeComponent();
            sanPham = new SanPhamController();
            nhacungcap = new NhacungcapController();
            phieuNhap = new PhieuNhapController();

            DataTable dt;
            dt = sanPham.GetDanhSachDonVi();
            foreach (DataRow row in dt.Rows)
            {
                cbbDonVi.Items.Add(row[0]);

            }
            dt = nhacungcap.GetAllNhacungcap();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenNhaCC.Items.Add(row[1]);
            }

        }
        SanPhamController sanPham;
        NhacungcapController nhacungcap;
        PhieuNhapController phieuNhap;


        private void ucLapPhieuNhapHang_Load(object sender, EventArgs e)
        {
        }

        private void btnSuaSp_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { cbbTenSanPham.Text, txtSoluongNCC.Text, txtSoLuongThucNhap.Text, cbbDonVi.Text, txtGiaNhap.Text };
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Rows.Insert(index, row);
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Tên sản phẩm";
            dataGridView1.Columns[1].Name = "Số lượng theo nhà cung cấp";
            dataGridView1.Columns[2].Name = "Sô lượng thực nhập";
            dataGridView1.Columns[3].Name = "Đơn vị";
            dataGridView1.Columns[4].Name = "Giá nhập";
            if (cbbTenSanPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Lỗi");
            }
            else if (sanPham.GetSanPhamTheoTen(cbbTenSanPham.Text).Rows.Count == 0)
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Lỗi");
            }
            else if (txtGiaNhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được để trống", "Lỗi");
            }
            else if (txtSoluongNCC.Text == "")
            {
                MessageBox.Show("Số lượng theo nhà cung cấp không được để trông", "Lỗi");
            }
            else if (txtSoLuongThucNhap.Text == "")
            {
                MessageBox.Show("Số lượng thực nhập không được để trống", "Lỗi");
            }
            else
            if (int.TryParse(txtSoluongNCC.Text, out int tem) == false)
            {
                MessageBox.Show("Số lượng nhập nhà cung cấp phải là số nguyên ");
            }
            else if (int.TryParse(txtSoLuongThucNhap.Text, out int tem1))
            {
                MessageBox.Show("Số lượng nhập thực tế phải là số nguyên");
            }
            else
            if (long.TryParse(txtGiaNhap.Text, out long tem3))
            {
                MessageBox.Show("Giá nhập phải là số nguyên");
            }
            else
            {
                string[] row = new string[] { cbbTenSanPham.Text, txtSoluongNCC.Text, txtSoLuongThucNhap.Text, cbbDonVi.Text, txtGiaNhap.Text };
                dataGridView1.Rows.Add(row);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mancc = -1;
            try
            {
                mancc = int.Parse(nhacungcap.GetIDNCCTheoTen(cbbTenNhaCC.Text).Rows[0][0].ToString());
            }
            catch
            {
                MessageBox.Show("Nhà cung cấp không tồn tại", "Lỗi");
            }
            if (mancc != -1)
            {
                if (long.TryParse(txtSoDienThoai.Text, out long reult) == false || txtSoDienThoai.Text.Length < 10 || txtSoDienThoai.Text.Length > 12)
                {
                    MessageBox.Show("Số điện thoại phải từ 10 đến 11 chữ số");
                }
                else if (long.TryParse(txtThanhToan.Text, out long re) == false)
                {
                    MessageBox.Show("Số tiền đã thanh toán phải là số nguyên");
                }
                else if (long.TryParse(txtTongTien.Text, out long s) == false)
                {
                    MessageBox.Show("Tổng tiền hóa đơn phải là số nguyên");
                }
                else
                {
                    DataTable dt = new DataTable();
                    if (dataGridView1.Columns.Count > 0)
                    {
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            dt.Columns.Add(col.HeaderText);
                        }
                    }
                    if (dataGridView1.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            DataRow dr;
                            dr = dt.NewRow();
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                dr[i] = row.Cells[i].Value;
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    phieuNhap.InsertPhieuNhap(txtMaPhieuGiaoHang.Text, mancc, txtNguoiGiaoHang.Text, txtSoDienThoai.Text, long.Parse(txtTongTien.Text), long.Parse(txtThanhToan.Text), dtpNgayNhap.Value, dt);
                }

            }
        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = sanPham.GetDvTheoSanPham(cbbTenSanPham.Text);
            cbbDonVi.Items.Clear();
            cbbDonVi.Items.Add(dt.Rows[0][0].ToString());
            cbbDonVi.Items.Add(dt.Rows[0][1].ToString());
        }

        private void cbbTenNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            cbbTenSanPham.Items.Clear();
            dt = sanPham.GetSanPhamTheoNhaCungCap(int.Parse(nhacungcap.GetIDNCCTheoTen(cbbTenNhaCC.Text.ToString()).Rows[0][0].ToString()));
            foreach (DataRow row in dt.Rows)
            {
                cbbTenSanPham.Items.Add(row[0]);
            }
            dataGridView1.Rows.Clear();
        }
    }
}
