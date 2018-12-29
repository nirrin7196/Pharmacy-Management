using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class BaoCaoBanHang : UserControl
    {
        BUS_DonBan db = new BUS_DonBan();
        BUS_DuocSy ds = new BUS_DuocSy();
        public BaoCaoBanHang()
        {
            InitializeComponent();
        }
        DateTime now = DateTime.Now;
        private void grid_baoCaoBanHang_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            db.Get_ThongKeBan();
            bs.DataSource = db.Get_ThongKeBan().Tables["DONBAN"];
            grid_baoCaoBanHang.DataSource = bs;

            //lbl_GiaSauThue.Text = db.Get_AllDoanhThu().Rows[0]["GiaSauThue"].ToString();
            //lbl_GiaBan.Text = db.Get_AllDoanhThu().Rows[0]["GiaBan"].ToString();
            //lbl_AllLai.Text = db.Get_AllDoanhThu().Rows[0]["TienLai"].ToString();
            addItem();
            cbb_DuocSy.Items.Add("*Tất cả dược sỹ*");
            foreach (DataRow dr in ds.Get_DuocSy().Rows)
            {
                cbb_DuocSy.Items.Add(dr["MaDuocSy"].ToString() + "  -  " + dr["TenDuocSy"].ToString());
            }
            cbb_DuocSy.SelectedIndex = 0;
            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;
            ngay_2.SelectedIndex = now.Day - 1;
            thang_2.SelectedIndex = now.Month - 1;
            nam_2.SelectedIndex = now.Year - 2000;
            cbb_LoaiThongKe.SelectedIndex = 0;
        }
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
            {
                thang.Items.Add(i);
                thang_2.Items.Add(i);
            }
            for (int i = 2000; i < now.Year + 10; i++)
            {
                nam.Items.Add(i);
                nam_2.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                ngay.Items.Add(i);
                ngay_2.Items.Add(i);
            }
        }
        void HideAll()
        {
            
            ngay.Visible = false;
            thang.Visible = false;
            nam.Visible = false;
            ngay_2.Visible = false;
            thang_2.Visible = false;
            nam_2.Visible = false;
            //cbb_DuocSy.Visible = false;
        }
        private void cbb_LoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaDuocSy;
            if(cbb_DuocSy.SelectedIndex == 0)
            {
                MaDuocSy = "";
            }
            else
            {
                string[] tokens = cbb_DuocSy.Text.Split(' ');
                MaDuocSy = tokens[0];
            }
            HideAll();
            if(cbb_LoaiThongKe.SelectedIndex==0)
            {
                
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text, MaDuocSy);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text, MaDuocSy).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if(cbb_LoaiThongKe.SelectedIndex==1)
            {
                
                thang.Visible = true;
                nam.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, thang.Text, "0", MaDuocSy);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, "0", MaDuocSy).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            
            if (cbb_LoaiThongKe.SelectedIndex == 2)
            {
                nam.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 3)
            {
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                ngay_2.Visible = true;
                thang_2.Visible = true;
                nam_2.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text);

                bs.DataSource = db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 4)
            {
                cbb_DuocSy.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;


            }
        }

        private void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void cbb_DuocSy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }
    }
}
