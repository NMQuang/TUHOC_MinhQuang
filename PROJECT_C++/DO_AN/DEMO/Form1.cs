using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        localhost.WebService service = new localhost.WebService();

        localhost.SachDTO sachDTO = new localhost.SachDTO();
      
        

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtMaSach.Text.Trim() != "")
            {
                sachDTO.MaSach = txtMaSach.Text.ToLower();
                sachDTO.TenSach = txtTenSach.Text;
                sachDTO.SoLuong = txtSoLuong.Text;
                sachDTO.DongGia = txtGia.Text;
                service.addBook(sachDTO.MaSach, sachDTO.TenSach, sachDTO.SoLuong, sachDTO.DongGia);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Sach.DataSource = service.getListBook();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTim.Text.Trim()!= "")
            {
                sachDTO = service.searchBook(txtTim.Text);
                //dgv_Sach.DataSource = sachDTO;
                //dgv_Sach.ColumnCount = 4;
                dgv_Sach.Rows.Add();
                dgv_Sach.Rows[0].Cells[0].Value = sachDTO.DongGia;
                dgv_Sach.Rows[0].Cells[1].Value = sachDTO.SoLuong;
                dgv_Sach.Rows[0].Cells[2].Value = sachDTO.TenSach;
                dgv_Sach.Rows[0].Cells[3].Value = sachDTO.MaSach;
            }
        }
    }
}
