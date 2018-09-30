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
            this.menu = new System.Windows.Forms.TabControl();
            this.tab_DonBan = new System.Windows.Forms.TabPage();
            this.tab_dsdonthuoc = new System.Windows.Forms.TabPage();
            this.tab_baocaohang = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.menu.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1376, 157);
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
            this.btnTonKho.Caption = "Tồn Kho";
            this.btnTonKho.Id = 6;
            this.btnTonKho.ImageOptions.LargeImage = global::PharmacyManager.Properties.Resources.ic_storage;
            this.btnTonKho.Name = "btnTonKho";
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
            // menu
            // 
            this.menu.Controls.Add(this.tab_DonBan);
            this.menu.Controls.Add(this.tab_dsdonthuoc);
            this.menu.Controls.Add(this.tab_baocaohang);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 157);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1376, 626);
            this.menu.TabIndex = 3;
            this.menu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_DrawItem);
            this.menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // tab_DonBan
            // 
            this.tab_DonBan.Location = new System.Drawing.Point(4, 28);
            this.tab_DonBan.Name = "tab_DonBan";
            this.tab_DonBan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DonBan.Size = new System.Drawing.Size(1368, 594);
            this.tab_DonBan.TabIndex = 0;
            this.tab_DonBan.Text = "Đơn Bán Thuốc";
            this.tab_DonBan.UseVisualStyleBackColor = true;
            this.tab_DonBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_DonBan_MouseClick);
            // 
            // tab_dsdonthuoc
            // 
            this.tab_dsdonthuoc.Location = new System.Drawing.Point(4, 28);
            this.tab_dsdonthuoc.Name = "tab_dsdonthuoc";
            this.tab_dsdonthuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dsdonthuoc.Size = new System.Drawing.Size(1368, 594);
            this.tab_dsdonthuoc.TabIndex = 1;
            this.tab_dsdonthuoc.Text = "Danh Sách Đơn Thuốc";
            this.tab_dsdonthuoc.UseVisualStyleBackColor = true;
            // 
            // tab_baocaohang
            // 
            this.tab_baocaohang.Location = new System.Drawing.Point(4, 28);
            this.tab_baocaohang.Name = "tab_baocaohang";
            this.tab_baocaohang.Padding = new System.Windows.Forms.Padding(3);
            this.tab_baocaohang.Size = new System.Drawing.Size(1368, 594);
            this.tab_baocaohang.TabIndex = 2;
            this.tab_baocaohang.Text = "Báo Cáo Bán Hàng";
            this.tab_baocaohang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 783);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Nhà Thuốc Tây";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.menu.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage tab_DonBan;
        private System.Windows.Forms.TabPage tab_dsdonthuoc;
        private System.Windows.Forms.TabPage tab_baocaohang;
    }
}

