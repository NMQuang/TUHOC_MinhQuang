using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT.DataObject
{
    class NguoiDungDAO
    {

        private string taiKhoan;
        private string matKhau;

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public NguoiDungDAO(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public NguoiDungDAO()
        {
            this.taiKhoan = null;
            this.matKhau = null;

        }
    }
}
