using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        string query = "";

        private void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            //txt_MaPM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaPM"]).ToString();
            //txt_NM.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            //txt_NT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["NgayTra"]).ToString();
            //txt_TenDG.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenDG"]).ToString();
            //txt_TenTS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTS"]).ToString();
            //txt_TenTT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TenTT"]).ToString();
            //txt_MaCS.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["MaCS"]).ToString();
            //txt_TT.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrang"]).ToString();
            //txt_TTTra.Text = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["TinhTrangTra"]).ToString();
        }

        private void frm_DSViPham_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
