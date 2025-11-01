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
    public partial class kullaniciekle: Form
    {
        public kullaniciekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");
        baglanti.Open();
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
          SqlCommand kullanicieklekomutu = new SqlCommand("insert into kullanicibilgi(id,sifre,adsoyad,gorevi)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", baglanti);
            kullanicieklekomutu.ExecuteNonQuery();
            baglanti.Close();
            label5.Text = textBox3.Text + "kullanicisi eklendi";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
