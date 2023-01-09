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
        frm_DoiMK frm_DoiMK;
        frm_QuyDinh frm_QuyDinh;
        frm_PMDG frm_phieumuon;
        frm_TKDG frm_TKDG;
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
            lblName.Caption = DangNhap.name;
            lblTime.Caption = DateTime.Now.ToString("dd/MM/yyyy");
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
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DangNhap frmLogin = new DangNhap();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnCuonSach_Click(object sender, EventArgs e)
        {
            if (frm_CS == null)
            {
                frm_CS frm_CS = new frm_CS();
                frm_CS.An();
                frm_CS.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_CS);
                frm_CS.BringToFront();
            }
            else
            {
                frm_CS.BringToFront();
            }
            lblTieuDe.Caption = "Cuốn sách";
        }

        private void btnTuaSach_Click(object sender, EventArgs e)
        {
            if (frm_TS == null)
            {
                frm_TS frm_TS = new frm_TS();
                frm_TS.An();
                frm_TS.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TS);
                frm_TS.BringToFront();
            }
            else
            {
                frm_TS.BringToFront();
            }
            lblTieuDe.Caption = "Tựa sách";
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            if (frm_TG == null)
            {
                frm_TG frm_TG = new frm_TG();
                frm_TG.An();
                frm_TG.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TG);
                frm_TG.BringToFront();
            }
            else
            {
                frm_GT.BringToFront();
            }
            lblTieuDe.Caption = "Tác giả";
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (frm_NXB == null)
            {
                frm_NXB frm_NXB = new frm_NXB();
                frm_NXB.Dock = DockStyle.Fill;
                frm_NXB.An();
                mainContainer.Controls.Add(frm_NXB);
                frm_NXB.BringToFront();
            }
            else
            {
                frm_NXB.BringToFront();
            }
            lblTieuDe.Caption = "Nhà xuất bản";
        }

        private void btnKeSach_Click(object sender, EventArgs e)
        {
            if (frm_KS == null)
            {
                frm_KS frm_KS = new frm_KS();
                frm_KS.Dock = DockStyle.Fill;
                frm_KS.An();
                mainContainer.Controls.Add(frm_KS);
                frm_KS.BringToFront();
            }
            else
            {
                frm_KS.BringToFront();
            }
            lblTieuDe.Caption = "Kệ sách";
        }

        private void btnViTri_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (frm_DoiMK == null)
            {
                frm_DoiMK frm_DoiMK = new frm_DoiMK();
                frm_DoiMK.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_DoiMK);
                frm_DoiMK.BringToFront();
            }
            else
            {
                frm_DoiMK.BringToFront();
            }
            lblTieuDe.Caption = "Đổi mật khẩu";
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            if (frm_QuyDinh == null)
            {
                frm_QuyDinh frm_QuyDinh = new frm_QuyDinh();
                frm_QuyDinh.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_QuyDinh);
                frm_QuyDinh.BringToFront();
            }
            else
            {
                frm_QuyDinh.BringToFront();
            }
            lblTieuDe.Caption = "Quy định của thư viện";
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            if (frm_phieumuon == null)
            {
                frm_PMDG frm_phieumuon = new frm_PMDG();
                frm_phieumuon.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_phieumuon);
                frm_phieumuon.BringToFront();
            }
            else
            {
                frm_phieumuon.BringToFront();
            }
            lblTieuDe.Caption = "Thông tin phiếu mượn trả";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (frm_TKDG == null)
            {
                frm_TKDG frm_TKDG = new frm_TKDG();
                frm_TKDG.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TKDG);
                frm_TKDG.BringToFront();
            }
            else
            {
                frm_TKDG.BringToFront();
            }
            lblTieuDe.Caption = "Thống kê";

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
