using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhXML_2
{
    class GiaoVien
    {
        string maGV, hoGV, tenGV, ngaySinh, gioiTinh, diaChi, maMH;

        public GiaoVien(string maGV, string hoGV, string tenGV, string ngaySinh, 
                        string gioiTinh, string diaChi, string maMH)
        {
            this.maGV = maGV;
            this.hoGV = hoGV;
            this.tenGV = tenGV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.maMH = maMH;
        }

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        public string HoGV
        {
            get { return hoGV; }
            set { hoGV = value; }
        }

        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }      
    }
}
