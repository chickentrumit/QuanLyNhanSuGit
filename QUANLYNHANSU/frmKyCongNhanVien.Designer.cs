namespace QUANLYNHANSU
{
    partial class frmKyCongNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKyCongNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCongChuNhat = new System.Windows.Forms.MaskedTextBox();
            this.txtCongKyNghi = new System.Windows.Forms.MaskedTextBox();
            this.txtNghiKhongPhep = new System.Windows.Forms.MaskedTextBox();
            this.txtNghiCoPhep = new System.Windows.Forms.MaskedTextBox();
            this.cbbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cbbMaKyCong = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeePayperiodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PayPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkdayMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PermittedDayOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnauthorizedDayOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HolidayWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SundayWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNgayLamViec = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgayLamViec);
            this.panel1.Controls.Add(this.txtCongChuNhat);
            this.panel1.Controls.Add(this.txtCongKyNghi);
            this.panel1.Controls.Add(this.txtNghiKhongPhep);
            this.panel1.Controls.Add(this.txtNghiCoPhep);
            this.panel1.Controls.Add(this.cbbMaNhanVien);
            this.panel1.Controls.Add(this.cbbMaKyCong);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 193);
            this.panel1.TabIndex = 0;
            // 
            // txtCongChuNhat
            // 
            this.txtCongChuNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongChuNhat.Location = new System.Drawing.Point(1185, 98);
            this.txtCongChuNhat.Mask = "00.00";
            this.txtCongChuNhat.Name = "txtCongChuNhat";
            this.txtCongChuNhat.Size = new System.Drawing.Size(143, 32);
            this.txtCongChuNhat.TabIndex = 15;
            // 
            // txtCongKyNghi
            // 
            this.txtCongKyNghi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongKyNghi.Location = new System.Drawing.Point(1185, 33);
            this.txtCongKyNghi.Mask = "00.00";
            this.txtCongKyNghi.Name = "txtCongKyNghi";
            this.txtCongKyNghi.Size = new System.Drawing.Size(143, 32);
            this.txtCongKyNghi.TabIndex = 14;
            // 
            // txtNghiKhongPhep
            // 
            this.txtNghiKhongPhep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghiKhongPhep.Location = new System.Drawing.Point(861, 98);
            this.txtNghiKhongPhep.Mask = "00.00";
            this.txtNghiKhongPhep.Name = "txtNghiKhongPhep";
            this.txtNghiKhongPhep.Size = new System.Drawing.Size(143, 32);
            this.txtNghiKhongPhep.TabIndex = 13;
            // 
            // txtNghiCoPhep
            // 
            this.txtNghiCoPhep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghiCoPhep.Location = new System.Drawing.Point(861, 37);
            this.txtNghiCoPhep.Mask = "00.00";
            this.txtNghiCoPhep.Name = "txtNghiCoPhep";
            this.txtNghiCoPhep.Size = new System.Drawing.Size(143, 32);
            this.txtNghiCoPhep.TabIndex = 12;
            // 
            // cbbMaNhanVien
            // 
            this.cbbMaNhanVien.FormattingEnabled = true;
            this.cbbMaNhanVien.Location = new System.Drawing.Point(166, 101);
            this.cbbMaNhanVien.Name = "cbbMaNhanVien";
            this.cbbMaNhanVien.Size = new System.Drawing.Size(168, 29);
            this.cbbMaNhanVien.TabIndex = 11;
            this.cbbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbb_manhanvien_SelectedIndexChanged);
            // 
            // cbbMaKyCong
            // 
            this.cbbMaKyCong.FormattingEnabled = true;
            this.cbbMaKyCong.Location = new System.Drawing.Point(166, 33);
            this.cbbMaKyCong.Name = "cbbMaKyCong";
            this.cbbMaKyCong.Size = new System.Drawing.Size(168, 29);
            this.cbbMaKyCong.TabIndex = 10;
            this.cbbMaKyCong.SelectedIndexChanged += new System.EventHandler(this.cbbMaKyCong_SelectedIndexChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(525, 36);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(155, 28);
            this.txtTenNhanVien.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1039, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Công Chủ Nhật";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1051, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Công Kỳ Nghỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nghỉ Không Phép";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nghỉ Có Phép";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Làm Việc/tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Kỳ Công";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1561, 76);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 623);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1561, 33);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 76);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1561, 76);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcDanhSach);
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1549, 411);
            this.panel2.TabIndex = 5;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(3, 3);
            this.gcDanhSach.MainView = this.gridView1;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1543, 408);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeePayperiodID,
            this.PayPeriodID,
            this.EmployeeID,
            this.FullName,
            this.WorkdayMonth,
            this.PermittedDayOff,
            this.UnauthorizedDayOff,
            this.HolidayWork,
            this.SundayWork});
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // EmployeePayperiodID
            // 
            this.EmployeePayperiodID.Caption = "Mã Kỳ Công Nhân Viên";
            this.EmployeePayperiodID.FieldName = "EmployeePayperiodID";
            this.EmployeePayperiodID.MinWidth = 25;
            this.EmployeePayperiodID.Name = "EmployeePayperiodID";
            this.EmployeePayperiodID.Visible = true;
            this.EmployeePayperiodID.VisibleIndex = 0;
            this.EmployeePayperiodID.Width = 167;
            // 
            // PayPeriodID
            // 
            this.PayPeriodID.Caption = "Mã Kỳ Công";
            this.PayPeriodID.FieldName = "PayPeriodID";
            this.PayPeriodID.MinWidth = 25;
            this.PayPeriodID.Name = "PayPeriodID";
            this.PayPeriodID.Visible = true;
            this.PayPeriodID.VisibleIndex = 1;
            this.PayPeriodID.Width = 167;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Mã Nhân Viên";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 25;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 2;
            this.EmployeeID.Width = 167;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên Nhân Viên";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 25;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 3;
            this.FullName.Width = 167;
            // 
            // WorkdayMonth
            // 
            this.WorkdayMonth.Caption = "Ngày Làm Việc Trong Tháng";
            this.WorkdayMonth.FieldName = "WorkdayMonth";
            this.WorkdayMonth.MinWidth = 25;
            this.WorkdayMonth.Name = "WorkdayMonth";
            this.WorkdayMonth.Visible = true;
            this.WorkdayMonth.VisibleIndex = 4;
            this.WorkdayMonth.Width = 238;
            // 
            // PermittedDayOff
            // 
            this.PermittedDayOff.Caption = "Nghỉ Có Phép";
            this.PermittedDayOff.FieldName = "PermittedDayOff";
            this.PermittedDayOff.MinWidth = 25;
            this.PermittedDayOff.Name = "PermittedDayOff";
            this.PermittedDayOff.Visible = true;
            this.PermittedDayOff.VisibleIndex = 5;
            this.PermittedDayOff.Width = 147;
            // 
            // UnauthorizedDayOff
            // 
            this.UnauthorizedDayOff.Caption = "Nghỉ Không Phép";
            this.UnauthorizedDayOff.FieldName = "UnauthorizedDayOff";
            this.UnauthorizedDayOff.MinWidth = 25;
            this.UnauthorizedDayOff.Name = "UnauthorizedDayOff";
            this.UnauthorizedDayOff.Visible = true;
            this.UnauthorizedDayOff.VisibleIndex = 6;
            this.UnauthorizedDayOff.Width = 147;
            // 
            // HolidayWork
            // 
            this.HolidayWork.Caption = "Công Kỳ Nghỉ";
            this.HolidayWork.FieldName = "HolidayWork";
            this.HolidayWork.MinWidth = 25;
            this.HolidayWork.Name = "HolidayWork";
            this.HolidayWork.Visible = true;
            this.HolidayWork.VisibleIndex = 7;
            this.HolidayWork.Width = 147;
            // 
            // SundayWork
            // 
            this.SundayWork.Caption = "Công Chủ Nhật";
            this.SundayWork.FieldName = "SundayWork";
            this.SundayWork.MinWidth = 25;
            this.SundayWork.Name = "SundayWork";
            this.SundayWork.Visible = true;
            this.SundayWork.VisibleIndex = 8;
            this.SundayWork.Width = 161;
            // 
            // txtNgayLamViec
            // 
            this.txtNgayLamViec.Location = new System.Drawing.Point(526, 107);
            this.txtNgayLamViec.Name = "txtNgayLamViec";
            this.txtNgayLamViec.Size = new System.Drawing.Size(154, 28);
            this.txtNgayLamViec.TabIndex = 16;
            // 
            // frmKyCongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKyCongNhanVien";
            this.Text = "frmKyCongNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKyLuatNhanVien_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnKhongLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaNhanVien;
        private System.Windows.Forms.ComboBox cbbMaKyCong;
        private System.Windows.Forms.MaskedTextBox txtCongChuNhat;
        private System.Windows.Forms.MaskedTextBox txtCongKyNghi;
        private System.Windows.Forms.MaskedTextBox txtNghiKhongPhep;
        private System.Windows.Forms.MaskedTextBox txtNghiCoPhep;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeePayperiodID;
        private DevExpress.XtraGrid.Columns.GridColumn PayPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn WorkdayMonth;
        private DevExpress.XtraGrid.Columns.GridColumn PermittedDayOff;
        private DevExpress.XtraGrid.Columns.GridColumn UnauthorizedDayOff;
        private DevExpress.XtraGrid.Columns.GridColumn HolidayWork;
        private DevExpress.XtraGrid.Columns.GridColumn SundayWork;
        private System.Windows.Forms.TextBox txtNgayLamViec;
    }
}