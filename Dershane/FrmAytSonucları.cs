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
    public partial class FrmAytSonucları : Form
    {
        public FrmAytSonucları()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");


        private void verigetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AytTakip",baglanti);
            SqlDataReader okuyucu=komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrenciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString());
                ekle.SubItems.Add(okuyucu["TarihDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TarihYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Dogru"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Yanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FizikDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FizikYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiDogru"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AytTakip where OgrenciAd like @p1", baglanti);
            komut.Parameters.AddWithValue("@p1","%"+TxtOgrAd.Text+"%");
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrenciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString());
                ekle.SubItems.Add(okuyucu["TarihDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TarihYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Dogru"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Yanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FizikDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FizikYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiDogru"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AytTakip where DenemeAd like @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", "%" + TxtDenemeAd.Text + "%");
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrenciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString());
                ekle.SubItems.Add(okuyucu["TarihDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TarihYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["CografyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["EdebiyatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Dogru"].ToString());
                ekle.SubItems.Add(okuyucu["Mat2Yanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FizikDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FizikYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaDogru"].ToString());
                ekle.SubItems.Add(okuyucu["KimyaYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiDogru"].ToString());
                ekle.SubItems.Add(okuyucu["BiyolojiYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
