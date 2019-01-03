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
    public partial class TraThuocHetHan : DevExpress.XtraEditors.XtraUserControl
    {
        public TraThuocHetHan()
        {
            InitializeComponent();
        }
        BUS_DonNhap dn = new BUS_DonNhap();
        DateTime now = DateTime.Now;
        BUS_DonBan db = new BUS_DonBan();
        DataTable dtMatHangDaChon;
        private void TraThuocHetHan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            grid_DSThuoc.Width = this.Width / 2;
            addItem();
            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;

            BindingSource bs = new BindingSource();
            db.ThongKeTraHang();
            bs.DataSource = db.ThongKeTraHang().Tables["THUOC,CTDONTHUOC,DONBAN,CTDN,DONNHAP,CONGTY"];
            grid_DSTraThuoc.DataSource = bs;


            dtMatHangDaChon = new DataTable();
            dtMatHangDaChon.Clear();
            dtMatHangDaChon.Columns.Add("STT");
            dtMatHangDaChon.Columns.Add("Tên Thuốc");
            dtMatHangDaChon.Columns.Add("Ngày Hết hạn");
            dtMatHangDaChon.Columns.Add("Tên Công Ty");
            dtMatHangDaChon.Columns.Add("Số Lượng");
        }
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
                thang.Items.Add(i);
            for (int i = 2000; i < now.Year + 10; i++)
                nam.Items.Add(i);
            for (int i = 1; i <= 31; i++)
                ngay.Items.Add(i);
        }

        private void btn_NhapThuoc_Click(object sender, EventArgs e)
        {

            //int a=gridView1.DataRowCount;
            DataRow destRow = dtMatHangDaChon.NewRow();
            destRow[0] = gridView1.DataRowCount+1;
            destRow[1] = txt_MaThuoc.Text;
            destRow[2] = ngay.Text+"/"+thang.Text+"/"+nam.Text;
            destRow[3] = dn.Get_TenCongTy(txt_MaThuoc.Text, ngay.Text + "/" + thang.Text + "/" + nam.Text);
            destRow[4] = dn.Get_SoLuong(txt_MaThuoc.Text, ngay.Text + "/" + thang.Text + "/" + nam.Text);
            dtMatHangDaChon.Rows.Add(destRow);
            grid_DSThuoc.DataSource = dtMatHangDaChon;
        }

        private void btn_TraThuoc_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string Ma = db.Get_TaoMaDonBan();

            string ngaythang = now.Month.ToString() + '/' + now.Day.ToString() + '/' + now.Year.ToString();
            db.TaoDonBan(Ma, 2, ngaythang, "MDS002", 0);
            for(int i=0;i<gridView1.DataRowCount;i++)
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(i);
                string MaThuoc = selectedRow.Row.ItemArray[1].ToString();
                string NgayHetHan = selectedRow.Row.ItemArray[2].ToString();
                string sl = selectedRow.Row.ItemArray[4].ToString();
                db.CTDB(MaThuoc, Ma, sl, NgayHetHan, 2, 0);
            }
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
