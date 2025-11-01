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
    public partial class urunekle: Form
    {
        public urunekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand uruneklekomutu = new SqlCommand("insert into urunler(id,urunadi) valuse('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
            uruneklekomutu.ExecuteNonQuery();
            baglanti.Close;
            label3.Text = textBox2.Text + "basariyla eklendi";
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
