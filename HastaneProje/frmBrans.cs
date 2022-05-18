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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();

        public void data()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", sql.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmBrans_Load(object sender, EventArgs e)
        {
            data();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)",sql.baglanti());
            komut1.Parameters.AddWithValue("b1", txtAd.Text);
            komut1.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Brans Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
       }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From tbl_Branslar where Bransid=@b1", sql.baglanti());
            komut.Parameters.AddWithValue("@b1", txtID.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Branş Silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            data();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2",sql.baglanti());
            komut.Parameters.AddWithValue("@b1", txtAd.Text);
            komut.Parameters.AddWithValue("@b2", txtID.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data();
        }
    }
}
