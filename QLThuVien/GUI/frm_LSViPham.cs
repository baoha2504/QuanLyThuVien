using QLThuVien.DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frm_LSViPham : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_LSViPham()
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
            txt_NguoiMuon.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            txtMaPM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPM"]).ToString();
            txtNgayMuon.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayMuon"]).ToString();
            txtNgayTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            txtThuThu.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaTT"]).ToString();
            txtTinhTrangTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrangTra"]).ToString();
            txtLyDo.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["LyDo"]).ToString();
            txtHinhThuc.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["HinhThucXuLy"]).ToString();
            txtSoTienPhat.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SoTienPhat"]).ToString();
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
            if (MessageBox.Show("Bạn muốn lưu dữ liệu được thêm mới không???", "SAVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    query = "UPDATE PhieuPhat " +
                        "SET LyDo = N'" + txtLyDo.Text + "', HinhThucXuLy = N'" + txtHinhThuc.Text + "',SoTienPhat = " + txtSoTienPhat.Text + " " +
                        "FROM PhieuPhat, ChiTietMuon " +
                        "WHERE PhieuPhat.MaPhieuPhat = ChiTietMuon.MaPhieuPhat " +
                        "AND ChiTietMuon.MaPM = N'" + txtMaPM.Text + "'";
                    DataProvider.ExecuteQuery(query);
                    frm_LSViPham_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Kiểm tra lại dữ liệu", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            btn_cancel.Enabled = true;
            btn_save.Enabled = false;
        }

        private void frm_LSViPham_Load(object sender, EventArgs e)
        {
            query = "select PhieuMuon.MaPM, TenDG, NgayMuon, NgayTra, MaTT, TinhTrangTra, LyDo, HinhThucXuLy, SoTienPhat " +
                "from DocGia, PhieuMuon, ChiTietMuon, PhieuPhat " +
                "where DocGia.MaDG = PhieuMuon.MaDG " +
                "and PhieuMuon.MaPM = ChiTietMuon.MaPM " +
                "and ChiTietMuon.MaPhieuPhat = PhieuPhat.MaPhieuPhat";
            gridControl1.DataSource = DataProvider.GetData(query);
            LoadData();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
            btn_save.Enabled = true;
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                query = "select PhieuMuon.MaPM, TenDG, NgayMuon, NgayTra, MaTT, TinhTrangTra, LyDo, HinhThucXuLy, SoTienPhat " +
                "from DocGia, PhieuMuon, ChiTietMuon, PhieuPhat " +
                "where DocGia.MaDG = PhieuMuon.MaDG " +
                "and PhieuMuon.MaPM = ChiTietMuon.MaPM " +
                "and ChiTietMuon.MaPhieuPhat = PhieuPhat.MaPhieuPhat " +
                "and TenDG like N'%" + txt_search.Text + "%' ";
                gridControl1.DataSource = DataProvider.GetData(query);
            }
        }
    }
}
