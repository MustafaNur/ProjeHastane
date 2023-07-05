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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            //Doktor ad soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Doktorlar where DoktorTC=@p1", bgl.baglanti());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtbxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DoktorDetay fr = new DoktorDetay();
                fr.tc = mskdTcNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();
        }
    }
}
