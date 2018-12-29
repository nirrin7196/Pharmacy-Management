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
    public class BUS_THUOC
    {
        DAL_THUOC THUOC = new DAL_THUOC();
        public int Check_SQL()
        {
            return THUOC.Check_SQL();
        }
        public DataSet Get_THUOC()
        {
            return THUOC.Get_THUOC();

        }
        public DataSet Get_BangGia()
        {
            return THUOC.Get_BangGia();

        }
        public string Get_TenThuoc(string MaThuoc)
        {
            return THUOC.Get_TenThuoc(MaThuoc);
        }
        public int Get_GiaBan(string MaThuoc)
        {
            return THUOC.Get_GiaBan(MaThuoc);
        }
        public int Check_Exist(string MaThuoc)
        {
            return THUOC.Check_Exist(MaThuoc);
        }
        public bool NhapThuoc(string MaThuoc, string MaDonNhap = "MDN004", string sl = "", string ngayhethan = "")
        {
            return THUOC.NhapThuoc(MaThuoc, MaDonNhap, sl, ngayhethan);
        }
        public bool NhapThuocMoi(string MaThuoc, string TenThuoc, string HoatChat, int GiaNhap, int GiaSauThue, int GiaBan, string ThoiHanSuDung, int Hop, int Vi, int GiaVi, int Goi, int GiaGoi, int Vien, int GiaVien)
        {
            return THUOC.NhapThuocMoi(MaThuoc, TenThuoc, HoatChat, GiaNhap, GiaSauThue, GiaBan, ThoiHanSuDung, Hop, Vi, GiaVi,Goi,GiaGoi,Vien,GiaVien);
        }
        public int Get_ThoiHanSuDung(string MaThuoc)
        {
            return THUOC.Get_ThoiHanSuDung(MaThuoc);
        }
        public DataTable Get_GiaTriThuoc(string MaThuoc)
        {
            return THUOC.Get_GiaTriThuoc(MaThuoc);
        }
        public string TaoMaThuoc()
        {
            return THUOC.TaoMaThuoc();
        }
    }
}
