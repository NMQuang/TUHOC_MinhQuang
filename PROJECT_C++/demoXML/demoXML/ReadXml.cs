using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace demoXML
{
    public partial class ReadXml : Form
    {
        public ReadXml()
        {
            InitializeComponent();
        }

        private void ReadXml_Load(object sender, EventArgs e)
        {
            try
            {
                string Path = Application.StartupPath + "\\data";
                if(Directory.Exists(Path))
                {
                    DirectoryInfo di = new DirectoryInfo(Path);
                    foreach(FileInfo fi in di.GetFiles())
                    {
                        if(fi.Extension.ToLower() == ".xml")
                        {
                            comboBoxChon.Items.Add(fi.Name.Substring(0, fi.Name.Length - 4));
                        }
                    }
                }
                if(comboBoxChon.Items.Count >0)
                {
                    comboBoxChon.SelectedItem = comboBoxChon.Items[0];
                    ReadXmlFile(comboBoxChon.Items[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trả về là \n " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string s = Application.StartupPath + "\\data\\" + comboBoxChon.SelectedItem.ToString() + ".xml";
            ReadXmlFile(s);
        }

        public void ReadXmlFile(string FileName)
        {
           
                XElement xDoc = XElement.Load(FileName);
                List<CongTy> congTy = (from q in xDoc.Elements("CONG_TY")
                                       select new CongTy
                                       {
                                           CongTyList = q.Element("CHI_NHANH").Value,
                DON_VI = q.Element("DON_VI").Value,
                NHAN_VIEN = q.Element("NHAN_VIEN").Value

                                       }).ToList();
            foreach(CongTy ct in congTy)
            {
                    listBoxFile.Items.Add(ct.CongTyList + "\n" + ct.CHI_NHANH + "\n" + ct.DON_VI + "\n" + ct.NHAN_VIEN + "\n");

            }
           
        }
    }
}
