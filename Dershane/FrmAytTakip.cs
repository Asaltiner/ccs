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
    public partial class FrmAytTakip : Form
    {
        public FrmAytTakip()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AytTakip (OgrenciAd,OgrenciSoyad,DenemeAd,TarihDogru,TarihYanlıs,CografyaDogru,CografyaYanlıs,EdebiyatDogru,EdebiyatYanlıs,Mat2Dogru,Mat2Yanlıs,FizikDogru,FizikYanlıs,KimyaDogru,KimyaYanlıs,BiyolojiDogru,BiyolojiYanlıs) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17) ", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtDenemeAd.Text);
            komut.Parameters.AddWithValue("@p4", TxtTarihD.Text);
            komut.Parameters.AddWithValue("@p5", TxtTarihY.Text);
            komut.Parameters.AddWithValue("@p6", TxtCografyaD.Text);
            komut.Parameters.AddWithValue("@p7", TxtCografyaY.Text);
            komut.Parameters.AddWithValue("@p8", TxtEdebiyatD.Text);
            komut.Parameters.AddWithValue("@p9", TxtEdebiyatY.Text);
            komut.Parameters.AddWithValue("@p10", TxtMat2D.Text);
            komut.Parameters.AddWithValue("@p11", TxtMat2Y.Text);
            komut.Parameters.AddWithValue("@p12", TxtFizikD.Text);
            komut.Parameters.AddWithValue("@p13", TxtFizikY.Text);
            komut.Parameters.AddWithValue("@p14", TxtKimyaD.Text);
            komut.Parameters.AddWithValue("@p15", TxtKimyaY.Text);
            komut.Parameters.AddWithValue("@p16", TxtBiyolojiD.Text);
            komut.Parameters.AddWithValue("@p17", TxtBiyolojiY.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı ! ");

            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            TxtDenemeAd.Clear();
            TxtTarihD.Clear();
            TxtTarihY.Clear();
            TxtCografyaD.Clear();
            TxtCografyaY.Clear();
            TxtEdebiyatD.Clear();
            TxtCografyaY.Clear();
            TxtMat2D.Clear();
            TxtMat2Y.Clear();
            TxtFizikD.Clear();
            TxtFizikY.Clear();
            TxtKimyaD.Clear();
            TxtKimyaY.Clear();
            TxtBiyolojiD.Clear();
            TxtBiyolojiY.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            TxtDenemeAd.Clear();
            TxtTarihD.Clear();
            TxtTarihY.Clear();
            TxtCografyaD.Clear();
            TxtCografyaY.Clear();
            TxtEdebiyatD.Clear();
          TxtEdebiyatY.Clear();
            TxtMat2D.Clear();
            TxtMat2Y.Clear();
            TxtFizikD.Clear();
            TxtFizikY.Clear();
            TxtKimyaD.Clear();
            TxtKimyaY.Clear();
            TxtBiyolojiD.Clear();
            TxtBiyolojiY.Clear();

        }
    }
}
