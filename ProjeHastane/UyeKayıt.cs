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
    public partial class UyeKayıt : Form
    {
        public UyeKayıt()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbxUyeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtbxUyeSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdtxtTcNo.Text);
            komut.Parameters.AddWithValue("@p4", mskdtxtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtbxSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbbxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirildi, Şifreniz: " + txtbxSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
