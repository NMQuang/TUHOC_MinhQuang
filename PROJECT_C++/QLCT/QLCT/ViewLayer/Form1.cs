using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCT.BussinessLayer;
using QLCT.DataObject;
namespace QLCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load()
        {
            NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
            dataGridViewX1.DataSource = nguoiDungBLL.layDuLieu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
                nguoiDungDAO.TaiKhoan = txtTaiKhoan.Text.Trim();
                nguoiDungDAO.MatKhau = txtMatKhau.Text.Trim();
                NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
                nguoiDungBLL.themNguoiDung(nguoiDungDAO);
                load();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtTaiKhoan.Text = dataGridViewX1["Column1",index].Value.ToString();
            txtMatKhau.Text = dataGridViewX1["Column2", index].Value.ToString();
        }
    }
}
