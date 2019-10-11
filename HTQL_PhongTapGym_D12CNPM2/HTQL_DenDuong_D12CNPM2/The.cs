using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HTQL_DenDuong_D12CNPM2
{
    public partial class The : Form
    {
        public The()
        {
            InitializeComponent();
            load();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        SqlDataAdapter sda = null;

        void load()
        {
            sda = new SqlDataAdapter(" SELECT MAHD,TENTV,TENHLV,TENTHE,NGAY_KICH_HOAT,NGAY_HET_HAN,DIEM,XEPHANG FROM THANHVIEN,QUANLY,HLV,THE WHERE THANHVIEN.MATV = QUANLY.MATV AND HLV.MAHLV = QUANLY.MAHLV AND THE.MATHE = QUANLY.MATHE ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "THANHVIEN,QUANLY,HLV,THE");
            dataGridView1.DataSource = ds.Tables["THANHVIEN,QUANLY,HLV,THE"];
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string Ma = textBox1.Text;
            conn.Open();
            sda = new SqlDataAdapter("SELECT MAHD,TENTV,TENHLV,TENTHE,NGAY_KICH_HOAT,NGAY_HET_HAN,DIEM,XEPHANG FROM THANHVIEN,QUANLY,HLV,THE WHERE THANHVIEN.MATV = QUANLY.MATV AND HLV.MAHLV = QUANLY.MAHLV AND THE.MATHE = QUANLY.MATHE AND QUANLY.MATV = '" + Ma + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "HLV");
            dataGridView1.DataSource = ds.Tables["HLV"];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            He_Thong frm = new He_Thong();
            frm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
