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
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace PharmacyManager.UserControlMain
{
    public partial class NhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();
        BUS_THUOC thuoc = new BUS_THUOC();
        BUS_DuocSy ds = new BUS_DuocSy();
        BUS_DonNhap dn = new BUS_DonNhap();
        public NhapKho()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private List<Thuoc> th = new List<Thuoc>();
        private void NhapKho_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_mathuoc;
            ncc.Get_CONGTY();
            foreach(DataRow dr in ncc.Get_TENCONGTY().Rows)
            {
                cbb_tencty.Items.Add(dr["MaCongTy"].ToString() +"  -  "+ dr["TenCongTy"].ToString() );
            }
            foreach (DataRow dr in ds.Get_DuocSy().Rows)
            {
                cbb_DuocSy.Items.Add(dr["MaDuocSy"].ToString() + "  -  " + dr["TenDuocSy"].ToString());
            }

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            string mathuoc = txt_mathuoc.Text.ToString();
            tenthuoc.Text = thuoc.Get_TenThuoc(mathuoc);
            txt_giatien.Text = thuoc.Get_GiaBan(mathuoc).ToString();
        }

        private void btn_nhapthuoc_Click(object sender, EventArgs e)
        {

            if (thuoc.Check_Exist(txt_mathuoc.Text) == 1)
            {
                int t = int.Parse(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["Vien"].ToString());

                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(txt_mathuoc.Text);
                X.setTenThuoc(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["TenThuoc"].ToString());
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaSauThue"].ToString());
                X.setGiaNhap(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaNhap"].ToString());
                X.Location = new System.Drawing.Point(0, X._stt * 30);
                X.ButtonClick += new EventHandler(this.thuoc_ButtonClick);
                X.ButtonClick_more += new EventHandler(this.thuoc_ButtonClick_more);
                int tt;
                foreach (Thuoc A in th)
                {
                    if (A.getMaSanPham() == txt_mathuoc.Text)
                    {
                        A.setsl();
                        tt = tongtien(th);
                        alltien.Text = tt.ToString();
                        return;
                    }
                }
                th.Add(X);
                panel1.Controls.Add(X);
                tt = tongtien(th);
                alltien.Text = tt.ToString();
                setlist(th);
                //X.setNTN(thuoc.Get_ThoiHanSuDung(txt_mathuoc.Text));
            }
        }
        int tongtien(List<Thuoc> th)
        {
            int all = 0;
            for (int i = 0; i < th.Count; i++)
            {
                all += th[i].getTien();
            }
            return all;
        }
        void setlist(List<Thuoc> th)
        {
            if (th.Count == 0)
                return;

            for (int i = 0; i < th.Count; i++)
            {
                th[i]._stt = i + 1;
                th[i].setSTT(i + 1);
                th[i].Location = new System.Drawing.Point(0, (i + 1) * 30);
            }
        }
        private void thuoc_ButtonClick(object sender, EventArgs e)
        {

            th.RemoveAll(r => r.gt == 1);
            panel1.Controls.Clear();
            setlist(th);
            foreach (Thuoc x in th)
            {
                panel1.Controls.Add(x);
            }

        }
        private void thuoc_ButtonClick_more(object sender, EventArgs e)
        {
            int tt = tongtien(th);
            alltien.Text = tt.ToString();

            
            
        }

        private void txt_mathuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_mathuoc.Text != "")
            {
                btn_nhapthuoc_Click(null, null);
                txt_mathuoc.Text = "";
            }
        }

        private void btn_nhapkho_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string Ma=dn.Get_TaoMaDonNhap();

            string ngaythang = now.Month.ToString() + '/' + now.Day.ToString() + '/' + now.Year.ToString();
            string[] tokens = cbb_tencty.Text.Split(' ');
            string macongty = tokens[0];
            tokens = cbb_DuocSy.Text.Split(' ');
            string maduocsy = tokens[0];
            dn.TaoDonNhap(Ma, ngaythang, macongty, maduocsy);
            foreach (Thuoc A in th)
            {
                string ma_thuoc = A.getMaSanPham();
                string sl = A.getsl().ToString();
                string ntn = A.setNTN(float.Parse(thuoc.Get_GiaTriThuoc(A.getMaSanPham()).Rows[0]["ThoiHanSuDung"].ToString()));
                thuoc.NhapThuoc(ma_thuoc, Ma, sl, ntn);
            }
        }

        private void cbb_tencty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tokens = cbb_tencty.Text.Split(' ');
            string macongty = tokens[0];


            string macty =macongty+"  -  "+ ncc.Get_TENCONGTY(macongty).Rows[0]["MaCongTy"].ToString();
            macty += "  -  ";
            macty += ncc.Get_TENCONGTY(macongty).Rows[0]["DiaChi"].ToString();

            txt_diachi.Text = macty;
        }

        private void cbb_DuocSy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tokens = cbb_DuocSy.Text.Split(' ');
            string maduocsy = tokens[0];
            

            string macds = maduocsy + "  -  " + ds.Get_TTDUOCSY(maduocsy).Rows[0]["TenDuocSy"].ToString();
            macds += "  -  ";
            macds += ds.Get_TTDUOCSY(maduocsy).Rows[0]["BangCap"].ToString();

            txt_ttduocsy.Text = macds;
        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("D:/Test.pdf", FileMode.Create));
            doc.Open();
            
            List list = new List(List.UNORDERED);
            list.IndentationLeft = 30f;
            var blackListTextFont = FontFactory.GetFont("Arial",28, 1);
            var titleChunk = new Chunk("Nhà thuốc ABC", blackListTextFont);
            var phrase = new Phrase(titleChunk);
            doc.Add(phrase);
            //list.Add("Nhà thuốc ABC");
            list.Add(cbb_DuocSy.Text);
            Paragraph paragraph = new Paragraph("\n");
            doc.Add(paragraph);
            doc.Add(list);
            
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell(new Phrase("HÓA ĐƠN TÍNH TIỀN"));
            float[] widths = new float[] { 40f, 5f, 10f };
            table.SetWidths(widths);
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            foreach (Thuoc A in th)
            {
                table.AddCell(A.getName());
                PdfPCell cel = new PdfPCell(new Phrase(A.getsl().ToString()));
                cel.HorizontalAlignment = 2;
                table.AddCell(cel);
                cel = new PdfPCell(new Phrase(A.getTien().ToString()));
                cel.HorizontalAlignment = 2;
                table.AddCell(cel);
            }
            PdfPCell footer = new PdfPCell(new Phrase(alltien.Text));
            footer.Colspan = 3;
            footer.HorizontalAlignment = 2;
            table.AddCell(footer);


            doc.Add(table);

            doc.Close();
        }
    }
}
