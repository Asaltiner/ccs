using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane
{
    public partial class FrmAdvisorDetay : Form
    {
        public FrmAdvisorDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOdemeTakipTablosu frmOdemeTakipTablosu=new FrmOdemeTakipTablosu();
            frmOdemeTakipTablosu.Show();
        }

        private void BtnYeniÖğrencKayıt_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayıtYapma frmOgrenciKayıtYapma=new FrmOgrenciKayıtYapma();
            frmOgrenciKayıtYapma.Show();
        }

        private void BtnÖğrenciListele_Click(object sender, EventArgs e)
        {
            FrmÖğrenciGörüntüle frmÖğrenciGörüntüle=new FrmÖğrenciGörüntüle();
            frmÖğrenciGörüntüle.Show();
        }

        private void BtnÖğrenciSilme_Click(object sender, EventArgs e)
        {

        }

        private void BtnNetTakipSistemi_Click(object sender, EventArgs e)
        {
      FrmNetSayfası frmNetSayfası=new FrmNetSayfası();
            frmNetSayfası.Show();
        }

        private void BtnÖdemeAlma_Click(object sender, EventArgs e)
        {
            FrmOdemeAlma frmOdemeAlma =new FrmOdemeAlma();
            frmOdemeAlma.Show();
        }

        private void BtnNetTablosu_Click(object sender, EventArgs e)
        {
            FrmNetTablosu frmNetTablosu =new FrmNetTablosu();
            frmNetTablosu.Show();
        }

        private void BtnOgrenciGüncelle_Click(object sender, EventArgs e)
        {
            FrmOgrenciGüncelleme frmOgrenciGüncelleme= new FrmOgrenciGüncelleme();
            frmOgrenciGüncelleme.Show();
        }

        private void BtnTytSonucları_Click(object sender, EventArgs e)
        {
            FrmTytSonucları frmTytSonucları = new FrmTytSonucları();
            frmTytSonucları.Show();
        }

        private void BtnAytSonucları_Click(object sender, EventArgs e)
        {
            FrmAytSonucları frmAytSonucları = new FrmAytSonucları();
            frmAytSonucları .Show();
        }
    }
}
