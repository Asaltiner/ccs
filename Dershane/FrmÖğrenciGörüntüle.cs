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
    public partial class FrmÖğrenciGörüntüle : Form
    {
        public FrmÖğrenciGörüntüle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");

        private void FrmÖğrenciGörüntüle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogrenciler", baglanti);
            SqlDataReader okuyucu = komut.ExecuteReader();
            
            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["OgrenciID"].ToString();
                ekle.SubItems.Add(okuyucu["OgrenciAd"].ToString());
                ekle.SubItems.Add(okuyucu["OgrenciSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["VeliAdSoyad"].ToString());
                ekle.SubItems.Add(okuyucu["VeliCepNumara"].ToString());
                ekle.SubItems.Add(okuyucu["OgrenciSifre"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
