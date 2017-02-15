using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCT.DataConfig
{
    public class DBConnect
    {
        public static string chuoiKetNoi = @"Data Source=MINH_QUANG\SQLEXPRESS;Initial Catalog=QLCT;Integrated Security=True";
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SqlConnection open()
        {
            con = new SqlConnection(chuoiKetNoi);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection close()
        {
            con = new SqlConnection(chuoiKetNoi);
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }

        public DataTable layDuLieu(string sql)
        {
            open();
            dt = new DataTable();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }
        //thêm sửa xóa
        public int truyVanDuLieu(string sqlString)
        {
            int result = 0;
            open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlString;//Câu truy vấn
            result = cmd.ExecuteNonQuery();
            return result;
        }

        public object truyVanTraVeDoiTuong(string sqlString)
        {
            object result = 0;
            open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlString;//Câu truy vấn
            result = cmd.ExecuteScalar();
            return result;
        }
    }

}
