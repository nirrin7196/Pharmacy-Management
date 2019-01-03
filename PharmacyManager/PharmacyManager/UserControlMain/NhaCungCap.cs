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
    public partial class NhaCungCap : UserControl
    {
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();

        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            ncc.Get_CONGTY();
            bs.DataSource = ncc.Get_CONGTY().Tables["CONGTY"];
            gridControl1.DataSource = bs;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
