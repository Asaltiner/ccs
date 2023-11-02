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
    public partial class FrmOgrenciKayıtYapma : Form
    {
        public FrmOgrenciKayıtYapma()
        {
            InitializeComponent();
        }

      Sqlbaglanti bgl=new Sqlbaglanti();

        private void BtnÖğrenciOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenciler (OgrenciAd,OgrenciSoyad,VeliAdSoyad,VeliCepNumara,OgrenciSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtÖğrenciAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtÖğrenciSoyad.Text);
            komut.Parameters.AddWithValue("@p3",TxtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p4",TxtVeliCepNumara.Text);
            komut.Parameters.AddWithValue("@p5", TxtÖğrenciSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi ! ");


        }

        private void BtnÖğrenciTemizle_Click(object sender, EventArgs e)
        {
            TxtÖğrenciAd.Text = "";
            TxtÖğrenciSoyad.Text = "";
            TxtVeliAdSoyad.Text = "";
            TxtVeliCepNumara.Text = "";
            TxtÖğrenciSifre.Text = "";
        }
    }
}
