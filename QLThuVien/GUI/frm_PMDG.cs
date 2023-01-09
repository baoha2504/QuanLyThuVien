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
    public partial class frm_PMDG : DevExpress.XtraEditors.XtraUserControl
    {

        SqlConnection sqlCon = new SqlConnection(DataProvider.connectionStr);
        public frm_PMDG()
        {
            InitializeComponent();

        }
        private void connect()
        {
            sqlCon.Close();
            sqlCon.Open();
            string query = "select PhieuMuon.MaPM ,NgayMuon ,NgayTra,ChiTietMuon.MaCS,TenTS , TenTT,TinhTrang " +
                  " from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach, CuonSach" +
                  " where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT= ThuThu.MaTT and PhieuMuon.MaPM= ChiTietMuon.MaPM" +
                  " and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS= ChiTietMuon.MaCS and PhieuMuon.MaDG = N'"+DangNhap.id.Trim()+"'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            gridControlPM.DataSource = dtb;
            sqlCon.Close();
        }
        private int currenRowIndex;
        private void frm_PMDG_Load(object sender, EventArgs e)
        {
            connect();      
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                string query = "select PhieuMuon.MaPM ,NgayMuon ,NgayTra,ChiTietMuon.MaCS,TenTS , TenTT,TinhTrang " +
                  " from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach, CuonSach" +
                  " where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT= ThuThu.MaTT " +
                  "and PhieuMuon.MaPM= ChiTietMuon.MaPM and TenTS LIKE N'%" + txt_search.Text + "%'" +
                  " and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS= ChiTietMuon.MaCS and PhieuMuon.MaDG = N'" + DangNhap.id.Trim() + "'";
                gridControlPM.DataSource = DataProvider.GetData(query);
            }
            else
            {
                connect();
            }
        }
        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_cs.Text = gridView1.GetRowCellValue(currenRowIndex, "MaCS").ToString();
            txtNM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayMuon"]).ToString();
            txtNT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            txtTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            txtTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            txtStatus.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrang"]).ToString();
        }
    }
}
