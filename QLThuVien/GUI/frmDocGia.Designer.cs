namespace QLThuVien.GUI
{
    partial class frmDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.TrangChu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTrangChu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThongBao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MuonTra = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPhieuMuon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCuonSach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTuaSach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTacGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhaXuatBan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnKeSach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnViTri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ThongTinTroGiup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnQuyDinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoiMatKhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            this.lblTime = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.lblName = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(338, 48);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(921, 655);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.TrangChu,
            this.MuonTra,
            this.Sach,
            this.ThongTinTroGiup,
            this.TaiKhoan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 48);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(338, 655);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // TrangChu
            // 
            this.TrangChu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTrangChu,
            this.btnThongBao});
            this.TrangChu.Expanded = true;
            this.TrangChu.Name = "TrangChu";
            this.TrangChu.Text = "Trang chủ";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThongBao.Text = "Thông báo";
            // 
            // MuonTra
            // 
            this.MuonTra.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPhieuMuon,
            this.btnThongKe});
            this.MuonTra.Expanded = true;
            this.MuonTra.Name = "MuonTra";
            this.MuonTra.Text = "Mượn trả";
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPhieuMuon.Text = "Phiếu mượn";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThongKe.Text = "Thống kê";
            // 
            // Sach
            // 
            this.Sach.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnCuonSach,
            this.btnTuaSach,
            this.btnTacGia,
            this.btnNhaXuatBan,
            this.btnKeSach,
            this.btnViTri});
            this.Sach.Expanded = true;
            this.Sach.Name = "Sach";
            this.Sach.Text = "Sách";
            // 
            // btnCuonSach
            // 
            this.btnCuonSach.Name = "btnCuonSach";
            this.btnCuonSach.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCuonSach.Text = "Cuốn sách";
            this.btnCuonSach.Click += new System.EventHandler(this.btnCuonSach_Click);
            // 
            // btnTuaSach
            // 
            this.btnTuaSach.Name = "btnTuaSach";
            this.btnTuaSach.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTuaSach.Text = "Tựa sách";
            this.btnTuaSach.Click += new System.EventHandler(this.btnTuaSach_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTacGia.Text = "Tác giả";
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnNhaXuatBan
            // 
            this.btnNhaXuatBan.Name = "btnNhaXuatBan";
            this.btnNhaXuatBan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNhaXuatBan.Text = "Nhà xuất bản";
            this.btnNhaXuatBan.Click += new System.EventHandler(this.btnNhaXuatBan_Click);
            // 
            // btnKeSach
            // 
            this.btnKeSach.Name = "btnKeSach";
            this.btnKeSach.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnKeSach.Text = "Kệ sách";
            this.btnKeSach.Click += new System.EventHandler(this.btnKeSach_Click);
            // 
            // btnViTri
            // 
            this.btnViTri.Name = "btnViTri";
            this.btnViTri.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnViTri.Text = "Vị trí thư viện";
            this.btnViTri.Click += new System.EventHandler(this.btnViTri_Click);
            // 
            // ThongTinTroGiup
            // 
            this.ThongTinTroGiup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnQuyDinh});
            this.ThongTinTroGiup.Expanded = true;
            this.ThongTinTroGiup.Name = "ThongTinTroGiup";
            this.ThongTinTroGiup.Text = "Thông tin trợ giúp";
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnQuyDinh.Text = "Quy định thư viện";
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnDoiMatKhau,
            this.btnDangXuat});
            this.TaiKhoan.Expanded = true;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Text = "Tài khoản";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.lblTieuDe,
            this.lblTime,
            this.barStaticItem4,
            this.lblName,
            this.barStaticItem6});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1259, 48);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTime);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem4);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblName);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem6);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Id = 1;
            this.lblTieuDe.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // lblTime
            // 
            this.lblTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblTime.Caption = "time";
            this.lblTime.Id = 2;
            this.lblTime.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTime.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblTime.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTime.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTime.Name = "lblTime";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem4.Caption = "Thời gian:";
            this.barStaticItem4.Id = 3;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // lblName
            // 
            this.lblName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblName.Caption = "name";
            this.lblName.Id = 4;
            this.lblName.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblName.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblName.ItemAppearance.Normal.Options.UseFont = true;
            this.lblName.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblName.Name = "lblName";
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem6.Caption = "Họ tên:";
            this.barStaticItem6.Id = 5;
            this.barStaticItem6.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.barStaticItem6.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem6.Name = "barStaticItem6";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.lblTieuDe,
            this.lblTime,
            this.barStaticItem4,
            this.lblName,
            this.barStaticItem6});
            this.fluentFormDefaultManager1.MaxItemId = 6;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 703);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmDocGia";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Phần Mềm Quản Lý Thư Viện Học Viện KTQS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TrangChu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MuonTra;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Sach;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThongTinTroGiup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTrangChu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThongBao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPhieuMuon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTuaSach;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTacGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhaXuatBan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKeSach;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnViTri;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQuyDinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoiMatKhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDangXuat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
        private DevExpress.XtraBars.BarStaticItem lblTime;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarStaticItem lblName;
        private DevExpress.XtraBars.BarStaticItem barStaticItem6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCuonSach;
    }
}