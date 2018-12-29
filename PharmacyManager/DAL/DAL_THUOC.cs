using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_THUOC : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        

        public void Connection_Close()
        {
            _cn.Close();
        }
        public int Check_SQL()//Kiểm tra xem trong DB có thuốc nào không
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from THUOC", _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int row = dt.Rows.Count;
            if (row != 0)
                return 1;
            else
                return 0;
            ;
        }


        
        public DataSet Get_THUOC()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select MaThuoc 'Mã Thuốc', TenThuoc 'Tên Thuốc', HoatChat 'Hoạt Chất',GiaNhap 'Giá Nhập',GiaSauThue 'Giá Sau Thuế',GiaBan 'Giá Bán',ThoiHanSuDung 'Thời Hạn Sử Dụng'  from THUOC";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "THUOC");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataSet Get_BangGia()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select TenThuoc 'Tên Thuốc',GiaNhap 'Giá Nhập',GiaSauThue 'Giá Sau Thuế',GiaBan 'Giá Bán' from THUOC";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "THUOC");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public string Get_TenThuoc(string MaThuoc)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string tenthuoc;
                SqlDataAdapter da = new SqlDataAdapter(); 
                string sqlstr = "";
                sqlstr = "select TenThuoc from THUOC where MaThuoc='"+MaThuoc+"'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                tenthuoc = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return tenthuoc;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public int Get_GiaBan(string MaThuoc)//Lấy tất thông tin thuốc                 
        {
            try
            {
                int giaban;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select GiaBan from THUOC where MaThuoc='" + MaThuoc + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                giaban = int.Parse(da.InsertCommand.ExecuteScalar().ToString());
                _cn.Close();
                return giaban;
            }
            catch
            {
                _cn.Close();
                return -1;
            }
        }
        public int Check_Exist(string MaThuoc)
        {
            try
            {
                int check;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select COUNT(MaThuoc) from THUOC where MaThuoc='" + MaThuoc + "'";
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
        public DataTable Get_GiaTriThuoc(string MaThuoc)//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from THUOC where MaThuoc='" + MaThuoc + "'";
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
        public bool NhapThuoc(string MaThuoc, string MaDonNhap = "MDN005", string sl = "", string ngayhethan = "")
        {
            _cn.Open();

            string SQL = "INSERT INTO CTDN  VALUES ('" + MaThuoc + "','" + MaDonNhap + "'," + sl + ", '" + ngayhethan + "')";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool NhapThuocMoi(string MaThuoc,string TenThuoc,string HoatChat,int GiaNhap,int GiaSauThue,int GiaBan,string ThoiHanSuDung,int Hop,int Vi ,int GiaVi ,int Goi ,int GiaGoi ,int Vien ,int GiaVien)
        {
            _cn.Open();

            string SQL = "INSERT INTO THUOC (MaThuoc, TenThuoc , HoatChat ,GiaNhap ,GiaSauThue ,GiaBan ,ThoiHanSuDung ,Hop ,Vi ,GiaVi ,Goi ,GiaGoi ,Vien ,GiaVien) VALUES ";
            SQL += "('" + MaThuoc + "','" + TenThuoc + "','" + HoatChat + "'," + GiaNhap + "," + GiaSauThue + "," + GiaBan + "," + ThoiHanSuDung + "," + Hop + "," + Vi + "," + GiaVi + "," + Goi + "," + GiaGoi + "," + Vien + "," + GiaVien + ")";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public int Get_ThoiHanSuDung(string MaThuoc)//Lấy tất thông tin thuốc                 
        {
            try
            {
                int thoihansudung;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select ThoiHanSuDung from THUOC where MaThuoc='" + MaThuoc + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                thoihansudung = int.Parse(da.InsertCommand.ExecuteScalar().ToString());
                _cn.Close();
                return thoihansudung;
            }
            catch
            {
                _cn.Close();
                return -1;
            }
        }
        public string Get_MaDonNhap()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string ma;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "Select Top 1 MaThuoc from THUOC ORDER BY MaThuoc DESC";
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
        public string TaoMaThuoc()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string t = this.Get_MaDonNhap();
                string Ma = t.Substring(3);
                int a = int.Parse(Ma) + 1;
                int length = a.ToString().Length;
                Ma = "MT";
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
        
        
    }
}
