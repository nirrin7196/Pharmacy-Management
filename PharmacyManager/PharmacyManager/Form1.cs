﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraTab;
using KaraokeManager.Utilities;

namespace PharmacyManager
{

    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_THUOC tv = new BUS_THUOC();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string t="")
        {
            InitializeComponent();
            lbl_name.Caption = t;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào gridControl
            //BindingSource bs = new BindingSource();
            //tv.Get_THUOC();
            //bs.DataSource = tv.Get_THUOC().Tables["THUOC"];
            //grid_a.DataSource = bs;
            UserControlMain.DonBanThuoc ucDonBanThuoc = new UserControlMain.DonBanThuoc();
            addTabControl(ucDonBanThuoc, "Đơn Bán Thuốc", "close");


            //Size mysize = new System.Drawing.Size(20, 20);
            //Bitmap bt = new Bitmap(Properties.Resources.close);
            //Bitmap btm = new Bitmap(bt, mysize);
            //closeImageAct = btm;
            ////
            ////
            //Bitmap bt2 = new Bitmap(Properties.Resources.closeBlack);
            //Bitmap btm2 = new Bitmap(bt2, mysize);
            //closeImage = btm2;
            //menu.Padding = new Point(30);
            //menu.TabPages.Remove(tab_dsdonthuoc);
            //menu.TabPages.Remove(tab_baocaohang);
            //menu.TabPages.Remove(tab_kho);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDonBanThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.DonBanThuoc ucDonBanThuoc = new UserControlMain.DonBanThuoc();
            addTabControl(ucDonBanThuoc, "Đơn Bán Thuốc", "close");
        }

        private void btnDanhSachDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (menu.TabPages.Contains(tab_baocaohang) == false)
            //    menu.TabPages.Add(tab_baocaohang);
            //menu.SelectedTab = tab_baocaohang;
        }

        private void menu_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Rectangle rect = menu.GetTabRect(e.Index);
            //Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
            //rect.Size = new Size(rect.Width + 20, 10);

            //Font f;
            //Brush br = Brushes.Black;
            //StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            //if (menu.SelectedTab == menu.TabPages[e.Index])
            //{
            //    e.Graphics.DrawImage(closeImageAct, imageRec);
            //    f = new Font("Arial", 10, FontStyle.Bold);
            //    e.Graphics.DrawString(menu.TabPages[e.Index].Text,
            //        f, br, rect, strF);
            //}
            //else
            //{
            //    e.Graphics.DrawImage(closeImage, imageRec);
            //    f = new Font("Arial", 9, FontStyle.Regular);
            //    e.Graphics.DrawString(menu.TabPages[e.Index].Text,
            //        f, br, rect, strF);
            //}
        }

        private void tab_DonBan_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void menu_MouseClick(object sender, MouseEventArgs e)
        {
            //for (int i = 0; i < menu.TabCount; i++)
            //{
            //    Rectangle rect = menu.GetTabRect(i);
            //    Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
            //        rect.Top + (rect.Height - closeImage.Height) / 2,
            //        closeImage.Width, closeImage.Height);

            //    if (imageRec.Contains(e.Location))
            //        menu.TabPages.Remove(menu.SelectedTab);

            //}
        }

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.Kho ucKho = new UserControlMain.Kho();
            addTabControl(ucKho, "Kho", "close");
        }

        private void menu_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControlMain.TabPages.RemoveAt(xtraTabControlMain.SelectedTabPageIndex);
            xtraTabControlMain.SelectedTabPageIndex = xtraTabControlMain.TabPages.Count - 1;
        }

        private void addTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool isExist = false;

            foreach (XtraTabPage tabItem in xtraTabControlMain.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExist = true;
                    xtraTabControlMain.SelectedTabPage = tabItem;
                }
            }

            if (isExist == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(xtraTabControlMain, itemTabName, icon, userControl);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKiemKeLo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.KiemKeTheoLo ucKiemKeLo = new UserControlMain.KiemKeTheoLo();
            addTabControl(ucKiemKeLo, "Kiểm kê theo lô", "close.png");
        }

        private void btnNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.NhapKho ucNhapKho = new UserControlMain.NhapKho();
            addTabControl(ucNhapKho, "Nhập Kho", "close.png");
        }

        private void btnDanhMucNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.NhaCungCap ucNcc = new UserControlMain.NhaCungCap();
            addTabControl(ucNcc, "Nha Cung Cấp", "close.png");
        }

        private void btnInTemBarCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.TaoBarCode barcode = new UserControlMain.TaoBarCode();
            addTabControl(barcode, "Tạo BarCode", "close.png");
        }

        private void btn_BaoCaoBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.BaoCaoBanHang bcBanHang = new UserControlMain.BaoCaoBanHang();
            addTabControl(bcBanHang, "Báo Cáo Bán Hàng", "close.png");
        }

        private void btnBangGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.BangGiaThuoc BangGia = new UserControlMain.BangGiaThuoc();
            addTabControl(BangGia, "Bảng Giá Thuốc", "close.png");
        }

        private void btnDanhMucHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //UserControlMain.ThemThuocMoi ThuocMoi = new UserControlMain.ThemThuocMoi();
            //addTabControl(ThuocMoi, "Danh Mục Hàng", "close");
            UserControlMain.DanhMucHang danhMucHang = new UserControlMain.DanhMucHang();
            addTabControl(danhMucHang, "Danh Mục Hàng", "close.png");
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.TraThuocHetHan ThuocMoi = new UserControlMain.TraThuocHetHan();
            addTabControl(ThuocMoi, "Trả Thuốc Hết Hạn", "close");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
