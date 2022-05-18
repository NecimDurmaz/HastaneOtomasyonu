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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }

        private void data()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Doktorlar", sql.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut=   new SqlCommand("Update Tbl_Doktorlar set Doktorad=@p1,Doktorsoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbRBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskRTC.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data();
        }

        SqlBaglanti sql = new SqlBaglanti();
        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", sql.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbRBrans.Items.Add(dr2[0].ToString());
            }
            sql.baglanti().Close();
            data();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)",sql.baglanti());
            komut.Parameters.AddWithValue("@d1",txtAd.Text);
            komut.Parameters.AddWithValue("@d2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3",cmbRBrans.Text);
            komut.Parameters.AddWithValue("@d4",mskRTC.Text);
            komut.Parameters.AddWithValue("@d5",txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            data();


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilenindex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenindex].Cells[2].Value.ToString();
            cmbRBrans.Text = dataGridView1.Rows[secilenindex].Cells[3].Value.ToString();
            mskRTC.Text = dataGridView1.Rows[secilenindex].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilenindex].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1",sql.baglanti());
            komut.Parameters.AddWithValue("@p1",mskRTC.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            data();
        }
    }
}
