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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        private void Button1_Click(object sender, EventArgs e)
        {
            string TaiKhoan = textBox1.Text;
            string MatKhau = textBox2.Text;
            if (TaiKhoan.Length == 0 || MatKhau.Length == 0)
                MessageBox.Show(" Hãy Điền đầy đủ thông tin !");
            else
            {
                conn.Open();
                string Select_Query = "SELECT COUNT(*) FROM ID WHERE TK='" + TaiKhoan + "' AND MK='" + MatKhau + "'";
                SqlCommand cmd = new SqlCommand(Select_Query, conn);
                string a = cmd.ExecuteScalar().ToString();
                if (a == "1")
                {
                    label4.Text = "Đăng Nhập Thành Công !";
                    MessageBox.Show("Xin Chào Bạn đã đăng nhập vào hệ thống !");
                    this.Hide();
                    He_Thong frm = new He_Thong();
                    frm.Show();
                    frm.lbten.Text = "Chào " + TaiKhoan;
                }
                else
                    label4.Text = "Tên đăng nhập hoặc mật khẩu không đúng !";
                conn.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AddAccount frm = new AddAccount();
            frm.Show();
        }
    }
}
