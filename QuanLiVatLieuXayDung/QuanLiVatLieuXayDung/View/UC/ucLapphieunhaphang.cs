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

        }
        SanPhamController sanPham;
        NhacungcapController nhacungcap;


        private void ucLapPhieuNhapHang_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = sanPham.GetAllSanPham();
            foreach (DataRow row in dt.Rows)
            {
                cbbTenSanPham.Items.Add(row[1]);
            }
            dt = sanPham.GetDanhSachDonVi();
            foreach(DataRow row in dt.Rows)
            {
                cbbDonVi.Items.Add(row[0]);

            }
            dt = nhacungcap.GetAllNhacungcap();
            foreach(DataRow row in dt.Rows)
            {
                cbbTenNhaCC.Items.Add(row[1]);
            }
        }

        private void btnSuaSp_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Tên sản phẩm";
            dataGridView1.Columns[1].Name = "Số lượng theo nhà cung cấp";
            dataGridView1.Columns[2].Name = "Sô lượng thực nhập";
            dataGridView1.Columns[3].Name = "Đơn vị";
            dataGridView1.Columns[4].Name = "Giá nhập";
            string[] row = new string[] {cbbTenSanPham.Text,txtSoluongNCC.Text,txtSoLuongThucNhap.Text,cbbDonVi.Text,txtGiaNhap.Text };
            dataGridView1.Rows.Add(row);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
