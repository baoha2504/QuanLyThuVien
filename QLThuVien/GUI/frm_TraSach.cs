using QLThuVien.DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frm_TraSach : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_TraSach()
        {
            InitializeComponent();
        }
        private int currenRowIndex;
        DataTable dt = new DataTable();
        string query = "";

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_MaPM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPM"]).ToString();
            txt_NM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            txt_NT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            txt_TenDG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            txt_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            txt_TenTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            txt_MaCS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaCS"]).ToString();
            txt_TT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrang"]).ToString();
            txt_TTTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrangTra"]).ToString();
        }

        private void ReLoadData()
        {
            query = "select PhieuMuon.MaPM,NgayMuon,NgayTra,PhieuMuon.MaDG,TenDG,PhieuMuon.MaTT, TenTT,ChiTietMuon.MaCS,TuaSach.MaTS,TenTS,TinhTrang, TinhTrangTra " +
                "from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach,CuonSach " +
                "where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT=ThuThu.MaTT and PhieuMuon.MaPM=ChiTietMuon.MaPM " +
                "and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS=ChiTietMuon.MaCS and ChiTietMuon.TinhTrangTra = N'Đã mượn'";
            gridControl1.DataSource = DataProvider.GetData(query);
        }

        private void frm_TraSach_Load(object sender, EventArgs e)
        {
            LoadData();
            ReLoadData();
            txt_MaPM.ReadOnly = true;
            txt_NM.ReadOnly = true;
            txt_NT.ReadOnly = true;
            txt_TenDG.ReadOnly = true;
            txt_TenTS.ReadOnly = true;
            txt_TenTT.ReadOnly = true;
            txt_MaCS.ReadOnly = true;
            txt_TT.ReadOnly = true;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text != string.Empty)
            {
                query = "select PhieuMuon.MaPM,NgayMuon,NgayTra,PhieuMuon.MaDG,TenDG,PhieuMuon.MaTT, TenTT,ChiTietMuon.MaCS,TuaSach.MaTS,TenTS,TinhTrang, TinhTrangTra " +
                "from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach,CuonSach " +
                "where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT=ThuThu.MaTT and PhieuMuon.MaPM=ChiTietMuon.MaPM " +
                "and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS=ChiTietMuon.MaCS and ChiTietMuon.TinhTrangTra = N'Đã mượn' " +
                "and TenDG like N'%" + txt_search.Text + "%' ";
                gridControl1.DataSource = DataProvider.GetData(query);
            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hay không", "Hủy thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btn_save.Enabled = true;
                btn_cancel.Enabled = false;
                LoadData();
                txt_MaPM.Text = "";
                txt_NM.Text = "";
                txt_NT.Text = "";
                txt_TenDG.Text = "";
                txt_TenTS.Text = "";
                txt_TenTT.Text = "";
                txt_MaCS.Text = "";
                txt_TT.Text = "";
                txt_TTTra.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu dữ liệu được thay đổi không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "UPDATE ChiTietMuon " +
                    "SET TinhTrangTra = N'" + txt_TTTra.Text + "' " +
                    "WHERE MaPM = N'" + txt_MaPM.Text + "' and MaCS = N'" + txt_MaCS.Text + "'";
                DataProvider.ExecuteQuery(query);
                if(txt_TTTra.Text.Trim() == "Đã trả")
                {
                    query = "UPDATE TuaSach SET SoLuong = SoLuong + 1 WHERE TenTS = N'" + txt_TenTS.Text + "'";
                    DataProvider.ExecuteQuery(query);
                }
                ReLoadData();
            }

            btn_cancel.Enabled = true;
            btn_save.Enabled = false;
        }
    }
}
