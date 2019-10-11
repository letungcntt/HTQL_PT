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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-RNMTB5H\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string TaiKhoan = textBox1.Text;

            string MatKhau1 = textBox2.Text;

            string MatKhau2 = textBox3.Text;

            string Ten = textBox4.Text;

            if (TaiKhoan.Length == 0 || MatKhau1.Length == 0 || MatKhau2.Length == 0 || Ten.Length == 0)
                MessageBox.Show("Xin Mời Nhập Đủ Dữ Liệu !");
            else
            {
                if (MatKhau1 == MatKhau2)
                {
                    string Insert_Query = "INSERT INTO ID(TK,MK,TEN) VALUES (N'" + TaiKhoan + "',N'" + MatKhau2 + "','" + Ten + "')";
                    SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                    cmd.ExecuteNonQuery();
                    label7.Text = " Đã Tạo Mới Tài Khoản !";
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                    label7.Text = " Tạo Mới Thất Bại !";
                    
            }
            conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
