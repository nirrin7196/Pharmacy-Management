using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
     public class NhaCungCap
    {
        private string _MaCongTy;
        private string _TenCongTy;
        private string _DiaChi;
        public string MaCongTy
        {
            get
            {
                return _MaCongTy;
            }

            set
            {
                this._MaCongTy = value;
            }
        }
        public string TenCongTy
        {
            get
            {
                return _TenCongTy;
            }

            set
            {
                this._TenCongTy = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                this._DiaChi = value;
            }
        }

        public NhaCungCap(string MaCongTy = "", string TenCongTy = "", string DiaChi = "")
        {
            this._MaCongTy = MaCongTy;
            this._TenCongTy = TenCongTy;
            this._DiaChi = DiaChi;
        }
    }
}
