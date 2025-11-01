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
    public partial class urunstokduzenle: Form
    {
        public urunstokduzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");
      
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncellemekomudu = new SqlCommand("update urunstok set barkodno='" + textBox1.Text + "',kategori='" + comboBox1.Text + "',urunturu='" + comboBox2.Text + "'urun='" + comboBox3.Text + "',rafno='" + textBox4.Text + "',adet='" + textBox5.Text + "',giristarihi='" + dateTimePicker1.Text + "'where barkodno='" + textBox1.Text + "'", baglanti);
            guncellemekomudu.EndExecuteNonQuery();
            baglanti.Close();
            label7.Text = textBox1 + "barkod nolu urun gucenllendi ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urunstok where barkodno='" + textBox1.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Text = oku["kategori"].ToString();
                comboBox2.Text = oku["urunturu"].ToString();
                comboBox3.Text = oku["urun"].ToString();
                textBox4.Text = oku["rafno"].ToString();
                textBox5.Text = oku["adet"].ToString();
                dateTimePicker1.Text = oku["giristarihi"].ToString();
            }
            baglanti.Close();
        }
    }
}
