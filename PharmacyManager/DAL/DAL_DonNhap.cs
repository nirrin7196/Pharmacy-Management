using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_DonNhap : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string Get_MaDonNhap()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string ma;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "Select Top 1 MaDonNhap from DONNHAP ORDER BY MaDonNhap DESC";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                ma = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return ma;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public string Get_TaoMaDonNhap()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string t = this.Get_MaDonNhap();
                string Ma = t.Substring(3);
                int a = int.Parse(Ma) + 1;
                int length = a.ToString().Length;
                Ma = "MDN";
                for (int i = length; i < 3; i++)
                {
                    Ma += "0";
                }
                Ma += a.ToString();
                return Ma;
            }
            catch
            {
                return null;
            }
        }
        public bool TaoDonNhap(string MaDonNhap, string NgayNhap, string MaCongTy, string MaDuocSy)
        {
            _cn.Open();

            string SQL = "INSERT INTO DONNHAP (MaDonNhap, NgayNhap, MaCongTy, MaDuocSy) VALUES ('" + MaDonNhap + "','" + NgayNhap + "','" + MaCongTy + "', '" + MaDuocSy + "')";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public DataSet Get_ThongKeKho()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select MaThuoc,TenThuoc,NgayHetHan, sum(SoLuong) 'SoLuong' ";
                sqlstr += "from ( ";
                sqlstr += "select t.MaThuoc,t.TenThuoc,ct.NgayHetHan, ct.SoLuong ";
                sqlstr += "from THUOC t, DONNHAP dn, CTDN ct ";
                sqlstr += "where t.MaThuoc=ct.MaThuoc and dn.MaDonNhap=ct.MaDonNhap ";
                sqlstr += "union all ";
                sqlstr += "select t.MaThuoc,t.TenThuoc,ct.NgayHetHan, ct.SoLuong*-1 ";
                sqlstr += "from THUOC t, DONBAN db, CTDONTHUOC ct ";
                sqlstr += "where t.MaThuoc=ct.MaThuoc and db.MaDonBan=ct.MaDonBan) t ";
                sqlstr += "group by MaThuoc,TenThuoc,NgayHetHan ";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataSet();
                ds.Clear();
                _cn.Close();
                da.Fill(ds, "DONBAN , CTDONTHUOC , THUOC, DONNHAP, CTDN");
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public string Get_TenCongTy(string MaThuoc, string NgayHetHan)
        {
            try
            {
                string TenCty;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select cty.TenCongTy ";
                sqlstr += "from CTDN ct, DONNHAP dn,CONGTY cty ";
                sqlstr += "where ct.MaDonNhap=dn.MaDonNhap and cty.MaCongTy=dn.MaCongTy and ct.MaThuoc='";
                sqlstr += MaThuoc + "' and ct.NgayHetHan='" + NgayHetHan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                TenCty = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return TenCty;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public string Get_SoLuong(string MaThuoc, string NgayHetHan)
        {
            try
            {
                string SoLuong;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select SoLuong ";
                sqlstr += "from KhoHang ";
                sqlstr += "where MaThuoc='";
                sqlstr += MaThuoc + "' and NgayHetHan='" + NgayHetHan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                SoLuong = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return SoLuong;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
    }
}
