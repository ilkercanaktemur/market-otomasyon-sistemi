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
    public partial class Anasayfa: Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ELTMUH - 04\SQLEXPRESS; Initial Catalog = Otomasyon; Integrated Security = True; Trust Server Certificate=True");
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form yardim = new yardim();
            yardim.Show();
        }

        private void ürünKatagorisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form Kategori  = new Kategori();
           Kategori.Show();
        }

        private void ürünTürüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ürünToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form urunturu = new urunturu();
            urunturu.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form kullaniciekle = new kullaniciekle();
            kullaniciekle.Show();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form urunstokkayit = new urunstokkayit();
            urunstokkayit.Show();
        }

        private void ürünStokSİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form urunstoksil = new urunstoksil();
            urunstoksil.Show();
        }

        private void ürünStokGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form urunstokduzenle = new urunstokduzenle();
            urunstokduzenle.Show();
        }

        private void aramaYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formlar arası gecis
            Form aramayap = new aramayap();
            aramayap.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Form anasayfa = new Anasayfa();
            anasayfa.Show();
        }
    }
}
