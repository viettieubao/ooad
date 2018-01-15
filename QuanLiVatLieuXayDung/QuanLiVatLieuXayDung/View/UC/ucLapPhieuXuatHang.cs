using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.Controller;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapPhieuXuatHang : UserControl
    {
        HoaDonController hoadonController = new HoaDonController();
        PhieuXuatHangController phieuxuatController = new PhieuXuatHangController();
        DataTable chiTietHoaDon = null;
        List<int> listMaSP = new List<int>();
        List<int> listDonViTinh = new List<int>();
        int maHoaDon = -1;


        public ucLapPhieuXuatHang()
        {
            InitializeComponent();
            rbMaHoaDon.Checked = true;
            rbTenKhachHang.Checked = false;
            txtSoLuongXuat.Text = "0";
            btnThem.Enabled = false;
            btnSuaSp.Enabled = false;
            btnXoa.Enabled = false;
            txtTongTien.Text = "0";
        }

        private void updateTongTien()
        {
            long tongTien = 0;
            for (int rows = 0; rows < dgvDanhSachSanPham.Rows.Count; rows++)
            {
                tongTien += (int.Parse(dgvDanhSachSanPham.Rows[rows].Cells[1].Value.ToString()) * int.Parse(dgvDanhSachSanPham.Rows[rows].Cells[2].Value.ToString()));
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void rbMaHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoaDon.Checked)
            {
                rbTenKhachHang.Checked = false;
            }
        }

        private void rbTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTenKhachHang.Checked)
            {
                rbMaHoaDon.Checked = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                if (rbMaHoaDon.Checked)
                {
                    int maHoaDon = 0;
                    if (int.TryParse(txtTimKiem.Text, out maHoaDon))
                    {
                        DataTable dt = hoadonController.SearchMaHoaDon(int.Parse(txtTimKiem.Text));
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachHoaDon.DataSource = dt;
                        }
                        else
                        {
                            clearHoaDonData();
                        }
                    }
                    else
                    {
                        clearHoaDonData();
                    }
                }
                else
                {
                    DataTable dt = hoadonController.SearchTenKhachHang(txtTimKiem.Text);
                    if (dt.Rows.Count > 0)
                    {
                        dgvDanhSachHoaDon.DataSource = dt;
                    }
                    else
                    {
                        clearHoaDonData();
                    }
                }
            }
        }

        private void clearHoaDonData()
        {
            dgvDanhSachSanPham.Rows.Clear();
            cbbTenSanPham.DataSource = null;
            cbbTenSanPham.Items.Clear();
            txtDonViTinh.Text = "";
            txtGiaBan.Text = "";
            txtMaHoaDon.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtTongTien.Text = "";
            txtSoLuongXuat.Text = "0";
        }

        bool checkValidate()
        {
            int soLuongXuat = 0;
            if (!int.TryParse(txtSoLuongXuat.Text.Trim(), out soLuongXuat))
            {
                return false;
            }
            
            return true;
        }

        private void loadThongTinSanPham()
        {
            txtSoLuongXuat.Text = "0";
            dgvDanhSachSanPham.Rows.Clear();
            chiTietHoaDon = hoadonController.GetChiTietHoaDon(int.Parse(txtMaHoaDon.Text));
            txtSoLuongConLai.Text = (int.Parse(chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["soluongsanpham"].ToString()) - int.Parse(chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["soluongsanphamdaxuat"].ToString())).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!listMaSP.Contains((int)cbbTenSanPham.SelectedValue))
            {
                if (checkValidate())
                {
                    if (int.Parse(txtSoLuongXuat.Text) <= int.Parse(txtSoLuongConLai.Text))
                    {
                        string[] row = new string[] { cbbTenSanPham.Text, txtSoLuongXuat.Text, txtGiaBan.Text, txtDonViTinh.Text, txtGiaBan.Text, (long.Parse(txtSoLuongXuat.Text) * long.Parse(txtGiaBan.Text)).ToString() };
                        dgvDanhSachSanPham.Rows.Add(row);
                        listMaSP.Add((int)cbbTenSanPham.SelectedValue);
                        listDonViTinh.Add((int)chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["madonvitinh"]);
                        updateTongTien();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm xuất vượt quá số lượng còn lại trong hoá đơn");
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng xuất không đúng định dạng số");
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm bạn chọn đã được thêm vào trước đó. Vui lòng chọn Sửa");
            }
        }

        private void btnSuaSp_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                if (dgvDanhSachSanPham.Rows.Count > 0)
                {
                    string tongtien = (long.Parse(txtGiaBan.Text) * int.Parse(txtSoLuongXuat.Text)).ToString();
                    string[] row = new string[] { cbbTenSanPham.Text, txtSoLuongXuat.Text, txtGiaBan.Text, txtDonViTinh.Text, txtGiaBan.Text, tongtien };
                    int index = dgvDanhSachSanPham.CurrentRow.Index;
                    dgvDanhSachSanPham.Rows.RemoveAt(index);
                    dgvDanhSachSanPham.Rows.Insert(index, row);
                    listMaSP[index] = (int)cbbTenSanPham.SelectedValue;
                    listDonViTinh[index] = (int)chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["madonvitinh"];
                    updateTongTien();
                }
            }
            else
            {
                MessageBox.Show("Số lượng xuất không đúng định dạng số");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSanPham.Rows.Count > 0)
            {
                int index = dgvDanhSachSanPham.CurrentRow.Index;
                dgvDanhSachSanPham.Rows.RemoveAt(index);
                listMaSP.RemoveAt(index);
                listDonViTinh.RemoveAt(index);
                updateTongTien();
            }
        }

        private void dgvDanhSachHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHoaDon.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhachHang.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtSoDienThoai.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtDiaChi.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNgayXuat.Text = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            chiTietHoaDon = hoadonController.GetChiTietHoaDon(int.Parse(dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()));
            cbbTenSanPham.DataSource = chiTietHoaDon;
            cbbTenSanPham.ValueMember = "masanpham";
            cbbTenSanPham.DisplayMember = "tensanpham";
            maHoaDon = int.Parse(dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            txtSoLuongConLai.Text = (int.Parse(chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["soluongsanpham"].ToString()) - int.Parse(chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex]["soluongsanphamdaxuat"].ToString())).ToString();
            btnThem.Enabled = true;
            btnSuaSp.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenSanPham.SelectedIndex != -1)
            {
                DataRow row = chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex];
                txtDonViTinh.Text = row["tendonvitinh"].ToString();
                //txtGiaBan.Text = chiTietHoaDon.Rows[cbbTenSanPham.SelectedIndex][4].ToString();
                if (row["madonvitinhbansi"] == row["madonvitinh"])
                {
                    txtGiaBan.Text = row["giabansi"].ToString();
                }
                else
                {
                    txtGiaBan.Text = row["giabanle"].ToString();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.Date.ToString());;
            DataTable dssp = new DataTable();
            if (dgvDanhSachSanPham.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvDanhSachSanPham.Columns)
                {
                    dssp.Columns.Add(col.Name);
                }
            }
            object[] cellValues = new object[dgvDanhSachSanPham.Columns.Count];
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dssp.Rows.Add(cellValues);
            }
            phieuxuatController.InsertPhieuXuatHang(maHoaDon, long.Parse(txtGiaBan.Text) * long.Parse(txtSoLuongXuat.Text), txtNguoiGiaoHang.Text, dssp, listMaSP, listDonViTinh);
            loadThongTinSanPham();
        }

        private void txtSoLuongXuat_TextChanged(object sender, EventArgs e)
        {
            int soLuongXuat = 0;
            int giaBan = 0;

            if (int.TryParse(txtSoLuongXuat.Text.Trim(), out soLuongXuat) && int.TryParse(txtGiaBan.Text.Trim(), out giaBan))
            {
                txtThanhTien.Text = (int.Parse(txtSoLuongXuat.Text) * int.Parse(txtGiaBan.Text)).ToString();
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }
    }
}
