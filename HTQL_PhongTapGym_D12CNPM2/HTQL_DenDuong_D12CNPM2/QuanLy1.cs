using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HTQL_DenDuong_D12CNPM2
{
    class QuanLy1
    {
        private string mahd;
        private string TENTV;
        private string TENHLV;
        private string TENTHE;
        private string XepHang;
        private int Diem;

        public QuanLy1(DataRow row)
        {
            this.mahd = row["MAHD"].ToString();
            this.TENTV = row["TENTV"].ToString();
            this.TENHLV = row["TENHLV"].ToString();
            this.TENTHE = row["TENTHE"].ToString(); ;
            this.Diem = (int)Convert.ToDouble(row["DIEM"].ToString());
            this.XepHang = row["XepHang"].ToString();
        }
        public string Mahd1 { get => mahd; set => mahd = value; }

        public string XepHang1 { get => XepHang; set => XepHang = value; }
        public int Diem1 { get => Diem; set => Diem = value; }
        public string TENTV1 { get => TENTV; set => TENTV = value; }
        public string TENHLV1 { get => TENHLV; set => TENHLV = value; }
        public string TENTHE1 { get => TENTHE; set => TENTHE = value; }
    }
}
