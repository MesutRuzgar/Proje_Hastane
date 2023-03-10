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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TC;

        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTcNo.Text = TC;
            SqlCommand komut = new SqlCommand("Select * from tbl_doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tbxAd.Text = dr[1].ToString();
                tbxSoyad.Text = dr[2].ToString();
                cbxBrans.Text = dr[3].ToString();
                tbxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tbxAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cbxBrans.Text);
            komut.Parameters.AddWithValue("@p4", tbxSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTcNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
