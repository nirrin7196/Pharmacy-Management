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
namespace PharmacyManager.UserControlMain
{
    public partial class DanhMucHang : UserControl
    {
        BUS_THUOC thuoc = new BUS_THUOC();
        public DanhMucHang()
        {
            InitializeComponent();
        }

        private void DanhMucHang_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = thuoc.Get_THUOC().Tables[0];
            gridControl1.DataSource = bs;
            this.Dock = DockStyle.Fill;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            NhapThuoc formNhapThuoc = new NhapThuoc();
            formNhapThuoc.ShowDialog();
        }
    }
}
