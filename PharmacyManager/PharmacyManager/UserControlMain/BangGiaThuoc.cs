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
    public partial class BangGiaThuoc : UserControl
    {
        BUS_THUOC t = new BUS_THUOC();
        public BangGiaThuoc()
        {
            InitializeComponent();
        }
        private void BangGiaThuoc_Load(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //t.Get_BangGia();
            //bs.DataSource = t.Get_BangGia().Tables["THUOC"];
            //gridControl1.DataSource = bs;

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            t.Get_BangGia();
            bs.DataSource = t.Get_BangGia().Tables["THUOC"];
            gridControl1.DataSource = bs;
        }

        
    }
}
