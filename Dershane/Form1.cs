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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm = new FrmOgrenci();
            frm.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAdvisor frmAdvisor = new FrmAdvisor();
            frmAdvisor.Show();  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text=DateTime.Now.ToLongTimeString();
        }

       
    }
}
