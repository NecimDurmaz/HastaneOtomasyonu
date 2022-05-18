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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti sql = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
        SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2",sql.baglanti());
        cmd.Parameters.AddWithValue("@p1",mskdTC.Text);
        cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
        SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
               FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tc=mskdTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ve ya Sifre");
            }
           

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
