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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
            load();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        SqlDataAdapter sda = null;
        void load()
        {
            sda = new SqlDataAdapter(" SELECT * FROM v_QuanLy ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "v_QuanLy");
            dataGridView1.DataSource = ds.Tables["v_QuanLy"];
        }
        void load1()
        {
            conn.Open();
            string cmd = "SELECT * FROM v_QuanLy ";
            SqlCommand scmd = new SqlCommand(cmd);
            List<QuanLy1> listnv = new List<QuanLy1>();
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(data);
            foreach (DataRow items in data.Rows)
            {
                QuanLy1 nhanvien = new QuanLy1(items);
                listnv.Add(nhanvien);
            }
            conn.Close();
            dataGridView1.DataSource = QuickSort(listnv, 0, listnv.Count - 1);
        }
        List<QuanLy1> QuickSort(List<QuanLy1> a, int left, int right)
        {
            int i, j;
            float x;
            x = a[(left + right) / 2].Diem1;
            i = left; j = right;
            while (i < j)
            {
                while (a[i].Diem1 > x) i++;
                while (a[j].Diem1 < x) j--;
                if (i <= j)
                {
                    QuanLy1 tam;
                    tam = a[i];
                    a[i] = a[j];
                    a[j] = tam;
                    i++;
                    j--;
                }

            }
            if (left < j)
                QuickSort(a, left, j);
            if (i < right)
                QuickSort(a, i, right);
            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ma = textBox1.Text;
            conn.Open();
            sda = new SqlDataAdapter("SELECT MAHD,TENTV,TENHLV,TENTHE,NGAY_KICH_HOAT,NGAY_HET_HAN,DIEM,XEPHANG FROM THANHVIEN,QUANLY,HLV,THE WHERE THANHVIEN.MATV = QUANLY.MATV AND HLV.MAHLV = QUANLY.MAHLV AND THE.MATHE = QUANLY.MATHE AND QUANLY.MATV = '" + Ma + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "v_QuanLy");
            conn.Close();
            dataGridView1.DataSource = ds.Tables["v_QuanLy"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            He_Thong frm = new He_Thong();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
