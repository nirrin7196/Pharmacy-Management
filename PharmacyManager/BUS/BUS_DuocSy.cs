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
    public class BUS_DuocSy
    {
        DAL_DuocSy ds = new DAL_DuocSy();
        public DataTable Get_DuocSy()
        {
            return ds.Get_DuocSy();
        }
        public DataTable Get_TTDUOCSY(string MaDuocSy)
        {
            return ds.Get_TTDUOCSY(MaDuocSy);
        }
    }
}
