using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguoiDungWCF;
using ViewLayer.NguoiDungService;

namespace ViewLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            NguoiDungBLLClient service = new NguoiDungBLLClient();
            DataSet dsNguoiDung =  service.layDuLieu();
            dataGridViewX1.DataSource = dsNguoiDung.Tables[0];
        }
    }
}
