namespace QUANLYNHANSU
{
    partial class frmLoaiCa
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhongLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtHeSo = new System.Windows.Forms.MaskedTextBox();
            this.txtTenLoaiCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ShiftTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShiftTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coefficinet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnKhongLuu,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKhongLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.add_16x163;
            this.btnThem.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.add_32x323;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.editname_16x163;
            this.btnSua.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.editname_32x323;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.clear_16x163;
            this.btnXoa.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.clear_32x323;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.saveto_16x163;
            this.btnLuu.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.saveto_32x323;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKhongLuu.Caption = "Không lưu";
            this.btnKhongLuu.Id = 4;
            this.btnKhongLuu.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.saveandclose_16x163;
            this.btnKhongLuu.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.saveandclose_32x323;
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhongLuu_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = global::QUANLYNHANSU.Properties.Resources.cancel_16x163;
            this.btnThoat.ImageOptions.LargeImage = global::QUANLYNHANSU.Properties.Resources.cancel_32x324;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1061, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1061, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1061, 44);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtHeSo);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenLoaiCa);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 437);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtHeSo
            // 
            this.txtHeSo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSo.Location = new System.Drawing.Point(691, 40);
            this.txtHeSo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHeSo.Mask = "0.0";
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(137, 36);
            this.txtHeSo.TabIndex = 0;
            // 
            // txtTenLoaiCa
            // 
            this.txtTenLoaiCa.Location = new System.Drawing.Point(378, 43);
            this.txtTenLoaiCa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenLoaiCa.Name = "txtTenLoaiCa";
            this.txtTenLoaiCa.Size = new System.Drawing.Size(146, 28);
            this.txtTenLoaiCa.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(604, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hệ số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(211, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên loại ca";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1061, 326);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ShiftTypeID,
            this.ShiftTypeName,
            this.Coefficinet});
            this.gvDanhSach.DetailHeight = 306;
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // ShiftTypeID
            // 
            this.ShiftTypeID.Caption = "Mã Loại Ca";
            this.ShiftTypeID.FieldName = "ShiftTypeID";
            this.ShiftTypeID.MinWidth = 25;
            this.ShiftTypeID.Name = "ShiftTypeID";
            this.ShiftTypeID.Visible = true;
            this.ShiftTypeID.VisibleIndex = 0;
            this.ShiftTypeID.Width = 61;
            // 
            // ShiftTypeName
            // 
            this.ShiftTypeName.Caption = "Tên Loại Ca";
            this.ShiftTypeName.FieldName = "ShiftTypeName";
            this.ShiftTypeName.MinWidth = 25;
            this.ShiftTypeName.Name = "ShiftTypeName";
            this.ShiftTypeName.Visible = true;
            this.ShiftTypeName.VisibleIndex = 1;
            this.ShiftTypeName.Width = 61;
            // 
            // Coefficinet
            // 
            this.Coefficinet.Caption = "Hệ Số";
            this.Coefficinet.FieldName = "Coefficinet";
            this.Coefficinet.MinWidth = 25;
            this.Coefficinet.Name = "Coefficinet";
            this.Coefficinet.Visible = true;
            this.Coefficinet.VisibleIndex = 2;
            this.Coefficinet.Width = 61;
            // 
            // frmLoaiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1061, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmLoaiCa";
            this.Text = "Loại ca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhuCap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnKhongLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox txtHeSo;
        private System.Windows.Forms.TextBox txtTenLoaiCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ShiftTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn ShiftTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Coefficinet;
    }
}