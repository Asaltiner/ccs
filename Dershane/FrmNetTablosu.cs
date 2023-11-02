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

namespace Dershane
{
    public partial class FrmNetTablosu : Form
    {
        public FrmNetTablosu()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmNetTablosu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_NetTakip",bgl.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
