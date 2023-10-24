namespace QUANLYNHANSU
{
    partial class frmThoiViecNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoiViecNhanVien));
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
            this.cbbKey = new System.Windows.Forms.CheckBox();
            this.dt_NgayNopDon = new System.Windows.Forms.DateTimePicker();
            this.dt_NgayNghiViec = new System.Windows.Forms.DateTimePicker();
            this.cbb_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.txt_LyDo = new System.Windows.Forms.TextBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaThoiViec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ResignationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResignationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KeyResiqnation = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1532, 76);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1532, 33);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 76);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1532, 76);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbKey);
            this.panel1.Controls.Add(this.dt_NgayNopDon);
            this.panel1.Controls.Add(this.dt_NgayNghiViec);
            this.panel1.Controls.Add(this.cbb_MaNhanVien);
            this.panel1.Controls.Add(this.txt_LyDo);
            this.panel1.Controls.Add(this.txt_TenNhanVien);
            this.panel1.Controls.Add(this.txt_MaThoiViec);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 178);
            this.panel1.TabIndex = 4;
            // 
            // cbbKey
            // 
            this.cbbKey.AutoSize = true;
            this.cbbKey.Location = new System.Drawing.Point(1316, 70);
            this.cbbKey.Name = "cbbKey";
            this.cbbKey.Size = new System.Drawing.Size(147, 25);
            this.cbbKey.TabIndex = 13;
            this.cbbKey.Text = "Khóa Thôi Việc ";
            this.cbbKey.UseVisualStyleBackColor = true;
            // 
            // dt_NgayNopDon
            // 
            this.dt_NgayNopDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayNopDon.Location = new System.Drawing.Point(610, 104);
            this.dt_NgayNopDon.Name = "dt_NgayNopDon";
            this.dt_NgayNopDon.Size = new System.Drawing.Size(179, 28);
            this.dt_NgayNopDon.TabIndex = 12;
            // 
            // dt_NgayNghiViec
            // 
            this.dt_NgayNghiViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayNghiViec.Location = new System.Drawing.Point(989, 108);
            this.dt_NgayNghiViec.Name = "dt_NgayNghiViec";
            this.dt_NgayNghiViec.Size = new System.Drawing.Size(278, 28);
            this.dt_NgayNghiViec.TabIndex = 11;
            // 
            // cbb_MaNhanVien
            // 
            this.cbb_MaNhanVien.FormattingEnabled = true;
            this.cbb_MaNhanVien.Location = new System.Drawing.Point(203, 100);
            this.cbb_MaNhanVien.Name = "cbb_MaNhanVien";
            this.cbb_MaNhanVien.Size = new System.Drawing.Size(203, 29);
            this.cbb_MaNhanVien.TabIndex = 9;
            this.cbb_MaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbb_manhanvien_SelectedIndexChanged);
            // 
            // txt_LyDo
            // 
            this.txt_LyDo.Location = new System.Drawing.Point(989, 40);
            this.txt_LyDo.Name = "txt_LyDo";
            this.txt_LyDo.Size = new System.Drawing.Size(278, 28);
            this.txt_LyDo.TabIndex = 8;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(610, 33);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(179, 28);
            this.txt_TenNhanVien.TabIndex = 7;
            // 
            // txt_MaThoiViec
            // 
            this.txt_MaThoiViec.Location = new System.Drawing.Point(203, 36);
            this.txt_MaThoiViec.Name = "txt_MaThoiViec";
            this.txt_MaThoiViec.Size = new System.Drawing.Size(203, 28);
            this.txt_MaThoiViec.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(834, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Nghỉ việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(901, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nộp Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thôi Việc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcDanhSach);
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1532, 418);
            this.panel2.TabIndex = 5;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gridView1;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1529, 363);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ResignationID,
            this.EmployeeID,
            this.FullName,
            this.ResignationDate,
            this.EndDate,
            this.Note,
            this.KeyResiqnation});
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // ResignationID
            // 
            this.ResignationID.Caption = "Mã Thôi Việc";
            this.ResignationID.FieldName = "ResignationID";
            this.ResignationID.MinWidth = 25;
            this.ResignationID.Name = "ResignationID";
            this.ResignationID.Visible = true;
            this.ResignationID.VisibleIndex = 0;
            this.ResignationID.Width = 94;
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
            // ResignationDate
            // 
            this.ResignationDate.Caption = "Thời gian thôi việc";
            this.ResignationDate.FieldName = "ResignationDate";
            this.ResignationDate.MinWidth = 25;
            this.ResignationDate.Name = "ResignationDate";
            this.ResignationDate.Visible = true;
            this.ResignationDate.VisibleIndex = 3;
            this.ResignationDate.Width = 94;
            // 
            // EndDate
            // 
            this.EndDate.Caption = "thời gian kết thúc";
            this.EndDate.FieldName = "EndDate";
            this.EndDate.MinWidth = 25;
            this.EndDate.Name = "EndDate";
            this.EndDate.Visible = true;
            this.EndDate.VisibleIndex = 4;
            this.EndDate.Width = 94;
            // 
            // Note
            // 
            this.Note.Caption = "Ghi Chú";
            this.Note.FieldName = "Note";
            this.Note.MinWidth = 25;
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 5;
            this.Note.Width = 94;
            // 
            // KeyResiqnation
            // 
            this.KeyResiqnation.Caption = "Khóa Thôi Việc";
            this.KeyResiqnation.FieldName = "KeyResiqnation";
            this.KeyResiqnation.MinWidth = 25;
            this.KeyResiqnation.Name = "KeyResiqnation";
            this.KeyResiqnation.Visible = true;
            this.KeyResiqnation.VisibleIndex = 6;
            this.KeyResiqnation.Width = 94;
            // 
            // frmThoiViecNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThoiViecNhanVien";
            this.Text = "frmThoiViecNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmthoiviecnhanvien_FormClosing);
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
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_MaNhanVien;
        private System.Windows.Forms.TextBox txt_LyDo;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_MaThoiViec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_NgayNopDon;
        private System.Windows.Forms.DateTimePicker dt_NgayNghiViec;
        private DevExpress.XtraGrid.Columns.GridColumn ResignationID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn ResignationDate;
        private DevExpress.XtraGrid.Columns.GridColumn EndDate;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private System.Windows.Forms.CheckBox cbbKey;
        private DevExpress.XtraGrid.Columns.GridColumn KeyResiqnation;
    }
}