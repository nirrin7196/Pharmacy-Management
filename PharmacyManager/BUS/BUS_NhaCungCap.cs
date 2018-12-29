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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap CONGTY = new DAL_NhaCungCap();
        public int Check_SQL()
        {
            return CONGTY.Check_SQL();
        }
        public DataSet Get_CONGTY()
        {
            return CONGTY.Get_CONGTY();

        }
        //public string Get_TenCongTy(string MaCongTy)
        //{
        //    return CONGTY.Get_TenCongTy(MaCongTy);
        //}
        public DataTable Get_TENCONGTY(string name)
        {
            return CONGTY.Get_TENCONGTY(name);
        }
        public DataTable Get_TENCONGTY()
        {
            return CONGTY.Get_TENCONGTY();
        }
    }
}
