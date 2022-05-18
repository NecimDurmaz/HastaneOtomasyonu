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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlBaglanti sql = new SqlBaglanti();
        public string TCno;

        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;
            
            // AD SOYAD ÇEKME
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTC=@p1",sql.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                lblAdSoyad.Text=dr1[0].ToString();

            }
            sql.baglanti().Close();



            // BRANŞLARI DATA GRİD AKTARMA
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", sql.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // DOKTORLARI LİSTEYE AKTARMA

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' ' +DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", sql.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Branşı combobox getirme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", sql.baglanti());
            SqlDataReader dr2 =komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbRBrans.Items.Add(dr2[0].ToString());
            }
            sql.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor)values (@r1,@r2,@r3,@r4)", sql.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskRTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskRSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbRBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbRDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmbRBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRDoktor.Items.Clear();
            cmbRDoktor.Text=" ";
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",sql.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbRBrans.Text);
            SqlDataReader dr= komut.ExecuteReader();

            while(dr.Read())
            {
                cmbRDoktor.Items.Add(dr[0]+" "+ dr[1]);
            }
            sql.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular(duyuru) values (@d1)", sql.baglanti());
            komut.Parameters.AddWithValue("@d1", rchtxtDuyuru.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Duyuru OLuşturuldu.");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli frm = new frmDoktorPaneli();
            frm.Show();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBrnasPanel_Click(object sender, EventArgs e)
        {
            frmBrans brans = new frmBrans();
            brans.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frm = new frmRandevuListesi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDuyurular frm=new frmDuyurular();
            frm.Show(); 
        }
    }
}
