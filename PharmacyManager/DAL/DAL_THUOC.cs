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
    }
}
