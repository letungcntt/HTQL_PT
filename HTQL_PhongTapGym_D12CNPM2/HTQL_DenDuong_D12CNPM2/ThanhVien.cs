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
    public partial class ThanhVien : Form
    {
        public ThanhVien()
        {
            InitializeComponent();
            load();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        SqlDataAdapter sda = null;
        void load()
        {
            sda = new SqlDataAdapter(" SELECT * FROM THANHVIEN", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "THANHVIEN");
            dataGridView1.DataSource = ds.Tables["THANHVIEN"];
        }
        List<ThanhVien1> QuickSort(List<ThanhVien1> a, int left, int right)
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
                    ThanhVien1 tam;
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

        void load1() {
            conn.Open();
            string cmd = "SELECT * FROM THANHVIEN ";
            SqlCommand scmd = new SqlCommand(cmd);
            List<ThanhVien1> listnv = new List<ThanhVien1>();
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(data);
            foreach (DataRow items in data.Rows)
            {
                ThanhVien1 nhanvien = new ThanhVien1(items);
                listnv.Add(nhanvien);
            }
            conn.Close();
            dataGridView1.DataSource = QuickSort(listnv, 0, listnv.Count - 1);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string MaTV = textBox1.Text;
            DateTime NgaySinh = dgvnamsinh.Value;
            string HoTen = textBox2.Text;
            string DiaChi = textBox4.Text;
            string SDT = textBox5.Text;
            string GioiTinh = textBox6.Text;
            string Diem = textBox7.Text;
            string XepHang = textBox8.Text;
            if (MaTV.Length == 0 || HoTen.Length == 0 || DiaChi.Length == 0 || SDT.Length == 0 || GioiTinh.Length == 0 || Diem.Length == 0 ||XepHang.Length == 0)
                MessageBox.Show("Xin Mời Nhập Đủ Dữ Liệu !");
            else
            {
                try
                {
                    string Insert_Query = "INSERT INTO THANHVIEN (MATV,TENTV,NAMSINH,DIACHI,SDT,GIOI_TINH,DIEM) VALUES (N'" + MaTV + "',N'" + HoTen + "','" + dgvnamsinh.Value + "',N'" + DiaChi + "','" + SDT + "',N'" + GioiTinh +"','"+ Diem +"')";
                    SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch
                {
                    MessageBox.Show("Thêm Mới Thất Bại !");
                }

            }
            load();
            conn.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            He_Thong frm = new He_Thong();
            frm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string MaTV = textBox3.Text;
            sda = new SqlDataAdapter("Select * from THANHVIEN where MATV like '" + MaTV + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "THANHVIEN");
            dataGridView1.DataSource = ds.Tables["THANHVIEN"];
            int Diem = int.Parse(textBox7.Text);
            if(Diem >= 750)
            {
                MessageBox.Show("Bạn Đã Hoàn Thành Tốt Quá Trình Tập luyện !");
                MessageBox.Show("Chế Độ Luyện Tập Hợp Lý !");
            }
            else
            {
                if (Diem < 750 && Diem >= 500)
                {
                    MessageBox.Show("Bạn Đã Hoàn Thành Quá Trình Tập luyện !");
                    MessageBox.Show("Chế Độ Luyện Tập Hợp Lý , Hãy Tăng Cường Tập Luyện !");
                }
                if (Diem < 500 && Diem >= 250)
                {
                    MessageBox.Show("Bạn Chưa Hoàn Thành Quá Trình Tập luyện !");
                    MessageBox.Show("Chế Độ Luyện Tập Chưa Hợp Lý , Hãy Tăng Cường Tập Luyện , Yêu Cầu Tăng Thời Gian !");
                }
                else
                {
                    MessageBox.Show("Bạn Đã Không Hoàn Thành Quá Trình Tập luyện !");
                    MessageBox.Show("Chế Độ Luyện Tập Chưa Hợp Lý , Hãy Tăng Cường Tập Luyện Thêm Rất Nhiều !");
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string MaTV = textBox1.Text;
            string HoTen = textBox2.Text;
            string DiaChi = textBox4.Text;
            string SDT = textBox5.Text;
            string GioiTinh = textBox6.Text;
            string Diem = textBox7.Text;
            string XepHang = textBox8.Text;
            string Insert_Query = ("UPDATE THANHVIEN SET TENTV = N'" + HoTen + "',NAMSINH = '" + dgvnamsinh.Value + "', DIACHI = N'" + DiaChi + "', SDT = '" + SDT + "', GIOI_TINH = N'" + GioiTinh +"',DIEM = '"  + Diem + "' WHERE MATV = '" + MaTV + "'" );
            SqlCommand cmd = new SqlCommand(Insert_Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chỉnh sửa thành công!");
            conn.Close();
            load();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
                conn.Open();
                string MaTV = textBox1.Text;
                if (MaTV.Length == 0)
                    MessageBox.Show("Xin Mời Nhập Mã Thành Viên");
                else
                {
                    string Select_Query = "SELECT COUNT(*) FROM THANHVIEN WHERE MATV ='" + MaTV + "'";
                    SqlCommand cmd = new SqlCommand(Select_Query,conn);
                    string a = cmd.ExecuteScalar().ToString();
                    if (a == "1")
                    {
                        string Insert_Query = (" DELETE THANHVIEN WHERE MATV ='" + MaTV + "'");
                        SqlCommand cmd1 = new SqlCommand(Insert_Query, conn);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show(" XOÁ THÀNH CÔNG !");
                    }
                    else
                        MessageBox.Show( "Xoá Dữ Liệu Thất Bại !") ;
                }
                conn.Close();
                load();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaTV = textBox1.Text;
            string HoTen = textBox2.Text;
            string DiaChi = textBox4.Text;
            string SDT = textBox5.Text;
            string GioiTinh = textBox6.Text;
            string Diem = textBox7.Text;
            string XepHang = textBox8.Text;
            textBox1.Text = dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dgvnamsinh.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(); 
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox7.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox8.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            load1();
        }
    }
}
