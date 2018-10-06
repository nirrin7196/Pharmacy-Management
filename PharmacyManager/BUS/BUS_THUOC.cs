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
    public class BUS_THUOC
    {
        DAL_THUOC THUOC = new DAL_THUOC();
        public int Check_SQL()
        {
            return THUOC.Check_SQL();
        }
        public DataSet Get_THUOC()
        {
            return THUOC.Get_THUOC();

        }
    }
}
