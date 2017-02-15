using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;

namespace demoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String FileName;

       
        private void WriteToXml()
        {
            XDocument xmlDoc = XDocument.Load(FileName);
            xmlDoc.Element("CONG_TY").Add(
                new XElement("CHI_NHANH", textChiNhanh.Text),
                new XElement("DON_VI",textDonVi.Text),
                new XElement("NHAN_VIEN",textNhanVien.Text)
                );
            xmlDoc.Save(FileName);
        }

        private void ResetTextBox()
        {
            textChiNhanh.Text = "";
            textDonVi.Text = "";
            textNhanVien.Text = "";
            textChiNhanh.Focus();
        }

        public bool key = false;

        private void buttonTiep_Click(object sender, EventArgs e)
        {
            if(key == false)
            {
                XDocument xdoc = new XDocument(
                    new XElement("CONG_TY",
                        new XElement("CHI_NHANH",textChiNhanh.Text),
                        new XElement("DON_VI",textDonVi.Text),
                        new XElement("NHAN_VIEN",textNhanVien.Text)
                        )

                    );

                key = true;
                SaveFileDialog sFileD = new SaveFileDialog();
                sFileD.Filter = "XML file(*.xml)|*.xml";
                sFileD.RestoreDirectory = true;
                if(sFileD.ShowDialog() == DialogResult.OK)
                {
                    FileName = sFileD.FileName;
                }
                if(FileName == "")
                {
                    return;
                }
                xdoc.Save(FileName);
                ResetTextBox();
            }
            else
            {
                WriteToXml();
                ResetTextBox();
            }
        }

        private void buttonGhi_Click_1(object sender, EventArgs e)
        {
            ReadXml rx = new ReadXml();
            rx.Show();
        }
    }
}
