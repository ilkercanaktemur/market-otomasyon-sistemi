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

namespace MarketOtomasyon
{
    public partial class urunstoksil: Form
    {
        public urunstoksil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");
     


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silmekomutu = new SqlCommand("delete from urunstok where barkodno='" + textBox1.Text + "'", baglanti);
            silmekomutu.ExecuteNonQuery();
            baglanti.Close();
            label4.Text = textBox1.Text + "barkod no lu urun stoktan silindi";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from urunstok where barkodno='" + textBox1.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text = oku["urun"].ToString();
                textBox3.Text = oku["adet"].ToString();
            }
            baglanti.Close();
        }
    }
}
