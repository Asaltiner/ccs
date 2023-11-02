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
    public partial class FrmOdemeTakipTablosu : Form
    {
        public FrmOdemeTakipTablosu()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl=new Sqlbaglanti();  

        private void FrmOdemeTakipTablosu_Load(object sender, EventArgs e)
        {
            
            DataTable dt=new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_OdemeTakip",bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

           
           
        }
    }
}
