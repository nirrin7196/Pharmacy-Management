namespace PharmacyManager
{
    partial class Form1
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDonBanThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnKiemKeLo = new DevExpress.XtraBars.BarButtonItem();
            this.btnKiemKeSoLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapTonDauKi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInTemBarCode = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnLieuThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhGiaVon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.homeTab = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDonBanThuoc,
            this.btnDanhSachDon,
            this.barButtonItem1,
            this.btnNhapKho,
            this.btnXuatKho,
            this.btnTonKho,
            this.btnKiemKeLo,
            this.btnKiemKeSoLuong,
            this.btnNhapTonDauKi,
            this.btnInTemBarCode,
            this.btnDanhMucHang,
            this.btnBangGia,
            this.btnDanhMucNhaCungCap,
            this.btnHuyDonHang,
            this.btnLieuThuoc,
            this.btnTinhGiaVon,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnDoiMatKhau,
            this.btnThoat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeTab});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1376, 196);
            // 
            // btnDonBanThuoc
            // 
            this.btnDonBanThuoc.Caption = "Đơn Bán Thuốc";
            this.btnDonBanThuoc.Id = 1;
            this.btnDonBanThuoc.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_don_thuoc;
            this.btnDonBanThuoc.Name = "btnDonBanThuoc";
            this.btnDonBanThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonBanThuoc_ItemClick);
            // 
            // btnDanhSachDon
            // 
            this.btnDanhSachDon.Caption = "Danh sách đơn thuốc";
            this.btnDanhSachDon.Id = 2;
            this.btnDanhSachDon.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_danh_sach_don;
            this.btnDanhSachDon.Name = "btnDanhSachDon";
            this.btnDanhSachDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachDon_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Báo cáo bán hàng";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_bao_cao_ban_hang;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Caption = "Nhập kho";
            this.btnNhapKho.Id = 4;
            this.btnNhapKho.Name = "btnNhapKho";
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Caption = "Xuất kho";
            this.btnXuatKho.Id = 5;
            this.btnXuatKho.Name = "btnXuatKho";
            // 
            // btnTonKho
            // 
            this.btnTonKho.Caption = "Kho";
            this.btnTonKho.Id = 6;
            this.btnTonKho.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_storage;
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonKho_ItemClick);
            // 
            // btnKiemKeLo
            // 
            this.btnKiemKeLo.Caption = "Kiểm Khê Theo Lô";
            this.btnKiemKeLo.Id = 7;
            this.btnKiemKeLo.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_kiem_ke_lo;
            this.btnKiemKeLo.Name = "btnKiemKeLo";
            // 
            // btnKiemKeSoLuong
            // 
            this.btnKiemKeSoLuong.Caption = "Kiểm Kê Theo Số Lượng";
            this.btnKiemKeSoLuong.Id = 8;
            this.btnKiemKeSoLuong.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_kiem_ke;
            this.btnKiemKeSoLuong.Name = "btnKiemKeSoLuong";
            // 
            // btnNhapTonDauKi
            // 
            this.btnNhapTonDauKi.Caption = "Nhập Tồn Đầu Kì";
            this.btnNhapTonDauKi.Id = 9;
            this.btnNhapTonDauKi.Name = "btnNhapTonDauKi";
            // 
            // btnInTemBarCode
            // 
            this.btnInTemBarCode.Caption = "In Tem Barcode";
            this.btnInTemBarCode.Id = 10;
            this.btnInTemBarCode.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_tem_barcode;
            this.btnInTemBarCode.Name = "btnInTemBarCode";
            // 
            // btnDanhMucHang
            // 
            this.btnDanhMucHang.Caption = "Danh Mục Hàng";
            this.btnDanhMucHang.Id = 11;
            this.btnDanhMucHang.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_danh_muc_hang;
            this.btnDanhMucHang.Name = "btnDanhMucHang";
            // 
            // btnBangGia
            // 
            this.btnBangGia.Caption = "Bảng Giá";
            this.btnBangGia.Id = 12;
            this.btnBangGia.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_bang_gia;
            this.btnBangGia.Name = "btnBangGia";
            // 
            // btnDanhMucNhaCungCap
            // 
            this.btnDanhMucNhaCungCap.Caption = "Danh mục Nhà CC";
            this.btnDanhMucNhaCungCap.Id = 13;
            this.btnDanhMucNhaCungCap.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_danh_muc_nha_cc;
            this.btnDanhMucNhaCungCap.Name = "btnDanhMucNhaCungCap";
            // 
            // btnHuyDonHang
            // 
            this.btnHuyDonHang.Caption = "Hủy Đơn Hàng";
            this.btnHuyDonHang.Id = 14;
            this.btnHuyDonHang.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_huy_don_hang;
            this.btnHuyDonHang.Name = "btnHuyDonHang";
            // 
            // btnLieuThuoc
            // 
            this.btnLieuThuoc.Caption = "Liều Thuốc";
            this.btnLieuThuoc.Id = 15;
            this.btnLieuThuoc.Name = "btnLieuThuoc";
            // 
            // btnTinhGiaVon
            // 
            this.btnTinhGiaVon.Caption = "Tính Giá Vốn";
            this.btnTinhGiaVon.Id = 16;
            this.btnTinhGiaVon.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_tinh_gia_von;
            this.btnTinhGiaVon.Name = "btnTinhGiaVon";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Báo Cáo Kho Hàng";
            this.barButtonItem3.Id = 18;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 19;
            this.btnDoiMatKhau.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_doi_mat_khau;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_thoat;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // homeTab
            // 
            this.homeTab.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.homeTab.Name = "homeTab";
            this.homeTab.Text = "Trang Chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDonBanThuoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDanhSachDon);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bán Hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapKho);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXuatKho);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonKho);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKiemKeLo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKiemKeSoLuong);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapTonDauKi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thủ Kho";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnInTemBarCode);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhMucHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangGia);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhMucNhaCungCap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHuyDonHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLieuThuoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTinhGiaVon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản Lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo Cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Hệ Thống";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControlMain.Appearance.Options.UseBackColor = true;
            this.xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControlMain.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton()});
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 196);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
            this.xtraTabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControlMain.Size = new System.Drawing.Size(1376, 587);
            this.xtraTabControlMain.TabIndex = 5;
            this.xtraTabControlMain.CloseButtonClick += new System.EventHandler(this.xtraTabControlMain_CloseButtonClick);
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 783);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Nhà Thuốc Tây";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeTab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDonBanThuoc;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachDon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnNhapKho;
        private DevExpress.XtraBars.BarButtonItem btnXuatKho;
        private DevExpress.XtraBars.BarButtonItem btnTonKho;
        private DevExpress.XtraBars.BarButtonItem btnKiemKeLo;
        private DevExpress.XtraBars.BarButtonItem btnKiemKeSoLuong;
        private DevExpress.XtraBars.BarButtonItem btnNhapTonDauKi;
        private DevExpress.XtraBars.BarButtonItem btnInTemBarCode;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucHang;
        private DevExpress.XtraBars.BarButtonItem btnBangGia;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucNhaCungCap;
        private DevExpress.XtraBars.BarButtonItem btnHuyDonHang;
        private DevExpress.XtraBars.BarButtonItem btnLieuThuoc;
        private DevExpress.XtraBars.BarButtonItem btnTinhGiaVon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
    }
}

