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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TcNo;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select SekreterAdsoyad From Tbl_Sekreter Where SekreterTc=@p1",bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1",lblTcNo.Text);

            SqlDataReader   dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branslar
            DataTable dt1= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransad from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;

        }

     
    }
}
