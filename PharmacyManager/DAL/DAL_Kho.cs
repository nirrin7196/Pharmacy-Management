using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Kho : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataSet Get_Kho()          
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select * from KhoHang";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "KhoHang");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public int Check_Exist(string MaThuoc)
        {
            try
            {
                int check;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select top 1 SoLuong from KhoHang where MaThuoc = '"+MaThuoc+"' and SoLuong>0";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                check = int.Parse(da.InsertCommand.ExecuteScalar().ToString());
                _cn.Close();
                return check;
            }
            catch
            {
                _cn.Close();
                return -1;
            }
        }
        public DataTable Add_ThemLoaiThuocKhac(string MaThuoc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "select top 2 * from KhoHang where MaThuoc='"+MaThuoc+"' and SoLuong>0 ";
                sqlstr += "EXCEPT select top 1 *  from KhoHang where MaThuoc='"+MaThuoc+"' and SoLuong>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                _cn.Close();
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public DataTable Get_GiaTriThuocTrongKho(string MaThuoc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select top 1 * from KhoHang where MaThuoc = '"+MaThuoc+"' and SoLuong>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                _cn.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }

}
