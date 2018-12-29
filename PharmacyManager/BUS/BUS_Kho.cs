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
    public class BUS_Kho
    {
        DAL_Kho kho = new DAL_Kho();
        public DataSet Get_Kho()
        {
            return kho.Get_Kho();
        }
        public int Check_Exist(string MaThuoc)
        {
            return kho.Check_Exist(MaThuoc);
        }
        public DataTable Get_GiaTriThuocTrongKho(string MaThuoc)
        {
            return kho.Get_GiaTriThuocTrongKho(MaThuoc);
        }
        public DataTable Add_ThemLoaiThuocKhac(string MaThuoc)
        {
            return kho.Add_ThemLoaiThuocKhac(MaThuoc);
        }
    }
}
