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
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void frmHastaGiris_Load(object sender, EventArgs e)
        {

        }
        SqlBaglanti sql = new SqlBaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit hastakayit = new frmHastaKayit();
            hastakayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2",sql.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay(); 
                fr.tc=mskdTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre ve ya TC Kimlik Numarası");

            }
            sql.baglanti().Close();
        }
    }
}
