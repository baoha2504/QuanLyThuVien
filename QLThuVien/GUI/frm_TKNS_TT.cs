using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.BUSLayer;
using QLThuVien.DataAccessLayer;
using QLThuVien.ValueObject;
using System.Data.SqlClient;
using QLThuVien.Form_Info;

namespace QLThuVien.GUI
{
    public partial class frm_TKNS_TT : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection sqlCon = new SqlConnection(DataProvider.connectionStr);
        public frm_TKNS_TT()
        {
            InitializeComponent();
        }
        private void connect()
        {
            sqlCon.Close();
            sqlCon.Open();
            string query = "select p.MaPN, c.MaTS, t.TenTS,p.NgayLap,p.MaNCC, c.SoLuong, c.DonGia, p.TongTien, p.MaTT from PhieuNhap p, ChiTietNhap c, TuaSach t" +
                            " where t.MaTS = c.MaTS order by p.NgayLap desc";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            gridControlNhapSachTT.DataSource = dtb;

            string query1 = "select p.MaPN, c.MaTS, t.TenTS,p.NgayLap,p.MaNCC, c.SoLuong, c.DonGia, p.TongTien, p.MaTT from PhieuNhap p, ChiTietNhap c, TuaSach t " +
                            "where t.MaTS = c.MaTS and MOnth(p.NgayLap) = 12 and YEAR(p.NgayLap) = 2022";
            SqlDataAdapter sqlDa1 = new SqlDataAdapter(query1, sqlCon);
            DataTable dtb1 = new DataTable();
            sqlDa1.Fill(dtb1);
            gridControlNhapSachCur.DataSource = dtb1;
            sqlCon.Close();
        }

        private void frm_TKNS_TT_Load(object sender, System.EventArgs e)
        {
            connect();
        }
    }
}
