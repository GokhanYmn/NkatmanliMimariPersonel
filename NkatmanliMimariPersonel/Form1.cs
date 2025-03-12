using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NkatmanliMimariPersonel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist =LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent=new EntityPersonel();
            ent.Ad=txtAd.Text;
            ent.Soyad=txtSoyad.Text;
            ent.Gorev=txtGorev.Text;
            ent.Sehir=txtSehir.Text;
            ent.Maas=short.Parse(txtMaas.Text);

            LogicPersonel.LLPersonelEkle(ent);
            LogicPersonel.LLPersonelListesi();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel entity=new EntityPersonel();
            entity.Id=Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(entity.Id);
            LogicPersonel.LLPersonelListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Id = Convert.ToInt32(textBox1.Text);
            entity.Ad=txtAd.Text;
            entity.Sehir = txtSehir.Text;
            entity.Soyad = txtSoyad.Text;
            entity.Maas= short.Parse(txtMaas.Text);
            entity.Gorev = txtGorev.Text;
            LogicPersonel.LLPersonelGuncelle(entity);
            LogicPersonel.LLPersonelListesi();
        }
    }
}
