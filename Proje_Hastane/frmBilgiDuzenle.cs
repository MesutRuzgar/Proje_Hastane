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
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcNo;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTcNo.Text = tcNo;
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1" ,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tbxAd.Text = dr[1].ToString();
                tbxSoyad.Text = dr[2].ToString();
                mskTelNo.Text = dr[4].ToString();
                tbxSifre.Text = dr[5].ToString();
                cbxCinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 Where HastaTc=@p6",bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1",tbxAd.Text);
            komut2.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelNo.Text);
            komut2.Parameters.AddWithValue("@p4", tbxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cbxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6",mskTcNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
