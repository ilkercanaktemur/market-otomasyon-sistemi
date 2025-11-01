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
    public partial class urunstokkayit: Form
    {
        public urunstokkayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");
        baglanti.Open();
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komuturunstok = new SqlCommand("insert into urunstok(barkodno,kategori,urunturu,urun,rafno,ade,giristarihi)values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "')", baglanti);
            komuturunstok.ExecuteNonQuery();
            label8.Text = "stok bilgisi güncellendi";
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            baglanti.Close();
            urunstokkayit_Load(sender e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void urunstokkayit_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select kategori from kategori", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox1.Items.Add(oku["kategori"].ToStirng());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komuturunturu = new SqlCommand("select urunturu from urunturu", baglanti);
            SqlDataReader okuurunturu = komuturunturu.ExecuteReader();
            while (okuurunturu.Read())
            {
                comboBox2.Items.Add(okuurunturu["urunturu"].ToStirng());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komuturunler = new SqlCommand("select urunadi from urunler", baglanti);
            SqlDataReader okuurunler = komuturunler.ExecuteReader();
            while (okuurunler.Read())
            {
                comboBox2.Items.Add(okuurunturu["urunadi"].ToStirng());
            }
            baglanti.Close();
        }
    }
}
