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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2",sql.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                frmSekreterDetay frs = new frmSekreterDetay();
                frs.TCno= mskdTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC ve ya Şifre");
            }
            sql.baglanti().Close();
        }

        private void frmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
