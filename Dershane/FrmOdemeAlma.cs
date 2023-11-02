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
    public partial class FrmOdemeAlma : Form
    {
        public FrmOdemeAlma()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");

        private void FrmOdemeAlma_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_OdemeTakip", baglanti);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrenciAdSoyad"].ToString();
                ekle.SubItems.Add(okuyucu["KayıtTutarı"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit1"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit2"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit3"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit4"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit5"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit6"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit7"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit8"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit9"].ToString());
                ekle.SubItems.Add(okuyucu["Taksit10"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Tbl_OdemeTakip (OgrenciAdSoyad,KayıtTutarı,Taksit1,Taksit2,Taksit3,Taksit4,Taksit5,Taksit6,Taksit7,Taksit8,Taksit9,Taksit10) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut1.Parameters.AddWithValue("@p1", TxtÖğrenciAdSoyad.Text);
            komut1.Parameters.AddWithValue("@p2", TxtTutar.Text);
            komut1.Parameters.AddWithValue("@p3", textBox1.Text);
            komut1.Parameters.AddWithValue("@p4", textBox2.Text);
            komut1.Parameters.AddWithValue("@p5", textBox3.Text);
            komut1.Parameters.AddWithValue("@p6", textBox4.Text);
            komut1.Parameters.AddWithValue("@p7", textBox5.Text);
            komut1.Parameters.AddWithValue("@p8", textBox6.Text);
            komut1.Parameters.AddWithValue("@p9", textBox7.Text);
            komut1.Parameters.AddWithValue("@p10", textBox8.Text);
            komut1.Parameters.AddWithValue("@p11", textBox9.Text);
            komut1.Parameters.AddWithValue("@p12", textBox10.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydedildi ! ");
           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            TxtÖğrenciAdSoyad.Text = listView1.SelectedItems[0].SubItems[0].Text;
            TxtTutar.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[10].Text;
            textBox10.Text = listView1.SelectedItems[0].SubItems[11].Text;


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtÖğrenciAdSoyad.Clear();
            TxtTutar.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Tbl_OdemeTakip set  KayıtTutarı=@p2,Taksit1=@p3,Taksit2=@p4,Taksit3=@p5,Taksit4=@p6,Taksit5=@p7,Taksit6=@p8,Taksit7=@p9,Taksit8=@p10,Taksit9=@p11,Taksit10=@p12 where OgrenciAdSoyad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtÖğrenciAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2",TxtTutar.Text);
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox2.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.Parameters.AddWithValue("@p6", textBox4.Text);
            komut.Parameters.AddWithValue("@p7", textBox5.Text);
            komut.Parameters.AddWithValue("@p8", textBox6.Text);
            komut.Parameters.AddWithValue("@p9", textBox7.Text);
            komut.Parameters.AddWithValue("@p10", textBox8.Text);
            komut.Parameters.AddWithValue("@p11", textBox9.Text);
            komut.Parameters.AddWithValue("@p12", textBox10.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}
