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
    public partial class He_Thong : Form
    {
        public He_Thong()
        {
            InitializeComponent();
            load1();
            load2();
            load3();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");
        SqlDataAdapter sda = null;
        void load1()
        {
            sda = new SqlDataAdapter("Select * from HLV ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "HLV");
            dataGridView1.DataSource = ds.Tables["HLV"];
        }
        void load2()
        {
            sda = new SqlDataAdapter("Select * from THANHVIEN ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "THANHVIEN");
            dataGridView2.DataSource = ds.Tables["THANHVIEN"];
        }
        void load3()
        {
            sda = new SqlDataAdapter("Select * from THE ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "THE");
            dataGridView3.DataSource = ds.Tables["THE"];
        }
        private void ThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhVien frm = new ThanhVien();
            frm.Show();
        }

        private void HLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HLV frm = new HLV();
            frm.Show();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau frm = new DoiMatKhau();
            frm.Show();
        }

        private void ThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            The frm = new The();
            frm.Show();
        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBox frm = new CheckBox();
            frm.Show();
        }
    }
}
