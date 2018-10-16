using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PharmacyManager.UserControlMain
{
    public partial class DonBanThuoc : UserControl
    {
        BUS_THUOC tv = new BUS_THUOC();

        DataTable dtThuocDaChon;
        public DonBanThuoc()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void DonBanThuoc_Load(object sender, EventArgs e)
        {
            loadDataTable();
            sidePanel1.Width = this.Width / 2;
            //Đổ dữ liệu vào gridControl
            BindingSource bs = new BindingSource();
            tv.Get_THUOC();
            bs.DataSource = tv.Get_THUOC().Tables["THUOC"];
            gridControlDanhSach.DataSource = bs;
        }

        private void loadDataTable()
        {
            dtThuocDaChon = new DataTable();
            dtThuocDaChon.Clear();
            dtThuocDaChon.Columns.Add("Mã Thuốc");
            dtThuocDaChon.Columns.Add("Tên Thuốc");
            dtThuocDaChon.Columns.Add("Hoạt Chất");
            dtThuocDaChon.Columns.Add("Giá Bán");
            dtThuocDaChon.Columns.Add("Hạn Sử Dụng");
            dtThuocDaChon.Columns.Add("Số Lượng");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            handleBtnThem();

        }

        private void handleBtnThem()
        {
            try
            {
                DataRowView selectedRow = (DataRowView)gridView2.GetRow(gridView2.FocusedRowHandle);
                string maThuoc = selectedRow.Row.ItemArray[0].ToString();
                string tenThuoc = selectedRow.Row.ItemArray[1].ToString();
                string hoatChat = selectedRow.Row.ItemArray[2].ToString();
                int giaBan = Int32.Parse(selectedRow.Row.ItemArray[5].ToString());
                int hanSuDung = Int32.Parse(selectedRow.Row.ItemArray[6].ToString());
                DataRow destRow = dtThuocDaChon.NewRow();
                destRow[0] = maThuoc;
                destRow[1] = tenThuoc;
                destRow[2] = hoatChat;
                destRow[3] = giaBan;
                destRow[4] = hanSuDung;
                destRow[5] = 1;
                dtThuocDaChon.Rows.Add(destRow);
                gridControl.DataSource = dtThuocDaChon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa Chọn Thuốc");
            }

        }

        private void sidePanel4_Click(object sender, EventArgs e)
        {

        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            dtThuocDaChon.Rows.RemoveAt(gridView1.GetSelectedRows()[0]);
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                handleBtnThem();
            }
        }
    }
}
