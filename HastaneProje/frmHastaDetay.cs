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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        
        public void randevu()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC="+tc, sql.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void randevu2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter("Select * From Tbl_Randevular where  RandevuBrans='"+cmbBrans.Text+"'"+"and RandevuDoktor='"+cmbDoktor.Text+"' and RandevuDurum=0", sql.baglanti());
            d.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        SqlBaglanti sql = new SqlBaglanti();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            // Ad Soyad Çekme
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",sql.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr=komut.ExecuteReader();

            while (dr.Read())
            {
                LblADSOYAD.Text=dr[0] +" "+ dr[1];      
            }

            // Randevu Geçmişi
           
            randevu();

            // Branş Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", sql.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = " ";
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", sql.baglanti());
            
            komut3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            
            while(dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }


        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevu2();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaBilgiDuzenle fr= new frmHastaBilgiDuzenle();
            fr.tcno = LblTC.Text;
            fr.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int  ID_Deger;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            ID_Deger = Convert.ToInt32(dataGridView2.Rows[secilen].Cells[0].Value);
           
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3 ", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            cmd.Parameters.AddWithValue("@p2", rchtxtSikayet.Text);
            cmd.Parameters.AddWithValue("@p3", ID_Deger);
            cmd.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Randevu Alindi.","Uyari",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            randevu();
            randevu2();

        }
    }
}
