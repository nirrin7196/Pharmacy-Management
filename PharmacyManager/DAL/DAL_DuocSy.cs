using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_DuocSy : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;

        public DataTable Get_DuocSy()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from DUOCSY";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable Get_TTDUOCSY(string MaDuocSy)         
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from DUOCSY where MaDuocSy='" + MaDuocSy + "'";
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
