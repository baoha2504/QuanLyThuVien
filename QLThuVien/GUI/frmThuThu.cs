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
    public partial class frmThuThu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmThuThu()
        {
            InitializeComponent();
        }

        frm_GT frm_GT;
        frm_TS frm_TS;
        frm_TG frm_TG;
        frm_NXB frm_NXB;
        frm_KS frm_KS;
        frm_PM frm_PM;
        frm_PN frm_PN;
        frm_NCC frm_NCC;
        frm_TT frm_TT;
        frm_DG frm_DG;
        frm_CS frm_CS;
        frm_TK frm_TK;
        frm_QuyDinh frm_QuyDinh;
        frm_DoiMK frm_DoiMK;
        frm_VTK frm_VTK;
        frm_TraSach frm_TraSach;

        public void An()
        {
            QuanLyTaiKhoan.Visible = false;
        }

        private void frmThuThu_Load(object sender, EventArgs e)
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
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DangNhap frmLogin = new DangNhap();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            if (frm_TG == null)
            {
                frm_TG frm_TG = new frm_TG();
                frm_TG.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TG);
                frm_TG.BringToFront();
            }
            else
            {
                frm_TG.BringToFront();
            }
            lblTieuDe.Caption = "Tác Giả";
        }

        private void btnTuaSach_Click(object sender, EventArgs e)
        {
            if (frm_TS == null)
            {
                frm_TS frm_TS = new frm_TS();
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

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (frm_NXB == null)
            {
                frm_NXB frm_NXB = new frm_NXB();
                frm_NXB.Dock = DockStyle.Fill;
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
                mainContainer.Controls.Add(frm_KS);
                frm_KS.BringToFront();
            }
            else
            {
                frm_KS.BringToFront();
            }
            lblTieuDe.Caption = "Kệ sách";
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (frm_PM == null)
            {
                frm_PM frm_PM = new frm_PM();
                frm_PM.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_PM);
                frm_PM.BringToFront();
            }
            else
            {
                frm_PM.BringToFront();
            }
            lblTieuDe.Caption = "Mượn sách";
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            if (frm_PN == null)
            {
                frm_PN frm_PN = new frm_PN();
                frm_PN.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_PN);
                frm_PN.BringToFront();
            }
            else
            {
                frm_PN.BringToFront();
            }
            lblTieuDe.Caption = "Nhập sách";
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            if (frm_NCC == null)
            {
                frm_NCC frm_NCC = new frm_NCC();
                frm_NCC.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_NCC);
                frm_NCC.BringToFront();
            }
            else
            {
                frm_NCC.BringToFront();
            }
            lblTieuDe.Caption = "Nhà cung cấp";
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            if (frm_TT == null)
            {
                frm_TT frm_TT = new frm_TT();
                frm_TT.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TT);
                frm_TT.BringToFront();
            }
            else
            {
                frm_TT.BringToFront();
            }
            lblTieuDe.Caption = "Tài khoản thủ thư";
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            if (frm_DG == null)
            {
                frm_DG frm_DG = new frm_DG();
                frm_DG.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_DG);
                frm_DG.BringToFront();
            }
            else
            {
                frm_DG.BringToFront();
            }
            lblTieuDe.Caption = "Tài khoản độc giả";
        }

        private void btnCuonSach_Click(object sender, EventArgs e)
        {
            if (frm_CS == null)
            {
                frm_CS frm_CS = new frm_CS();
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

        private void btnTKTuaSach_Click(object sender, EventArgs e)
        {
            if (frm_TK == null)
            {
                frm_TK frm_TK = new frm_TK();
                frm_TK.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TK);
                frm_TK.BringToFront();
            }
            else
            {
                frm_TK.BringToFront();
            }
            lblTieuDe.Caption = "Thống kê tựa sách";
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
            lblTieuDe.Caption = "Quy định thư viện";
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

        private void btnViTriKe_Click(object sender, EventArgs e)
        {
            if (frm_VTK == null)
            {
                frm_VTK frm_VTK = new frm_VTK();
                frm_VTK.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_VTK);
                frm_VTK.BringToFront();
            }
            else
            {
                frm_VTK.BringToFront();
            }
            lblTieuDe.Caption = "Vị trí kệ";
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (frm_TraSach == null)
            {
                frm_TraSach frm_TraSach = new frm_TraSach();
                frm_TraSach.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(frm_TraSach);
                frm_TraSach.BringToFront();
            }
            else
            {
                frm_TraSach.BringToFront();
            }
            lblTieuDe.Caption = "Trả sách";
        }
    }
}
