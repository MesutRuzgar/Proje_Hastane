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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tbxAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cbxBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTcNo.Text);
            komut.Parameters.AddWithValue("@p5", tbxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTcNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTcNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTc=@p4",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tbxAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cbxBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTcNo.Text);
            komut.Parameters.AddWithValue("@p5", tbxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();            
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
