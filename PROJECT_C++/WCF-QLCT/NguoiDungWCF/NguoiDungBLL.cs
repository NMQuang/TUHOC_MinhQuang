using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using QLCT.DataConfig;

namespace NguoiDungWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NguoiDungBLL" in both code and config file together.
    public class NguoiDungBLL : INguoiDungBLL
    {
        DBConnect db = new DBConnect();

        public DataSet layDuLieu()
        {
            DataSet result = new DataSet();
            string sqlString = "select * from NguoiDung";
            result = db.layDuLieu(sqlString);
            return result;
        }
    }
}
