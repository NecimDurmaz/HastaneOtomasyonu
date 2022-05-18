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
    public partial class frmHastaBilgiDuzenle : Form
    {
        public frmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        SqlBaglanti sql =new SqlBaglanti();
        private void frmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdTC.Text=tcno;
            SqlCommand komut = new SqlCommand("Select *From Tbl_Hastalar where HastaTC=@p1",sql.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTC.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text=dr[1].ToString();
                txtSoyad.Text=dr[2].ToString();
                mskdTEL.Text=dr[4].ToString();
                txtSifre.Text=dr[5].ToString();
                cmbCinsiyet.Text=dr[6].ToString();

            }
            sql.baglanti().Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", sql.baglanti());

            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mskdTEL.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6",mskdTC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
