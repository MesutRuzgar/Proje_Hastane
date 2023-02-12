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
            SqlCommand komut = new SqlCommand("Select SekreterAdsoyad From Tbl_Sekreter Where SekreterTc=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branslar datagrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransad from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorlar  as 'xxx' kullanımı sutun adı Colum1 olarak geldiğinde ismini değiştirmek için kullanılır
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branslar combobox
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cbxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cbxDoktor.Text);
           
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Başarıyla Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoktor.Items.Clear();
            //Doktorlar combobox
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbxBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxDoktor.Items.Add(dr[0]+" " + dr[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
