using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class ThemThuocMoi : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_THUOC t = new BUS_THUOC();
        public ThemThuocMoi()
        {
            InitializeComponent();
        }

        private void ThemThuocMoi_Load(object sender, EventArgs e)
        {
            for(int i=1;i<21;i++)
            {
                cbb_SoLuongVienMoiVi.Items.Add(i);
            }
            for (int i = 1; i <= 5; i++)
            {
                cbb_NamSuDung.Items.Add(i);
            }
            for (int i = 0; i <= 12; i++)
            {
                cbb_thangSuDung.Items.Add(i);
            }
            txt_MaThuoc.Text = t.TaoMaThuoc();
            cbb_SoLuongVienMoiVi.SelectedIndex = 9;
            cbb_thangSuDung.SelectedIndex = 0;
            cbb_LoaiThuoc.SelectedIndex = 0;
            cbb_NamSuDung.SelectedIndex = 0;
            txt_SoLuongMoiHop.Text = "100";
        }

        private void cbb_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_LoaiThuoc.SelectedIndex==0)
            {
                cbb_SoLuongVienMoiVi.Visible = true;
                txt_GiaMoiVi.Visible = true;
                lbl_Vi.Visible = true;
            }
            if (cbb_LoaiThuoc.SelectedIndex == 1)
            {
                cbb_SoLuongVienMoiVi.Visible = false;
                txt_GiaMoiVi.Visible = false;
                lbl_Vi.Visible = false;
            }
        }
        double MaxLoiNhuan(double a)
        {
            double t=0;
            if (a <= 1000)
                t = 1.15;
            else if (a <= 5000)
                t = 1.1;
            else if (a < 100000)
                t = 1.07;
            else if (a < 1000000)
                t = 1.05;
            else
                t = 1.02;
            return t;

        }
        void GoiYGia()
        {
            try
            {
                int giaSauThue = int.Parse(txt_GiaSauThue.Text);
                int slHop = int.Parse(txt_SoLuongMoiHop.Text);

                if (cbb_LoaiThuoc.SelectedIndex == 0)
                {
                    double GiaCoSo = (double)giaSauThue / (double)slHop;
                    txt_GiaMoiVien.Text = ((int)(GiaCoSo * MaxLoiNhuan(GiaCoSo))).ToString();
                    txt_GiaHop.Text = ((int)((double)giaSauThue * MaxLoiNhuan(GiaCoSo))).ToString();
                    int t = int.Parse(cbb_SoLuongVienMoiVi.SelectedIndex.ToString()) + 1;
                    txt_GiaMoiVi.Text = ((int)(GiaCoSo * MaxLoiNhuan(GiaCoSo) * t)).ToString();
                }
                if (cbb_LoaiThuoc.SelectedIndex == 1)
                {
                    double GiaCoSo = (double)giaSauThue / (double)slHop;
                    txt_GiaMoiVien.Text = ((int)(GiaCoSo * MaxLoiNhuan(GiaCoSo))).ToString();
                    txt_GiaHop.Text = ((int)((double)giaSauThue * MaxLoiNhuan(GiaCoSo))).ToString();
                }
            }
            catch
            {

            }
        }
        private void txt_GiaSauThue_KeyUp(object sender, KeyEventArgs e)
        {
            GoiYGia();
        }

        private void txt_SoLuongMoiHop_KeyUp(object sender, KeyEventArgs e)
        {
            GoiYGia();
        }

        private void cbb_SoLuongVienMoiVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoiYGia();
        }

        private void btn_NhapThuoc_Click(object sender, EventArgs e)
        {
            string MaThuoc = txt_MaThuoc.Text;
            string TenThuoc = txt_TenThuoc.Text;
            string HoatChat = txt_HoatChat.Text;
            int GiaNhap = int.Parse(txt_GiaNhap.Text);
            int GiaSauThue = int.Parse(txt_GiaSauThue.Text);
            int GiaBan = int.Parse(txt_GiaHop.Text);
            int NamSuDung = int.Parse(cbb_NamSuDung.SelectedIndex.ToString()) + 1;
            int thangSuDung = int.Parse(cbb_thangSuDung.SelectedIndex.ToString());
            int Hop = int.Parse(txt_SoLuongMoiHop.Text);
            int Vien=0;
            int GiaVien=0;
            int Vi=0;
            int GiaVi=0;
            int Goi=0;
            int GiaGoi=0;

            if (cbb_LoaiThuoc.SelectedIndex == 0)
            {
                Vien=1;
                GiaVien = int.Parse(txt_GiaMoiVien.Text);
                Vi = int.Parse(cbb_SoLuongVienMoiVi.SelectedIndex.ToString()) + 1;
                GiaVi=int.Parse(txt_GiaMoiVi.Text);
                Goi = 0;
                GiaGoi = 0;

            }
            if (cbb_LoaiThuoc.SelectedIndex == 1)
            {
                Goi=1;
                GiaGoi= int.Parse(txt_GiaMoiVien.Text);
                Vien = 0;
                GiaVien = 0;
                Vi = 0;
                GiaVi = 0;
            }
            string ThoiHanSuDung = NamSuDung.ToString() + "." + thangSuDung.ToString();
            t.NhapThuocMoi(MaThuoc, TenThuoc, HoatChat, GiaNhap, GiaSauThue, GiaBan, ThoiHanSuDung, Hop, Vi, GiaVi, Goi, GiaGoi, Vien, GiaVien);


        }
    }
}
