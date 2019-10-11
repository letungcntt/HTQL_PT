using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HTQL_DenDuong_D12CNPM2
{
    class ThanhVien1
    {
        private string MaTV;
        private string TenTV;
        private DateTime NamSinh;
        private string DiaChi;
        private int SDT;
        private string GioiTinh;
        private int Diem;
        private string XepHang;

        public ThanhVien1(DataRow row)
        {
            this.MaTV = row["MATV"].ToString();
            this.TenTV = row["TENTV"].ToString();
            this.NamSinh = (DateTime)row["NAMSINH"];
            this.GioiTinh = row["GIOI_TINH"].ToString();
            this.DiaChi = row["DIACHI"].ToString(); ;
            this.Diem = (int)Convert.ToDouble(row["DIEM"].ToString());
            this.XepHang = row["XepHang"].ToString();
        }

        public string MaTV1 { get => MaTV; set => MaTV = value; }
        public string TenTV1 { get => TenTV; set => TenTV = value; }
        public DateTime NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int Diem1 { get => Diem; set => Diem = value; }
        public string XepHang1 { get => XepHang; set => XepHang = value; }
    }
}
