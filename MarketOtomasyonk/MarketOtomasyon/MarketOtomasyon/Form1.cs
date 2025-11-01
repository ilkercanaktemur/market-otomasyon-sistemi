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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=ELTMUH-04\\SQLEXPRESS;Initial Catalog=Otomasyon;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection baglanti = new SqlConnection();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text=="") {
                MessageBox.Show("alanları doldurun");
                    }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from kullanicibilgi where id='" +textBox1.Text+ "'", baglanti);
                SqlDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text == okuyucu["id"].ToString() && textBox2.Text == okuyucu["sifre"].ToString())
                    {
                        
                        MessageBox.Show("hosgeldiniz sayin" + okuyucu["adsoyad"].ToString());
                    Form form = new Anasayfa();
                    form.Show();
                    this.Hide();
                      
                    }
                    else
                    {
                        MessageBox.Show("bilgilerinizi kontrol edin!");
                    }
                }
                else
                {
                    MessageBox.Show("bilgilerinizi kontrol edin!");
                }
                baglanti.Close();
            }
        }
    }
}
