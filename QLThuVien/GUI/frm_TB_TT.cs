using System;
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
    public partial class frm_TB_TT : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection sqlCon = new SqlConnection(DataProvider.connectionStr);
        public frm_TB_TT()
        {
            InitializeComponent();
        }
        string query = "";
        string txt;
        private void LoadText(string sql)
        {
            string constr = DataProvider.connectionStr;
            string Sql = sql;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    txt = DR["SoLuong"].ToString();
                    break;
                }
                DR.Close();
                conn.Close();
            }
        }

        private void frm_TB_TT_Load(object sender, EventArgs e)
        {
            query = "select count(MaPM) as SoLuong from PhieuMuon where MONTH(NgayMuon) = MONTH(getdate())  and YEAR(NgayMuon) = Year(getdate())";
            LoadText(query);
            textBox6.Text = txt;
            query = "select count(MaPM) as SoLuong from PhieuMuon where MONTH(NgayMuon) = MONTH(getDate()) and YEAR(NgayMuon) = Year(getdate()) and NgayTra is not null";
            LoadText(query);
            textBox5.Text = txt;
            int sachchomuon = int.Parse(txt);
            query = "select count(MaCS) as SoLuong from CuonSach";
            LoadText(query);
            int sachhienco = int.Parse(txt);
            textBox4.Text = (sachhienco - sachchomuon).ToString();
            query = "select count(MaDG) as SoLuong from DocGia";
            LoadText(query);
            textBox3.Text = txt;
            // so lan vi pham trong thang
            query = "select  count(p.MaPM) as SoLuong  from ChiTietMuon c, PhieuMuon p  where Month(p.NgayTra) = MONTH(getdate()) and year(p.NgayTra) = Year(getdate()) And c.MaPM = p.MaPM and MaPhieuPhat IS not NULL";
            LoadText(query);
            textBox2.Text = txt;
            // so tien xu phat trong thang
            query = "select sum(sotienphat) as SoLuong from PhieuPhat, PhieuMuon p, Chitietmuon c where p.MaPM = c.MaPM and Month(p.NgayTra) = MONTH(getdate()) and year(p.NgayTra) = Year(getdate()) and c.MaPhieuPhat = PhieuPhat.MaPhieuPhat ";
            LoadText(query);
            if (string.IsNullOrEmpty(txt)) textBox1.Text = "0";
            else  textBox1.Text = txt;
        }
    }
}
