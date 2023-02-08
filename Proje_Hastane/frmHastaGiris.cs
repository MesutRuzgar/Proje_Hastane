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
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit fr = new frmHastaKayit();
            fr.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",mtbxTcNo.Text);
            komut.Parameters.AddWithValue("@p2",tbxSıfre.Text);
            SqlDataReader dr =komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay();
                fr.tc = mtbxTcNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC No ya da Şifre","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
