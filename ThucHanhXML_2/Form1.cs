using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ThucHanhXML_2
{
    public partial class Form1 : Form
    {
        GiaoVienController handler = new GiaoVienController();
        XmlDocument doc = new XmlDocument();
        string fileName = @"E:\XML\ThucHanhXML_2\ThucHanhXML_2\GiaoVien.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            handler.loadDataFromDoc(doc, fileName, list);
            dataGridView1.Rows.Clear();
            int rowIndex = 0;
            foreach (GiaoVien item in list)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = item.MaGV;
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.HoGV;
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.TenGV;
                dataGridView1.Rows[rowIndex].Cells[3].Value = item.NgaySinh;
                dataGridView1.Rows[rowIndex].Cells[4].Value = item.GioiTinh;
                dataGridView1.Rows[rowIndex].Cells[5].Value = item.DiaChi;
                dataGridView1.Rows[rowIndex].Cells[6].Value = item.MaMH;

                rowIndex++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            handler.getGiaoVienNu(doc, fileName, list);
            dataGridView1.Rows.Clear();
            int rowIndex = 0;
            foreach (GiaoVien item in list)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = item.MaGV;
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.HoGV;
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.TenGV;
                dataGridView1.Rows[rowIndex].Cells[3].Value = item.NgaySinh;
                dataGridView1.Rows[rowIndex].Cells[4].Value = item.GioiTinh;
                dataGridView1.Rows[rowIndex].Cells[5].Value = item.DiaChi;
                dataGridView1.Rows[rowIndex].Cells[6].Value = item.MaMH;

                rowIndex++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            handler.getAngGiang(doc, fileName, list);
            dataGridView1.Rows.Clear();
            int rowIndex = 0;
            foreach (GiaoVien item in list)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = item.MaGV;
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.HoGV;
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.TenGV;
                dataGridView1.Rows[rowIndex].Cells[3].Value = item.NgaySinh;
                dataGridView1.Rows[rowIndex].Cells[4].Value = item.GioiTinh;
                dataGridView1.Rows[rowIndex].Cells[5].Value = item.DiaChi;
                dataGridView1.Rows[rowIndex].Cells[6].Value = item.MaMH;

                rowIndex++;
            }
        }
    }
}
