using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            frmHastaGiris hastaGiris=new frmHastaGiris();
            hastaGiris.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktorgiris = new FrmDoktorGiris();
            doktorgiris.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
                frmSekreterGiris sekretergiris = new frmSekreterGiris();
            sekretergiris.Show();
            this.Hide();
            
        }
    }
}
