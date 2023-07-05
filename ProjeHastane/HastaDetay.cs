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

namespace ProjeHastane
{
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            label3.Text = tc;
            // ad soyad
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

            // Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                cmbDoktorlar.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where RandevuBrans='" + cmbBrans.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource= dt;
        }

        private void linkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDüzenle fr = new BilgiDüzenle();
            fr.TCno = label3.Text;
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Randevular set RendevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where RandevuID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", txtbxID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı");
        }
    }
}
