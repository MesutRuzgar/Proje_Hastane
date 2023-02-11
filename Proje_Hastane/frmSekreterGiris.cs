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

namespace Proje_Hastane
{
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter Where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", mtbxTcNo.Text);
            komut.Parameters.AddWithValue("@p2", tbxSıfre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
              
                frmSekreterDetay frs = new frmSekreterDetay();
              frs.TcNo = mtbxTcNo.Text;
            
              frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();

        }
    }
}
