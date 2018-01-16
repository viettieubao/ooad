    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.Report;
namespace QuanLiVatLieuXayDung.View
{
    public partial class frmView : Form
    {
        HoaDonOutput hoaDonOutput;
        public frmView()
        {
            InitializeComponent();
            hoaDonOutput = new HoaDonOutput();
        }
        public void LapHoaDon(string tenkhachhang, string diachi, int madonhang, string sodienthoai, string tongsotienbangchu)
        {
            foreach (DevExpress.XtraReports.Parameters.Parameter p in hoaDonOutput.Parameters)
                p.Visible = false;
            hoaDonOutput.InitData(tenkhachhang,diachi,madonhang,sodienthoai,tongsotienbangchu);
            hoaDonOutput.CreateDocument();
            documentViewer1.DocumentSource = hoaDonOutput;

        }
    }
}
