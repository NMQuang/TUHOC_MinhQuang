using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCT.DataConfig;
using QLCT.DataObject;
namespace QLCT.BussinessLayer
{
    class NguoiDungBLL
    {
        DBConnect db = new DBConnect();
        public DataTable layDuLieu()
        {
            
            DataTable result = new DataTable();
            string sqlString = "select * from NguoiDung";
            result = db.layDuLieu(sqlString);
            return result;
        }

        public bool kiemTraMa(string str)
        {
            string sqlString = "select*from NguoiDung";
            return true;
        }
        /// <summary>
        /// Thêm ngươi dùng
        /// </summary>
        /// <param name="ndDAO"> NguoiDungDAO</param>
        /// <returns>số bản ghi</returns>
        public int themNguoiDung(NguoiDungDAO ndDAO)
        {
            int result = 0;
            string sqlString = "insert into NguoiDung(TaiKhoan,MatKhau) values('" + ndDAO.TaiKhoan + "','" + ndDAO.MatKhau + "')";
            result = db.truyVanDuLieu(sqlString);
            return result;
        }
        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="ndDAO">NguoiDungDAO</param>
        /// <returns>số bản ghi</returns>
        public int suaNguoiDung(NguoiDungDAO ndDAO)
        {
            int result = 0;
            string sqlString = "update NguoiDungndDAO set TaiKhoan = '"+ndDAO.TaiKhoan+"' where MatKhau = '"+ndDAO.MatKhau+"'";
            result = db.truyVanDuLieu(sqlString);
            return result;
        }

        public int xoaNguoiDung(string str)
        {
            int result = 0;
            string sqlString = "delete NguoiDung where TaiKhoan";
            result = db.truyVanDuLieu(sqlString);
            return result;
        }
    }
}
