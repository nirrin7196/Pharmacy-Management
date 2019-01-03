using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_DonBan : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataSet Get_ThongKeBan()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select MaDonBan,NgayBan,TacDung,Gia from DONBAN";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataSet();
                ds.Clear();

                da.Fill(ds, "DONBAN");
                _cn.Close();
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public DataSet Get_ThongKeTheoNam(string nam, string thang, string ngay, string MaDuocSy)//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select MaDonBan,NgayBan,TacDung,Gia from DONBAN where";
                if (int.Parse(nam) != 0)
                {
                    sqlstr += "  YEAR(NgayBan)=" + nam;
                    if (int.Parse(thang) != 0)
                    {
                        sqlstr += " and MONTH(NgayBan)=" + thang;
                        if (int.Parse(ngay) != 0)
                        {
                            sqlstr += " and DAY(NgayBan)=" + ngay;
                        }
                    }
                }
                sqlstr += " and MaDuocSy like '%" + MaDuocSy + "%' and Gia>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataSet();
                ds.Clear();

                da.Fill(ds, "DONBAN");
                _cn.Close();
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
        public DataSet Get_ThongKeKhoangTime(string nam, string thang, string ngay, string MaDuocSy, string nam_2, string thang_2, string ngay_2)//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select MaDonBan,NgayBan,TacDung,Gia from DONBAN where";
                sqlstr += " MaDuocSy like '%" + MaDuocSy + "%'";
                sqlstr += "  and NgayBan>='" + thang + "/" + ngay + "/" + nam + "' and NgayBan<='" + thang_2 + "/" + ngay_2 + "/" + nam_2 + "'  and Gia>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataSet();
                ds.Clear();

                da.Fill(ds, "DONBAN");
                _cn.Close();
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }

        public DataTable Get_AllDoanhThu()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select SUM(GiaSauThue) 'GiaSauThue',SUM(GiaBan)'GiaBan',SUM(TienLai)'TienLai' from ThongKeBan";
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
        public string Get_MaDonBan()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string ma;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "Select Top 1 MaDonBan from DONBAN ORDER BY MaDonBan DESC";
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

        public string Get_TaoMaDonBan()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string t = this.Get_MaDonBan();
                string Ma = t.Substring(3);
                int a = int.Parse(Ma) + 1;
                int length = a.ToString().Length;
                Ma = "MDB";
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
        public bool TaoDonBan(string MaDonBan, int LoaiDon, string NgayBan, string MaDuocSy, int Gia)
        {
            _cn.Open();

            string SQL = "INSERT INTO DONBAN (MaDonBan, LoaiDon, NgayBan, MaDuocSy, TacDung,Gia) VALUES ('" + MaDonBan + "', " + LoaiDon + ", '" + NgayBan + "', '" + MaDuocSy + "', N''," + Gia + ");";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool CTDB(string MaThuoc, string MaDonBan, string sl, string ngayhethan, int LoaiDonThuoc, int Gia)
        {
            _cn.Open();

            string SQL = "INSERT INTO CTDONTHUOC VALUES ('" + MaDonBan + "', '" + MaThuoc + "', " + sl + ", '" + ngayhethan + "'," + LoaiDonThuoc + "," + Gia + ")";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public DataSet ThongKeTraHang()
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select t.MaThuoc 'Mã Thuốc',t.TenThuoc 'Tên Thuốc',ct.SoLuong 'Số Lượng',t.GiaNhap 'GiaNhap',db.NgayBan 'Ngày Trả',cty.TenCongTy 'Nhà Cung Cấp',ct.SoLuong*t.GiaNhap 'Thiệt Hại'";
                sqlstr += " from THUOC t, CTDONTHUOC ct,DONBAN db,CTDN ctdn, DONNHAP dn,CONGTY cty";
                sqlstr += " where t.MaThuoc=ct.MaThuoc and t.MaThuoc=ctdn.MaThuoc and ct.LoaiDonThuoc=2 and db.MaDonBan=ct.MaDonBan and ct.NgayHetHan=ctdn.NgayHetHan and dn.MaCongTy=cty.MaCongTy and ctdn.MaDonNhap=dn.MaDonNhap";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataSet();
                ds.Clear();

                da.Fill(ds, "THUOC,CTDONTHUOC,DONBAN,CTDN,DONNHAP,CONGTY");
                _cn.Close();
                return ds;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }
    }
}
