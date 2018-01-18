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
    public partial class ucThayDoiQuyDinh : UserControl
    {
        ThamSoController thamSo;
        public ucThayDoiQuyDinh()
        {
            InitializeComponent();
            thamSo = new ThamSoController();
            load();
        }

        void load()
        {
            dgvQuyDinh.DataSource = thamSo.getAllThamSo();
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (thamSo.SearchThamSoTheoTen(txtQuyDinh.Text).Rows.Count == 0)
            {
                thamSo.InsertThamso(txtQuyDinh.Text, int.Parse(txtGiaTri.Text));
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Quy định đã tồn tại");
            }
            load();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            thamSo.UpdateThamSo(txtQuyDinh.Text, int.Parse(txtGiaTri.Text));
            load();
        }

        private void dgvQuyDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuyDinh.Text = dgvQuyDinh.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtGiaTri.Text = dgvQuyDinh.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }
    }
}
