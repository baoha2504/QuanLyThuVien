using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frmDocGia : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        frm_GT frm_GT;
        frm_CS frm_CS;
        frm_TS frm_TS;
        frm_TG frm_TG;
        frm_NXB frm_NXB;
        frm_KS frm_KS;
        

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (frm_GT == null)
            {
                frm_GT frm_GT = new frm_GT();
                frm_GT.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_GT);
                frm_GT.BringToFront();
            }
            else
            {
                frm_GT.BringToFront();
            }
            lblTieuDe.Caption = "Trang chủ";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DangNhap frmLogin = new DangNhap();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnCuonSach_Click(object sender, EventArgs e)
        {

        }
    }
}
