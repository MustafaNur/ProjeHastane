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
    public partial class Sekreter : Form
    {
        public Sekreter()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Sekreter_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtbxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SekreterDetay frs = new SekreterDetay();
                frs.TCnumara = mskdTcNo.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giris yaptınız");
            }
            bgl.baglanti().Close();
        }
    }
}
