using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeHastane
{
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string TCnumara;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCnumara;

            // ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // Branşlar data grid aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;


            // Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans From Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource= dt2;

            // Branşı Combobox aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RendevuDoktor) values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", mskdTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", mskdSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmbBranş.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");

        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtbxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            DoktorPaneli drp = new DoktorPaneli();
            drp.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            BransPaneli frb = new BransPaneli();
            frb.Show();
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            RandevuListesi randevular = new RandevuListesi();
            randevular.Show();
        }
    }
}
