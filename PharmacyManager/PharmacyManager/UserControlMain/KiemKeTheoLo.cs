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
    public partial class KiemKeTheoLo : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_LOHANGNHAPKHO lh = new BUS_LOHANGNHAPKHO();

        public KiemKeTheoLo()
        {
            InitializeComponent();
        }

        private void KiemKeTheoLo_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            lh.Get_LOHANGNHAPKHO();
            bs.DataSource = lh.Get_LOHANGNHAPKHO().Tables["DONNHAP,DUOCSY"];
            grid_KiemKeTheoLo.DataSource = bs;

            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string t = selectedRow.Row.ItemArray[0].ToString();
            BindingSource b = new BindingSource();
            lh.Get_CTDN(t);
            b.DataSource = lh.Get_CTDN(t).Tables["CTDN"];
            grid_CTDN.DataSource = b;
        }

        private void grid_KiemKeTheoLo_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string t = selectedRow.Row.ItemArray[0].ToString();

            BindingSource b = new BindingSource();
            lh.Get_CTDN(t);
            b.DataSource = lh.Get_CTDN(t).Tables["CTDN"];
            grid_CTDN.DataSource = b;
        }
    }
}
