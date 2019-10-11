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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=HTQL; Integrated Security=SSPI");

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            He_Thong frm = new He_Thong();
            frm.Show();
        }
    }
}
