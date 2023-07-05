using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeHastane
{
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            label3.Text = tc;
            //Doktor ad soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                label4.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where RendevuDoktor='" + label4.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}

