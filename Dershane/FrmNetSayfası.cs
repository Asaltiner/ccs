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
    public partial class FrmNetSayfası : Form
    {
        public FrmNetSayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTytTakip frmTytTakip = new FrmTytTakip();
            frmTytTakip.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAytTakip frmAytTakip = new FrmAytTakip();
            frmAytTakip.Show();
        }
    }
}
