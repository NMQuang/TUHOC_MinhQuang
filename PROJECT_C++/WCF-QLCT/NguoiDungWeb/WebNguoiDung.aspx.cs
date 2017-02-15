using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NguoiDungWeb.ServiceReference1;
using System.Data;

namespace NguoiDungWeb
{
    public partial class WebNguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            NguoiDungBLLClient service = new NguoiDungBLLClient();
            DataSet dsNguoiDung = service.layDuLieu();
            gvNguoiDung.DataSource = dsNguoiDung.Tables[0];
            gvNguoiDung.DataBind();
        }
    }
}