using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_TaiKhoan : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string Get_MatKhau(string TaiKhoan)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string matkhau;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select MatKhau from TAIKHOAN where TaiKhoan='" + TaiKhoan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                matkhau = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return matkhau;
            }
            catch
            {
                return null;
            }
        }
        public string Get_TenDuocSy(string TaiKhoan)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string tenduocsy;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select ds.TenDuocSy from TAIKHOAN tk, DUOCSY ds where tk.MaDuocSy=ds.MaDuocSy and tk.TaiKhoan='" + TaiKhoan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                tenduocsy = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return tenduocsy;
            }
            catch
            {
                return null;
            }
        }

    }
}
