using QLThuVien.DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frm_VTK : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_VTK()
        {
            InitializeComponent();
        }
        private int currenRowIndex;
        bool insert = false;
        bool update = false;
        DataTable dt = new DataTable();
        string query = "";

        private void frm_VTK_Load(object sender, EventArgs e)
        {
            string sql1 = "select * from vitri";
            dt = DataProvider.GetData(sql1);
            gridControl1.DataSource = dt;
        }

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txtMaViTri.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaViTri"]).ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["DiaChi"]).ToString();
            txtKhu.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Khu"]).ToString();
            txtToaNha.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["ToaNha"]).ToString();
            txtTang.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Tang"]).ToString();
            txtSoPhong.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["SoPhong"]).ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = false;
            btn_cancel.Enabled = true;
            btn_delete.Enabled = false;
            insert = true; update = false;
            txtMaViTri.Text = "";
            txtDiaChi.Text = "";
            txtKhu.Text = "";
            txtToaNha.Text = "";
            txtTang.Text = "";
            txtSoPhong.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; btn_delete.Enabled = false; btn_update.Enabled = true;
            btn_insert.Enabled = false;
            insert = false; update = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false; btn_delete.Enabled = true; btn_update.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa hay không", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    query = "DELETE ViTri WHERE MaViTri = N'" + txtMaViTri.Text + "'";
                    DataProvider.ExecuteQuery(query);
                    frm_VTK_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Lỗi", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    query = "INSERT [dbo].[ViTri] ([MaViTri], [DiaChi], [Khu], [ToaNha], [Tang], [SoPhong]) " +
                        "VALUES (N'" + txtMaViTri.Text + "', N'" + txtDiaChi.Text + "', N'" + txtKhu.Text + "', N'" + txtToaNha.Text + "', " + txtTang.Text + ", N'" + txtSoPhong.Text + "')";
                    DataProvider.ExecuteQuery(query);
                }
                catch
                {
                    MessageBox.Show("Kiểm tra lại thông tin nhập vào", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (update)
            {
                try
                {
                    query = "update ViTri " +
                        "set DiaChi = N'" + txtDiaChi.Text + "', Khu = N'" + txtKhu.Text + "', ToaNha = N'" + txtToaNha.Text + "', Tang = " + txtTang.Text + ", SoPhong = N'" + txtSoPhong.Text + "' " +
                        "where MaViTri = N'" + txtMaViTri.Text + "'";
                    DataProvider.ExecuteQuery(query);
                }
                catch
                {
                    MessageBox.Show("Kiểm tra lại thông tin nhập vào", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            btn_cancel.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            btn_insert.Enabled = true;
            frm_VTK_Load(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy hay không", "Hủy thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_save.Enabled = true;
                btn_cancel.Enabled = true;
                txtMaViTri.Text = "";
                txtDiaChi.Text = "";
                txtKhu.Text = "";
                txtToaNha.Text = "";
                txtTang.Text = "";
                txtSoPhong.Text = "";
                LoadData();
            }
        }

        public void An()
        {
            btn_insert.Visible = false;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                string sql1 = "select * from vitri where DiaChi like '%" + txt_search.Text + "%'";
                dt = DataProvider.GetData(sql1);
                gridControl1.DataSource = dt;
            } else
            {
                string sql1 = "select * from vitri";
                dt = DataProvider.GetData(sql1);
                gridControl1.DataSource = dt;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = string.Empty;
        }
    }
}
