using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using QuanLiVatLieuXayDung.Controller;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View.UC
{
    public partial class ucLapBaoCaoTon : UserControl
    {
        BaoCaoController baocaoController = new BaoCaoController();
        DataTable sanpham = null;
        SanPhamController sanphamController = new SanPhamController();
        int nam = -1;
        public ucLapBaoCaoTon()
        {
            InitializeComponent();
            cbbThang.SelectedIndex = 0;
            sanpham = sanphamController.GetAllSanPham();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            dgvChiTietBaoCao.Rows.Clear();
            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Năm báo cáo không được bỏ trống");
                return;
            }

            if (int.TryParse(txtNam.Text, out nam))
            {
                if (nam <= 2099 && nam >= 1990)
                {
                    if (sanpham.Rows.Count > 0)
                    {
                        foreach (DataRow spRow in sanpham.Rows)
                        {
                            int masp = int.Parse(spRow[0].ToString());
                            DataTable tempt = baocaoController.GetBaoCaoTon(masp, cbbThang.SelectedIndex + 1, nam);
                            int soluongtondauthang = 0, soluongtoncuoithang = 0, soluongnhaptrongthang = 0, soluongxuattrongthang = 0;
                            if (tempt.Rows[0][3].ToString() != "")
                            {
                                soluongtondauthang = (int)tempt.Rows[0][3];
                            }
                            if (tempt.Rows[0][4].ToString() != "")
                            {
                                soluongtoncuoithang = (int)tempt.Rows[0][4];
                            }
                            if (tempt.Rows[0][5].ToString() != "")
                            {
                                soluongnhaptrongthang = (int)tempt.Rows[0][5];
                            }
                            if (tempt.Rows[0][6].ToString() != "")
                            {
                                soluongxuattrongthang = (int)tempt.Rows[0][6];
                            }

                            string[] row = new string[] { tempt.Rows[0][0].ToString(), tempt.Rows[0][1].ToString(), tempt.Rows[0][2].ToString(), soluongtondauthang.ToString(), soluongtoncuoithang.ToString(), soluongnhaptrongthang.ToString(), soluongxuattrongthang.ToString() };
                            dgvChiTietBaoCao.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Năm báo cáo phải trong khoảng năm 1990 - 2099");
                }
            }
            else
            {
                MessageBox.Show("Năm báo cáo phải ở định dạng số");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int nambaocao = 0;
            if (int.TryParse(txtNam.Text, out nambaocao) && nambaocao != nam)
            {
                MessageBox.Show("Vui lòng chọn Lập báo cáo trước khi lưu báo cáo");
                return;
            }
            if (dgvChiTietBaoCao.Rows.Count > 0)
            {
                DataTable baoCaoTable = new DataTable();
                //MessageBox.Show(DateTime.Now.Date.ToString());;
                if (dgvChiTietBaoCao.Columns.Count > 0)
                {
                    foreach (DataGridViewColumn col in dgvChiTietBaoCao.Columns)
                    {
                        baoCaoTable.Columns.Add(col.Name);
                    }
                }
                object[] cellValues = new object[dgvChiTietBaoCao.Columns.Count];
                foreach (DataGridViewRow row in dgvChiTietBaoCao.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    baoCaoTable.Rows.Add(cellValues);
                }
                baocaoController.InsertBaoCaoTon(cbbThang.SelectedIndex + 1, nam, baoCaoTable);
            }
        }
    }
}
