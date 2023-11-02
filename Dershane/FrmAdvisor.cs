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
    public partial class FrmAdvisor : Form
    {
        public FrmAdvisor()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl=new Sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Advisor where AdvisorId=@p1 and AdvisorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdvisorId.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdvisorSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAdvisorDetay frm = new FrmAdvisorDetay();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış şifre veya Id girdiniz ! ");
            }
            bgl.baglanti().Close();
        }
    }
}
