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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();
        public string tc;
        

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            // DOKTOR AD SOYAD ÇEKME

            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lblADSOYAD.Text=dr[0]+" "+dr[1];
            }
            sql.baglanti().Close();

            // RANDEVULAR
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+lblADSOYAD.Text+"'",sql.baglanti());
            da.Fill(dt); 
            dataGridView1.DataSource = dt;

        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDüzenle fr=  new frmDoktorBilgiDüzenle();
            fr.tc=lblTC.Text;
            fr.Show();
           
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            frmDuyurular fr= new frmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
