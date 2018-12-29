using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_NhaCungCap : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        

        public void Connection_Close()
        {
            _cn.Close();
        }
        public int Check_SQL()//Kiểm tra xem trong DB có nha cung cap nào không
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CONGTY", _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int row = dt.Rows.Count;
            if (row != 0)
                return 1;
            else
                return 0;
            ;
        }


        
        public DataSet Get_CONGTY()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select MaCongTy 'Mã Công Ty', TenCongTy 'Tên Công Ty', DiaChi 'Địa Chỉ' from CONGTY";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "CONGTY");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_TENCONGTY()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from CONGTY";
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
        public DataTable Get_TENCONGTY(string macty)//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from CONGTY where MaCongTy='" + macty + "'";
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
