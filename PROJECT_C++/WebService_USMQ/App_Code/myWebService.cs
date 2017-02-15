using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for myWebService
/// </summary>
[WebService(Namespace = "http://us_minhquang.com")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class myWebService : System.Web.Services.WebService
{
    ShoppingDataContext db = null;
    public myWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent();
        db = new ShoppingDataContext(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    //demo hosting web service
    [WebMethod]
    public string getHostingWebService()
    {
        return "usminhquang.somee.com";
    }
    //Trả về danh sách Category
    [WebMethod]
    public List <Category> getListCategory()
    {
        List<Category> listCategory = db.Categories.ToList();
        foreach(Category cate in listCategory)
        {
            cate.Products.Clear();
        }
        return listCategory;
    }
    //Trả về thông tin của 1 Category
    [WebMethod]
    public Category getCategory(string id)
    {
        Category cate = db.Categories.FirstOrDefault(x => x.CateID == id);
        cate.Products.Clear();
        return cate;
    }
    //Trả về danh sách Product
    [WebMethod]
    public List<Product> getListProduct()
    {
        List<Product> listProduct = db.Products.ToList();
        foreach(Product pro in listProduct)
        {
            pro.Category = null;
        }
        return listProduct;
    }
    //Trả về thông tin 1 Product
    [WebMethod]
    public Product getProduct(string id)
    {
        Product pro = db.Products.FirstOrDefault(x => x.ProductID == id);
        pro.Category = null;
        return pro;
    }
    //Trả về danh sách Product theo CateID
    [WebMethod]
    public List<Product> getListProductByCateID(string id)
    {
        List<Product> listProduct = db.Products.Where(x => x.CateID == id).ToList();
        foreach(Product pro in listProduct)
        {
            pro.Category = null;
        }
        return listProduct;
    }
    //Xóa 1 Category theo ID
    [WebMethod]
    public bool deleteCategory(string id)
    {
        try
        {
            Category cate = getCategory(id);
            db.Categories.DeleteOnSubmit(cate);
            db.SubmitChanges();
        }
        catch(Exception e)
        {
            return false;
        }
        return true;
    }

    //Xóa 1 Product theo ID
    [WebMethod]
    public bool deleteProduct(string id)
    {
        try
        {
            Product product = getProduct(id);
            db.Products.DeleteOnSubmit(product);
            db.SubmitChanges();
        }
        catch (Exception e)
        {
            return false;
        }
        return true;
    }

    //Thêm 1 Category
    [WebMethod]
    public bool addCategory(string idCate,string nameCate)
    {
        try
        {
            db = new ShoppingDataContext();
            Category cate = new Category();
            cate.CateID = idCate;
            cate.CateName = nameCate;
            db.Categories.InsertOnSubmit(cate);
            db.SubmitChanges();
        }catch(Exception e)
        {
            return false;
        }
        return true;
    }
    //Thêm 1 Product
    [WebMethod]
    public bool addProduct(string idProduct,string nameProduct,int quanlity,float unitPrice,float total,string idCate)
    {
        try
        {
            db = new ShoppingDataContext();
            Product prod = new Product();
            prod.ProductID = idProduct;
            prod.ProductName = nameProduct;
            prod.Quanlity = quanlity;
            prod.UnitPrice = unitPrice;
            prod.TotalMoney = total;
            prod.CateID = idCate;
            db.Products.InsertOnSubmit(prod);
            db.SubmitChanges();
        }catch(Exception e)
        {
            return false;
        }
        return true;
    }

}
