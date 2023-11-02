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
    public partial class FrmTytSonucları : Form
    {
        public FrmTytSonucları()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");

        private void verigetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TytTakip", baglanti);
            SqlDataReader okuyucu=komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text= okuyucu["OgrnciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString() );
                ekle.SubItems.Add(okuyucu["TurkceDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TurkceYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalDogru"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["MatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["MatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FenDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FenYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            verigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TytTakip where OgrnciAd like @p1", baglanti);
            komut.Parameters.AddWithValue("@p1","%"+ TxtOgrAd.Text+"%");
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrnciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString());
                ekle.SubItems.Add(okuyucu["TurkceDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TurkceYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalDogru"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["MatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["MatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FenDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FenYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TytTakip where DenemeAd like @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", "%" + TxtDenemeAd.Text + "%");
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrnciAd"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["DenemeAd"].ToString());
                ekle.SubItems.Add(okuyucu["TurkceDogru"].ToString());
                ekle.SubItems.Add(okuyucu["TurkceYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalDogru"].ToString());
                ekle.SubItems.Add(okuyucu["SosyalYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["MatDogru"].ToString());
                ekle.SubItems.Add(okuyucu["MatYanlıs"].ToString());
                ekle.SubItems.Add(okuyucu["FenDogru"].ToString());
                ekle.SubItems.Add(okuyucu["FenYanlıs"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
