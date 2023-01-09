
namespace QLThuVien.GUI
{
    partial class frm_TKNS_TT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlNhapSachTT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlNhapSachCur = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapSachTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapSachCur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhapSachTT
            // 
            this.gridControlNhapSachTT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlNhapSachTT.Location = new System.Drawing.Point(237, 56);
            this.gridControlNhapSachTT.MainView = this.gridView1;
            this.gridControlNhapSachTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlNhapSachTT.Name = "gridControlNhapSachTT";
            this.gridControlNhapSachTT.Size = new System.Drawing.Size(1452, 487);
            this.gridControlNhapSachTT.TabIndex = 0;
            this.gridControlNhapSachTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 416;
            this.gridView1.GridControl = this.gridControlNhapSachTT;
            this.gridView1.Name = "gridView1";
            // 
            // gridControlNhapSachCur
            // 
            this.gridControlNhapSachCur.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlNhapSachCur.Location = new System.Drawing.Point(237, 627);
            this.gridControlNhapSachCur.MainView = this.gridView2;
            this.gridControlNhapSachCur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlNhapSachCur.Name = "gridControlNhapSachCur";
            this.gridControlNhapSachCur.Size = new System.Drawing.Size(1452, 479);
            this.gridControlNhapSachCur.TabIndex = 1;
            this.gridControlNhapSachCur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 416;
            this.gridView2.GridControl = this.gridControlNhapSachCur;
            this.gridView2.Name = "gridView2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(237, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(352, 32);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách tài liệu được nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(237, 587);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(454, 32);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Danh sách tài liệu được nhập gần đây";
            // 
            // frm_TKNS_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlNhapSachCur);
            this.Controls.Add(this.gridControlNhapSachTT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_TKNS_TT";
            this.Size = new System.Drawing.Size(1998, 1109);
            this.Load += new System.EventHandler(this.frm_TKNS_TT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapSachTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapSachCur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhapSachTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlNhapSachCur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
