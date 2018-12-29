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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan tk = new DAL_TaiKhoan();
        public string Get_MatKhau(string TaiKhoan)
        {
            return tk.Get_MatKhau(TaiKhoan);
        }
        public string Get_TenDuocSy(string TaiKhoan)
        {
            return tk.Get_TenDuocSy(TaiKhoan);
        }
    }
}
