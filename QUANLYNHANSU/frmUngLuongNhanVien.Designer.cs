namespace QUANLYNHANSU
{
    partial class frmUngLuongNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUngLuongNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhongLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_SoTienTamUng = new System.Windows.Forms.TextBox();
            this.cbb_MaKyCong = new System.Windows.Forms.ComboBox();
            this.cbb_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SalaryAdvanceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PayPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdvanceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
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
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKhongLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Caption = "Không Lưu";
            this.btnKhongLuu.Id = 4;
            this.btnKhongLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhongLuu.ImageOptions.Image")));
            this.btnKhongLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhongLuu.ImageOptions.LargeImage")));
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhongLuu_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1494, 76);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1494, 33);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 76);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1494, 76);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_SoTienTamUng);
            this.panel1.Controls.Add(this.cbb_MaKyCong);
            this.panel1.Controls.Add(this.cbb_MaNhanVien);
            this.panel1.Controls.Add(this.txt_TenNhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 191);
            this.panel1.TabIndex = 4;
            // 
            // txt_SoTienTamUng
            // 
            this.txt_SoTienTamUng.Location = new System.Drawing.Point(743, 93);
            this.txt_SoTienTamUng.Name = "txt_SoTienTamUng";
            this.txt_SoTienTamUng.Size = new System.Drawing.Size(236, 28);
            this.txt_SoTienTamUng.TabIndex = 10;
            // 
            // cbb_MaKyCong
            // 
            this.cbb_MaKyCong.FormattingEnabled = true;
            this.cbb_MaKyCong.Location = new System.Drawing.Point(743, 22);
            this.cbb_MaKyCong.Name = "cbb_MaKyCong";
            this.cbb_MaKyCong.Size = new System.Drawing.Size(236, 29);
            this.cbb_MaKyCong.TabIndex = 9;
            // 
            // cbb_MaNhanVien
            // 
            this.cbb_MaNhanVien.FormattingEnabled = true;
            this.cbb_MaNhanVien.Location = new System.Drawing.Point(234, 22);
            this.cbb_MaNhanVien.Name = "cbb_MaNhanVien";
            this.cbb_MaNhanVien.Size = new System.Drawing.Size(267, 29);
            this.cbb_MaNhanVien.TabIndex = 8;
            this.cbb_MaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbb_manhanvien_SelectedIndexChanged);
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(234, 93);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(267, 28);
            this.txt_TenNhanVien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Tiền Tạm Ứng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Kỳ Công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcDanhSach);
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1494, 381);
            this.panel2.TabIndex = 5;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(0, 3);
            this.gcDanhSach.MainView = this.gridView1;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1491, 378);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SalaryAdvanceID,
            this.EmployeeID,
            this.FullName,
            this.PayPeriodID,
            this.AdvanceAmount});
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // SalaryAdvanceID
            // 
            this.SalaryAdvanceID.Caption = "Mã Ứng Lương";
            this.SalaryAdvanceID.FieldName = "SalaryAdvanceID";
            this.SalaryAdvanceID.MinWidth = 25;
            this.SalaryAdvanceID.Name = "SalaryAdvanceID";
            this.SalaryAdvanceID.Visible = true;
            this.SalaryAdvanceID.VisibleIndex = 0;
            this.SalaryAdvanceID.Width = 94;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Mã Nhân Viên";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 25;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 1;
            this.EmployeeID.Width = 94;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên Nhân Viên";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 25;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 2;
            this.FullName.Width = 94;
            // 
            // PayPeriodID
            // 
            this.PayPeriodID.Caption = "Mã Kỳ Công";
            this.PayPeriodID.FieldName = "PayPeriodID";
            this.PayPeriodID.MinWidth = 25;
            this.PayPeriodID.Name = "PayPeriodID";
            this.PayPeriodID.Visible = true;
            this.PayPeriodID.VisibleIndex = 3;
            this.PayPeriodID.Width = 94;
            // 
            // AdvanceAmount
            // 
            this.AdvanceAmount.Caption = "Số tiền ứng lương";
            this.AdvanceAmount.FieldName = "AdvanceAmount";
            this.AdvanceAmount.MinWidth = 25;
            this.AdvanceAmount.Name = "AdvanceAmount";
            this.AdvanceAmount.Visible = true;
            this.AdvanceAmount.VisibleIndex = 4;
            this.AdvanceAmount.Width = 94;
            // 
            // frmUngLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmUngLuongNhanVien";
            this.Text = "frmUngLuongNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhenThuongNhanVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnKhongLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoTienTamUng;
        private System.Windows.Forms.ComboBox cbb_MaKyCong;
        private System.Windows.Forms.ComboBox cbb_MaNhanVien;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryAdvanceID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn PayPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn AdvanceAmount;
    }
}