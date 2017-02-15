using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Xml;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://us_minhquang.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
 

    //Thêm Sách
    [WebMethod]
    public bool addBook(string ma,string ten,string sl,string gia)
    {
        //gán dữ liệu vào DTO
        SachDTO sachDTO = new SachDTO();
        //SachBLL sachBLL = new SachBLL();
        try
        {
            sachDTO.MaSach = ma.ToLower();
            sachDTO.TenSach = ten;
            sachDTO.SoLuong = sl;//int.Parse(sl.ToString());
            sachDTO.DongGia = gia;//double.Parse(gia.ToString());
            //gọi BLL thực hiện
            sachDTO.Them(sachDTO);
        }catch(Exception e)
        {
            return false;
        }
        return true;
    }
    //Sửa sách
    [WebMethod]
    public bool updateBook(string ma, string ten, string sl, string gia)
    {
        //gán dữ liệu vào DTO
        SachDTO sachDTO = new SachDTO();
       // SachBLL sachBLL = new SachBLL();
        try
        {
            sachDTO.MaSach = ma.ToLower();
            sachDTO.TenSach = ten;
            sachDTO.SoLuong = sl;//int.Parse(sl.ToString());
            sachDTO.DongGia = gia;//double.Parse(gia.ToString());
            //gọi BLL thực hiện
            sachDTO.Sua(sachDTO);
        }
        catch (Exception e)
        {
            return false;
        }
        return true;
    }

    //Xóa Sách
    [WebMethod]
    public bool deleteBook(string ma)
    {
        SachDTO sachDTO = new SachDTO();
        
        try
        {
            sachDTO.MaSach = ma;
           sachDTO.Xoa(sachDTO); 

        }catch(Exception e)
        {
            return false;
        }
        return true;
    }
    //Tìm sách
    [WebMethod]
    public SachDTO searchBook(string chuoi)
    {
        SachDTO sachDTO = new SachDTO();
         return sachDTO.TimKiem(chuoi);

    }
    //Lay ds Sach
    [WebMethod]
    public List<SachDTO> getListBook()
    {
       
        SachDTO sachDTO = new SachDTO();
        return sachDTO.layDSSach();
    }
   
}
//Tạo lớp đối tượng Sách 
public class SachDTO
{
    private string _MaSach;
    private string _TenSach;
    private string _SoLuong;
    private string _DongGia;

    public SachDTO(string masach,string tensach,string sl,string gia)
    {
        _MaSach = masach;
        _TenSach = tensach;
        _SoLuong = sl;
        _DongGia = gia;
    }
    public SachDTO()
    {
        _MaSach = null;
        _TenSach = null;
        _SoLuong =null;
        _DongGia = null;
    }
    public string DongGia
    {
        get { return _DongGia; }
        set { _DongGia = value; }
    }

    public string SoLuong
    {
        get { return _SoLuong; }
        set { _SoLuong = value; }
    }

    public string TenSach
    {
        get { return _TenSach; }
        set { _TenSach = value; }
    }

    public string MaSach
    {
        get { return _MaSach; }
        set { _MaSach = value; }
    }

   
    
    public void Them(SachDTO sachThem)
    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        //tạo nút sách
        XmlNode sach = doc.CreateElement("sach");

        //tạo nút con của sách là masach
        XmlElement masach = doc.CreateElement("masach");
        masach.InnerText = sachThem.MaSach;//gán giá trị cho mã sách
        sach.AppendChild(masach);//thêm masach vào trong sách(sach nhận masach là con)

        XmlElement tensach = doc.CreateElement("tensach");
        tensach.InnerText = sachThem.TenSach;
        sach.AppendChild(tensach);

        XmlElement soluong = doc.CreateElement("soluong");
        soluong.InnerText = sachThem.SoLuong.ToString();
        sach.AppendChild(soluong);

        XmlElement dongia = doc.CreateElement("dongia");
        dongia.InnerText = sachThem.DongGia.ToString();
        sach.AppendChild(dongia);
        //sau khi tạo xong sách, thì thêm sách vào gốc root
        root.AppendChild(sach);
        doc.Save(fileName);//lưu dữ liệu

    }


    public void Sua(SachDTO sachSua)
    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        //láy vị trí cần sửa theo mã sách cũ đưa vào
        XmlNode sachCu = root.SelectSingleNode("sach[masach ='" + sachSua.MaSach + "']");
        if (sachCu != null)
        {
            XmlNode sachSuaMoi = doc.CreateElement("sach");

            //tạo nút con của sách là masach
            XmlElement masach = doc.CreateElement("masach");
            masach.InnerText = sachSua.MaSach;//gán giá trị cho mã sách
            sachSuaMoi.AppendChild(masach);//thêm masach vào trong sách(sach nhận masach là con)

            XmlElement tensach = doc.CreateElement("tensach");
            tensach.InnerText = sachSua.TenSach;
            sachSuaMoi.AppendChild(tensach);

            XmlElement soluong = doc.CreateElement("soluong");
            soluong.InnerText = sachSua.SoLuong.ToString();
            sachSuaMoi.AppendChild(soluong);

            XmlElement dongia = doc.CreateElement("dongia");
            dongia.InnerText = sachSua.DongGia.ToString();
            sachSuaMoi.AppendChild(dongia);

            //thay thế sách cũ bằng sách mới(sửa )
            root.ReplaceChild(sachSuaMoi, sachCu);
            doc.Save(fileName);//lưu lại
        }
    }
    public void Xoa(SachDTO sachXoa)
    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        XmlNode sachCanXoa = root.SelectSingleNode("sach[masach ='" + sachXoa.MaSach + "']");
        if (sachCanXoa != null)
        {
            root.RemoveChild(sachCanXoa);

            doc.Save(fileName);
        }
    }
    public SachDTO TimKiem(string chuoi)
    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        SachDTO sachTim = new SachDTO();
      
        for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++)
        {
            XmlNode sachCanTim = doc.DocumentElement.ChildNodes[i];
            if (sachCanTim != null &&( sachCanTim.SelectSingleNode("masach").InnerText == chuoi || sachCanTim.SelectSingleNode("tensach").InnerText == chuoi   ))
            {

                sachTim.MaSach = sachCanTim.SelectSingleNode("masach").InnerText;
                sachTim.TenSach = sachCanTim.SelectSingleNode("tensach").InnerText;
                sachTim.SoLuong = sachCanTim.SelectSingleNode("soluong").InnerText;
                sachTim.DongGia = sachCanTim.SelectSingleNode("dongia").InnerText;
                 
            }
          
        }
       return sachTim;

    }
    //lay ds Sach
    public List<SachDTO> layDSSach()

    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        List<SachDTO> listSach = new List<SachDTO>();
        for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++)
        {
            XmlNode sachNode = doc.DocumentElement.ChildNodes[i];
            SachDTO sach = new SachDTO();
           
            if (sachNode != null)
            {
                sach.MaSach = sachNode.SelectSingleNode("masach").InnerText;
                sach.TenSach = sachNode.SelectSingleNode("tensach").InnerText;
                sach.SoLuong = sachNode.SelectSingleNode("soluong").InnerText;
                sach.DongGia = sachNode.SelectSingleNode("dongia").InnerText;
            }
            listSach.Add(sach);
        }
        return listSach;
    }
    //Lấy 1 Sách
   /* public SachDTO laySach()
    {
        XmlDocument doc = new XmlDocument();
        string fileName = @"D:\Project-C++\DO_AN\XMLFile.xml";
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        SachDTO sachLay = new SachDTO();

        return sachLay;
    }*/
  
}





 


