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
        public Kho()
        {
            InitializeComponent();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            tv.Get_THUOC();
            bs.DataSource = tv.Get_THUOC().Tables["THUOC"];
            grid_kho.DataSource = bs;
        }
    }
}
