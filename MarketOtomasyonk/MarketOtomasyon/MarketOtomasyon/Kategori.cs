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
    public partial class Kategori: Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");
        baglanti.Open();

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kategori(id,kategori)values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            label3.Text = textBox2.Text + "kategorisi eklendi";
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
