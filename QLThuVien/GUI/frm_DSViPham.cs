using QLThuVien.DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frm_DSViPham : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_DSViPham()
        {
            InitializeComponent();
        }

        private int currenRowIndex;
        DataTable dt = new DataTable();
        DataTable dtid = new DataTable();
        string query = "";

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_NguoiMuon.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            txtMaPM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPM"]).ToString();
            txtNgayMuon.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayMuon"]).ToString();
            txtNgayTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            txtThuThu.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaTT"]).ToString();
            txtTinhTrangTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrangTra"]).ToString();
        }

        private void frm_DSViPham_Load(object sender, EventArgs e)
        {
            query = "select PhieuMuon.MaPM, TenDG, NgayMuon, NgayTra, MaTT, ChiTietMuon.TinhTrangTra " +
                "from PhieuMuon, ChiTietMuon, DocGia " +
                "where PhieuMuon.MaPM = ChiTietMuon.MaPM " +
                "and DocGia.MaDG = PhieuMuon.MaDG " +
                "and MaPhieuPhat is null " +
                "and ((ChiTietMuon.TinhTrangTra = N'Đã mượn' and PhieuMuon.NgayTra < '" + DateTime.Now.ToString("yyyy-MM-dd") + "') " +
                "or (ChiTietMuon.TinhTrangTra != N'Đã mượn' and ChiTietMuon.TinhTrangTra != N'Đã trả'))";
            gridControl1.DataSource = DataProvider.GetData(query);
            LoadData();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                query = "select PhieuMuon.MaPM, TenDG, NgayMuon, NgayTra, MaTT, ChiTietMuon.TinhTrangTra " +
                    "from PhieuMuon, ChiTietMuon, DocGia " +
                    "where PhieuMuon.MaPM = ChiTietMuon.MaPM " +
                    "and DocGia.MaDG = PhieuMuon.MaDG " +
                    "and TenDG like N'%" + txt_search.Text + "%' " +
                    "and MaPhieuPhat is null " +
                    "and ((ChiTietMuon.TinhTrangTra = N'Đã mượn' and PhieuMuon.NgayTra < '" + DateTime.Now.ToString("yyyy-MM-dd") + "') " +
                    "or (ChiTietMuon.TinhTrangTra != N'Đã mượn' and ChiTietMuon.TinhTrangTra != N'Đã trả'))";
                gridControl1.DataSource = DataProvider.GetData(query);
            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hay không", "Hủy thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btn_save.Enabled = true;
                btn_cancel.Enabled = false;
                LoadData();
                txt_NguoiMuon.Text = "";
                txtMaPM.Text = "";
                txtNgayMuon.Text = "";
                txtNgayTra.Text = "";
                txtLyDo.Text = "";
                txtHinhThuc.Text = "";
                txtSoTienPhat.Text = "";
                txtThuThu.Text = "";
                txtTinhTrangTra.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mới không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    query = "INSERT INTO PhieuPhat(LyDo, HinhThucXuLy, SoTienPhat) " +
                        "VALUES (N'" + txtLyDo.Text + "', N'" + txtHinhThuc.Text + "', " + txtSoTienPhat.Text + ");";
                    DataProvider.ExecuteQuery(query);
                    query = "SELECT* FROM PhieuPhat";
                    dtid = DataProvider.GetData(query);
                    foreach (DataRow row in dtid.Rows)
                    {
                        a = int.Parse(row["MaPhieuPhat"].ToString());
                    }
                    query = "UPDATE ChiTietMuon SET MaPhieuPhat = " + a.ToString() + "" +
                        "WHERE MaPM = N'" + txtMaPM.Text + "' and TinhTrangTra = N'" + txtTinhTrangTra.Text + "'";
                    DataProvider.ExecuteQuery(query);
                    frm_DSViPham_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Kiểm tra lại dữ liệu", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            btn_cancel.Enabled = true;
            btn_save.Enabled = false;
        }
    }
}
