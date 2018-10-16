using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_LOHANGNHAPKHO : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;

        public DataSet Get_LOHANGNHAPKHO()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select dn.MaDonNhap 'Mã Đơn Nhập',dn.MaCongTy 'Mã Công Ty',dn.NgayNhap 'Ngày Nhập' ,ds.TenDuocSy 'Tên Dược Sỹ' from DONNHAP dn, DUOCSY ds where dn.MaDuocSy=ds.MaDuocSy";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "DONNHAP,DUOCSY");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataSet Get_CTDN(string t)//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select * from CTDN ct where ct.MaDonNhap='"+t+"'";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "CTDN");
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
