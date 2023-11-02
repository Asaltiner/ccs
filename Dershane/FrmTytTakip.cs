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
    public partial class FrmTytTakip : Form
    {
        public FrmTytTakip()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");

        private void FrmTytTakip_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TytTakip (OgrnciAd,OgrenciSoyad,DenemeAd,TurkceDogru,TurkceYanlıs,SosyalDogru,SosyalYanlıs,MatDogru,MatYanlıs,FenDogru,FenYanlıs) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtDenemeAd.Text);
            komut.Parameters.AddWithValue("@p4", TxtTurkceD.Text);
            komut.Parameters.AddWithValue("@p5", TxtTurkceY.Text);
            komut.Parameters.AddWithValue("@p6", TxtSosyalD.Text);
            komut.Parameters.AddWithValue("@p7", TxtSosyalY.Text);
            komut.Parameters.AddWithValue("@p8", TxtMatemetikD.Text);
            komut.Parameters.AddWithValue("@p9", TxtMatemetikY.Text);
            komut.Parameters.AddWithValue("@p10", TxtFenD.Text);
            komut.Parameters.AddWithValue("@p11", TxtFenY.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydedildi ! ");

            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            TxtDenemeAd.Clear();
            TxtTurkceD.Clear();
            TxtTurkceY.Clear();
            TxtSosyalD.Clear();
            TxtSosyalY.Clear();
            TxtMatemetikD.Clear();
            TxtMatemetikY.Clear();
            TxtFenD.Clear();
            TxtFenY.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            TxtDenemeAd.Clear();
            TxtTurkceD.Clear    ();
            TxtTurkceY.Clear ();
            TxtSosyalD.Clear ();
            TxtSosyalY.Clear ();
            TxtMatemetikD.Clear ();
            TxtMatemetikY.Clear ();
            TxtFenD.Clear ();
            TxtFenY.Clear ();
        }
    }
}
