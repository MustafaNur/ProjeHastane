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
    public partial class BilgiDüzenle : Form
    {
        public BilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskdtxtTcNo.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdtxtTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtbxUyeAd.Text = dr[1].ToString();
                txtbxUyeSoyad.Text = dr[2].ToString();
                mskdtxtTelefon.Text = dr[4].ToString();
                txtbxSifre.Text = dr[5].ToString();
                cmbbxCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtbxUyeAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtbxUyeSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskdtxtTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtbxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbbxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskdtxtTcNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
