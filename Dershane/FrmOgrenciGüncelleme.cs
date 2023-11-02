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
    public partial class FrmOgrenciGüncelleme : Form
    {
        public FrmOgrenciGüncelleme()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmOgrenciGüncelleme_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter= new SqlDataAdapter("select * from Tbl_Ogrenciler",bgl.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgrenciID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtÖğrenciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtÖğrenciSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtVeliAdSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtVeliCepNumara.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtÖğrenciSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnÖğrenciGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Ogrenciler set OgrenciAd=@p1,OgrenciSoyad=@p2,VeliAdSoyad=@p3,VeliCepNumara=@p4,OgrenciSifre=@p5 where OgrenciID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtÖğrenciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtÖğrenciSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p4", TxtVeliCepNumara.Text);
            komut.Parameters.AddWithValue("@p5", TxtÖğrenciSifre.Text);
            komut.Parameters.AddWithValue("@p6",TxtOgrenciID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi ! ");

        }

        private void BtnÖğrenciTemizle_Click(object sender, EventArgs e)
        {
            TxtÖğrenciAd.Text = "";
            TxtÖğrenciSoyad.Text = "";
            TxtVeliAdSoyad.Text = "";
            TxtVeliCepNumara.Text = "";
            TxtÖğrenciSifre.Text = "";
            TxtOgrenciID.Text = "";
        }

        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_Ogrenciler where OgrenciID=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtOgrenciID.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Silindi ! ", "Uyarı ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
