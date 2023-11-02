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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl=new Sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Ogrenciler where OgrenciID=@p1 and OgrenciSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtOgrenciID.Text);
            komut.Parameters.AddWithValue("@p2",TxtOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) {
            FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Yanlış şifre veya Id numarası ! ");
            }
            bgl.baglanti().Close();
        }
    }
}
