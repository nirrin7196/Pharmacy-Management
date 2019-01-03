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
    public partial class Kho : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_THUOC tv = new BUS_THUOC();
        BUS_DonNhap dn = new BUS_DonNhap();
        BUS_Kho kho = new BUS_Kho(); 
        public Kho()
        {
            InitializeComponent();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            BindingSource bs = new BindingSource();
            
            bs.DataSource = kho.Get_Kho().Tables["KhoHang"];
            grid_kho.DataSource = bs;
        }
    }
}
