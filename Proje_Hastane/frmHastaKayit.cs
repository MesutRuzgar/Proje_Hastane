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
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            sqlBaglantisi bgl = new sqlBaglantisi();

            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", tbxAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTcNo.Text);
            komut.Parameters.AddWithValue("@p4", mskTelNo.Text);
            komut.Parameters.AddWithValue("@p5", tbxSifre.Text);
            komut.Parameters.AddWithValue("@p6", cbxCinsiyet.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız Başarıyla Gerçekleştirilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
