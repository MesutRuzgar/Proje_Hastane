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
            
            //datagridde

        }
    }
}
