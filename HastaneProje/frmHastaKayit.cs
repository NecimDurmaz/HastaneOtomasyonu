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

namespace HastaneProje
{
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mskdTC.Text);
            komut.Parameters.AddWithValue("@p4",mskdTel.Text);
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
             sql.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide(); 
        }

        private void frmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
