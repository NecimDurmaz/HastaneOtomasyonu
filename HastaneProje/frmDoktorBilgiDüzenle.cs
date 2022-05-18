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
    public partial class frmDoktorBilgiDüzenle : Form
    {
        public frmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string tc;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        SqlBaglanti sql= new SqlBaglanti();

        public void güncelle()
        {

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAD.Text=dr[1].ToString();
                txtSoyad.Text=dr[2].ToString();
                cmbBrans.Text=dr[3].ToString();
                txtSifre.Text=dr[5].ToString();
            }
            sql.baglanti().Close();
        }
        private void frmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text =tc;

       güncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAD.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",txtSifre.Text);
            cmd.Parameters.AddWithValue("@p5",mskTC.Text);
            cmd.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
                güncelle();

        }
    }
}
