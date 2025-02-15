﻿namespace QLThuVien.GUI
{
    partial class frm_KS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KS));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_SL = new DevExpress.XtraEditors.TextEdit();
            this.txt_SC = new DevExpress.XtraEditors.TextEdit();
            this.txt_CL = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaKe = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_MaKe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SC = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_CL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SL = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.txt_SL);
            this.layoutControl1.Controls.Add(this.txt_SC);
            this.layoutControl1.Controls.Add(this.txt_CL);
            this.layoutControl1.Controls.Add(this.txt_MaKe);
            this.layoutControl1.Location = new System.Drawing.Point(36, 22);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1272, 203);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_SL
            // 
            this.txt_SL.Enabled = false;
            this.txt_SL.Location = new System.Drawing.Point(784, 56);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Properties.Appearance.Options.UseFont = true;
            this.txt_SL.Size = new System.Drawing.Size(470, 32);
            this.txt_SL.StyleController = this.layoutControl1;
            this.txt_SL.TabIndex = 7;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // txt_SC
            // 
            this.txt_SC.Location = new System.Drawing.Point(163, 56);
            this.txt_SC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SC.Name = "txt_SC";
            this.txt_SC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SC.Properties.Appearance.Options.UseFont = true;
            this.txt_SC.Size = new System.Drawing.Size(470, 32);
            this.txt_SC.StyleController = this.layoutControl1;
            this.txt_SC.TabIndex = 6;
            this.txt_SC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SC_KeyPress);
            // 
            // txt_CL
            // 
            this.txt_CL.Location = new System.Drawing.Point(784, 18);
            this.txt_CL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CL.Name = "txt_CL";
            this.txt_CL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CL.Properties.Appearance.Options.UseFont = true;
            this.txt_CL.Size = new System.Drawing.Size(470, 32);
            this.txt_CL.StyleController = this.layoutControl1;
            this.txt_CL.TabIndex = 5;
            // 
            // txt_MaKe
            // 
            this.txt_MaKe.Enabled = false;
            this.txt_MaKe.Location = new System.Drawing.Point(163, 18);
            this.txt_MaKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaKe.Name = "txt_MaKe";
            this.txt_MaKe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKe.Properties.Appearance.Options.UseFont = true;
            this.txt_MaKe.Size = new System.Drawing.Size(470, 32);
            this.txt_MaKe.StyleController = this.layoutControl1;
            this.txt_MaKe.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_MaKe,
            this.lci_SC,
            this.lci_CL,
            this.lci_SL});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1272, 203);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lci_MaKe
            // 
            this.lci_MaKe.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_MaKe.AppearanceItemCaption.Options.UseFont = true;
            this.lci_MaKe.Control = this.txt_MaKe;
            this.lci_MaKe.Location = new System.Drawing.Point(0, 0);
            this.lci_MaKe.Name = "lci_MaKe";
            this.lci_MaKe.Size = new System.Drawing.Size(621, 38);
            this.lci_MaKe.Text = "Mã Kệ sách";
            this.lci_MaKe.TextSize = new System.Drawing.Size(139, 25);
            // 
            // lci_SC
            // 
            this.lci_SC.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_SC.AppearanceItemCaption.Options.UseFont = true;
            this.lci_SC.Control = this.txt_SC;
            this.lci_SC.Location = new System.Drawing.Point(0, 38);
            this.lci_SC.Name = "lci_SC";
            this.lci_SC.Size = new System.Drawing.Size(621, 135);
            this.lci_SC.Text = "Sức Chứa";
            this.lci_SC.TextSize = new System.Drawing.Size(139, 25);
            // 
            // lci_CL
            // 
            this.lci_CL.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_CL.AppearanceItemCaption.Options.UseFont = true;
            this.lci_CL.Control = this.txt_CL;
            this.lci_CL.Location = new System.Drawing.Point(621, 0);
            this.lci_CL.Name = "lci_CL";
            this.lci_CL.Size = new System.Drawing.Size(621, 38);
            this.lci_CL.Text = "Chất liệu";
            this.lci_CL.TextSize = new System.Drawing.Size(139, 25);
            // 
            // lci_SL
            // 
            this.lci_SL.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_SL.AppearanceItemCaption.Options.UseFont = true;
            this.lci_SL.Control = this.txt_SL;
            this.lci_SL.Location = new System.Drawing.Point(621, 38);
            this.lci_SL.Name = "lci_SL";
            this.lci_SL.Size = new System.Drawing.Size(621, 135);
            this.lci_SL.Text = "Số lượng sách";
            this.lci_SL.TextSize = new System.Drawing.Size(139, 25);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.txt_search);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_update);
            this.panelControl1.Controls.Add(this.btn_insert);
            this.panelControl1.Location = new System.Drawing.Point(52, 234);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1238, 86);
            this.panelControl1.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.ImageOptions.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(639, 18);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 51);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(798, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(415, 49);
            this.txt_search.TabIndex = 17;
            this.txt_search.Text = "Search";
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(480, 18);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 51);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(321, 18);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 51);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(162, 18);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 51);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Appearance.Options.UseFont = true;
            this.btn_insert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.ImageOptions.Image")));
            this.btn_insert.Location = new System.Drawing.Point(3, 18);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(150, 51);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(52, 329);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1238, 324);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.DetailHeight = 512;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Mã kệ sách";
            this.gridColumn1.FieldName = "MaKe";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Chất Liệu";
            this.gridColumn2.FieldName = "ChatLieu";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Sức chứa";
            this.gridColumn3.FieldName = "SucChua";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Số lượng sách";
            this.gridColumn4.FieldName = "SL";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SL", "Tổng={0:0.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 112;
            // 
            // frm_KS
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_KS";
            this.Size = new System.Drawing.Size(1350, 658);
            this.Load += new System.EventHandler(this.frm_KS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txt_SL;
        private DevExpress.XtraEditors.TextEdit txt_SC;
        private DevExpress.XtraEditors.TextEdit txt_CL;
        private DevExpress.XtraEditors.TextEdit txt_MaKe;
        private DevExpress.XtraLayout.LayoutControlItem lci_MaKe;
        private DevExpress.XtraLayout.LayoutControlItem lci_SC;
        private DevExpress.XtraLayout.LayoutControlItem lci_CL;
        private DevExpress.XtraLayout.LayoutControlItem lci_SL;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_insert;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}
