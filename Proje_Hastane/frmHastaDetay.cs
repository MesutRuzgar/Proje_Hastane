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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }

        //global e tc atayıp girişten maskedboxtan tc yi buraya atadık ekrana yansıttık.
        public string tc;

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = tc;
            //ad soyad cekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar Where HastaTc=@p1",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",lblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] +" "+ dr[1];

            }
            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            //data adapter datagride veri aktarmak için kullandığımız komut
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTc="+tc,bgl.baglanti());
            //data giriti doldur dt den gelen değerle dedik
            da.Fill(dt);
            //datagridin veri kaynağı dt den gelen veri dedil
            dataGridView1.DataSource= dt;

            //datagridde bağlantı kapatmaya gerek yok


            //bransları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader   dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bu temizliğin amacı branş seçtiğimizde doktor combobox una üzerine ekleme yapmasın diye
            cbxDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());

            komut3.Parameters.AddWithValue("@p1",cbxBrans.Text);
            SqlDataReader   dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cbxDoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close() ;
        }

        private void cbxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql de kelime bazlı arama yaparken tek tırnak kullanılır ancak tek tırnak tek başına kullanılamadığından çift tırnak içerisinde yazılır.
            DataTable   dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where  RandevuBrans='"+cbxBrans.Text+"'" + " and RandevuDoktor='"+cbxDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource= dt;
        }

        private void lnkBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle fr = new frmBilgiDuzenle();
            fr.tcNo=lblTcNo.Text;
            fr.Show();


        }
    }
}
