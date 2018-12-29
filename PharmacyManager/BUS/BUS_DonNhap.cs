using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_DonNhap
    {
        DAL_DonNhap dn = new DAL_DonNhap();
        public string Get_TaoMaDonNhap()
        {
            return dn.Get_TaoMaDonNhap();
        }
        public bool TaoDonNhap(string MaDonNhap, string NgayNhap, string MaCongTy, string MaDuocSy)
        {
            return dn.TaoDonNhap(MaDonNhap, NgayNhap, MaCongTy, MaDuocSy);
        }
        public DataSet Get_ThongKeKho()
        {
            return dn.Get_ThongKeKho();
        }
    }
}
