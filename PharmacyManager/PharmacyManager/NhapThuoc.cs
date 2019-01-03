using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManager.UserControlMain;
namespace PharmacyManager
{
    public partial class NhapThuoc : DevExpress.XtraEditors.XtraForm
    {
        ThemThuocMoi ucThemThuoc = new ThemThuocMoi();
        public NhapThuoc()
        {
            InitializeComponent();
        }

        private void NhapThuoc_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ucThemThuoc);
        }
    }
}
