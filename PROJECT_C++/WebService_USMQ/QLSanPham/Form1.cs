using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isFinish = false;
        com.somee.usminhquang.myWebService test = new com.somee.usminhquang.myWebService();
        private void btn_category_Click(object sender, EventArgs e)
        {
            isFinish = false;
            List<com.somee.usminhquang.Category> listCategory = test.getListCategory().ToList();
            listBox_category.DataSource = listCategory;
            listBox_category.DisplayMember = "CateName";
            listBox_category.ValueMember = "CateID";
            isFinish = true;

        }

        private void listBox_category_ItemClick(object sender, EventArgs e)
        {

        }

        private void listBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFinish)
                return;
            if (listBox_category.SelectedItem != null)
            {
                com.somee.usminhquang.Category cate = listBox_category.SelectedItem as com.somee.usminhquang.Category;
                List<com.somee.usminhquang.Product> listProduct = test.getListProductByCateID(cate.CateID).ToList();
                listBox_product.DataSource = listProduct;
                listBox_product.DisplayMember = "ProductName";
                listBox_product.ValueMember = "ProductID";
            }
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if (listBox_product.SelectedItem == null)
                return;
            DialogResult ret = MessageBox.Show("Bạn muốn xóa Product này hả?");
            if(ret == DialogResult.Yes)
            {
                com.somee.usminhquang.Product prod = listBox_product.SelectedItem as com.somee.usminhquang.Product;
                bool isDelete = test.deleteProduct(prod.ProductID);
                if (isDelete)
                {
                    com.somee.usminhquang.Category cate = listBox_category.SelectedItem as com.somee.usminhquang.Category;
                    List<com.somee.usminhquang.Product> listProduct = test.getListProductByCateID(cate.CateID).ToList();
                    listBox_product.DataSource = listProduct;
                    listBox_product.DisplayMember = "ProductName";
                    listBox_product.ValueMember = "ProductID";
                    MessageBox.Show("Đã xóa thành công");
                }else
                {
                    MessageBox.Show("Không xóa được sản phẩm này.");
                }
            }
        }
    }
}
