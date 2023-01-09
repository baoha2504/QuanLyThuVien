using QLThuVien.BUSLayer;
using System;
using System.Data;
using QLThuVien.DataAccessLayer;
namespace QLThuVien.Form_Info
{
    public partial class frm_TTTS : DevExpress.XtraEditors.XtraForm
    {
        public static string MaTS;
        public frm_TTTS()
        {
            InitializeComponent();
        }

        private void frm_TTTS_Load(object sender, EventArgs e)
        {
            if (MaTS != string.Empty)
            {
                //char MaTS1 = Convert.ToChar(MaTS);
                string query = "select TuaSach.MaTS, TenTS, TheLoai, MaViTri, TenTG, TenNXB, NamXB, SoTrang, SoLuong " +
                    "from TuaSach, TacGia, Viet, NXB, KeSach, CuonSach " +
                    "where TuaSach.MaNXB = NXB.MaNXB " +
                    "and TuaSach.MaTS = Viet.MaTS " +
                    "and Viet.MaTG = TacGia.MaTG " +
                    "and KeSach.MaKe = TuaSach.MaKe " +
                    "and CuonSach.MaTS = TuaSach.MaTS " +
                    "and CuonSach.MaCS = N'"+ MaTS + "'";
                DataTable dt = DataProvider.GetData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_MaTS.Text = dr["MaTS"].ToString();
                    txt_TenTS.Text = dr["TenTS"].ToString();
                    txt_TL.Text = dr["TheLoai"].ToString();
                    txt_VT.Text = dr["MaViTri"].ToString();
                    txt_TG.Text = dr["TenTG"].ToString();
                    txt_NXB.Text = dr["TenNXB"].ToString();
                    txt_XB.Text = dr["NamXB"].ToString();
                    txt_ST.Text = dr["SoTrang"].ToString();
                    txt_SL.Text = dr["SoLuong"].ToString();
                }
            }
        }
    }
}