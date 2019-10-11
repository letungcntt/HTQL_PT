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
    public partial class HLV : Form
    {
        public HLV()
        {
            InitializeComponent();
            load();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        SqlDataAdapter sda = null;
        void load()
        {
            sda = new SqlDataAdapter("Select * from HLV ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "HLV");
            dataGridView1.DataSource = ds.Tables["HLV"];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string MaHLV = textBox6.Text;
            sda = new SqlDataAdapter("Select * from HLV where MAHLV like '" + MaHLV + "'", conn);
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
            conn.Open();
            string MaHLV = textBox1.Text;
            DateTime NgaySinh = dateTimePicker1.Value;
            string HoTen = textBox2.Text;
            string DiaChi = textBox4.Text;
            string SDT = textBox5.Text;
            string GioiTinh = textBox6.Text;
            if (MaHLV.Length == 0 || HoTen.Length == 0 || DiaChi.Length == 0 || SDT.Length == 0 || GioiTinh.Length == 0)
                MessageBox.Show("Xin Mời Nhập Đủ Dữ Liệu !");
            else
            {
                try
                {
                    string Insert_Query = "INSERT INTO HLV VALUES (N'" + MaHLV + "',N'" + HoTen + "','" + dateTimePicker1.Value + "',N'" + DiaChi + "','" + SDT + "',N'" + GioiTinh + "')";
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

        private void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string MaHLV = textBox1.Text;
            string HoTen = textBox2.Text;
            string DiaChi = textBox4.Text;
            string SDT = textBox5.Text;
            string GioiTinh = textBox6.Text;
            string Insert_Query = ("UPDATE THANHVIEN SET TENTV = N'" + HoTen + "',NAMSINH = '" + dateTimePicker1.Value + "', DIACHI = N'" + DiaChi + "', SDT = '" + SDT + "', GIOI_TINH = N'" + GioiTinh + "' WHERE MATV = '" + MaHLV + "'");
            SqlCommand cmd = new SqlCommand(Insert_Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chỉnh sửa thành công!");
            conn.Close();
            load();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string MaTV = textBox1.Text;
            if (MaTV.Length == 0)
                MessageBox.Show("Xin Mời Nhập Mã Thành Viên");
            else
            {
                string Select_Query = "SELECT COUNT(*) FROM HLV WHERE MAHLV ='" + MaTV + "'";
                SqlCommand cmd = new SqlCommand(Select_Query, conn);
                string a = cmd.ExecuteScalar().ToString();
                if (a == "1")
                {
                    string Insert_Query = (" DELETE HLV WHERE MAHLV ='" + MaTV + "'");
                    SqlCommand cmd1 = new SqlCommand(Insert_Query, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(" XOÁ THÀNH CÔNG !");
                }
                else
                    MessageBox.Show("Xoá Dữ Liệu Thất Bại !");
            }
            conn.Close();
            load();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            He_Thong frm = new He_Thong();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void HLV_Load(object sender, EventArgs e)
        {

        }
    }
}
