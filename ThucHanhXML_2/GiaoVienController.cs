using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThucHanhXML_2
{
    class GiaoVienController
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"E:\XML\ThucHanhXML_2\ThucHanhXML_2\GiaoVien.xml";
        List<GiaoVien> list;

        public GiaoVienController()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void loadDataFromDoc(XmlDocument doc, string fileName, List<GiaoVien> list)
        {
            doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList lvNode = doc.GetElementsByTagName("GIAOVIEN");

            foreach (XmlNode node in lvNode)
            {
                string maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH;

                maGV = node.ChildNodes[0].InnerText;                
                hoGV = node.ChildNodes[1].InnerText;
                tenGV = node.ChildNodes[2].InnerText;
                ngaySinh = node.ChildNodes[3].InnerText;
                gioiTinh = node.ChildNodes[4].InnerText;
                diaChi = node.ChildNodes[5].InnerText;
                maMH = node.ChildNodes[6].InnerText;

                GiaoVien gv = new GiaoVien(maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH);
                list.Add(gv);
            }
        }

        public void getGiaoVienNu(XmlDocument doc, string fileName, List<GiaoVien> list)
        {
            doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList lvNode = doc.GetElementsByTagName("GIAOVIEN");

            foreach (XmlNode node in lvNode)
            {
                string maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH;

                maGV = node.ChildNodes[0].InnerText;
                hoGV = node.ChildNodes[1].InnerText;
                tenGV = node.ChildNodes[2].InnerText;
                ngaySinh = node.ChildNodes[3].InnerText;
                gioiTinh = node.ChildNodes[4].InnerText;
                diaChi = node.ChildNodes[5].InnerText;
                maMH = node.ChildNodes[6].InnerText;

                if (gioiTinh == "Nu")
                {
                    GiaoVien gv = new GiaoVien(maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH);
                    list.Add(gv);
                }
            }
        }

        public void getAngGiang(XmlDocument doc, string fileName, List<GiaoVien> list)
        {
            doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList lvNode = doc.GetElementsByTagName("GIAOVIEN");

            foreach (XmlNode node in lvNode)
            {
                string maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH;

                maGV = node.ChildNodes[0].InnerText;
                hoGV = node.ChildNodes[1].InnerText;
                tenGV = node.ChildNodes[2].InnerText;
                ngaySinh = node.ChildNodes[3].InnerText;
                gioiTinh = node.ChildNodes[4].InnerText;
                diaChi = node.ChildNodes[5].InnerText;
                maMH = node.ChildNodes[6].InnerText;

                if (diaChi == "Ang Giang")
                {
                    GiaoVien gv = new GiaoVien(maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH);
                    list.Add(gv);
                }
            }
        }
    }
}
