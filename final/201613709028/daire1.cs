using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201613709028
{
    public partial class daire1 : Form
    {        
        public daire1()
        {
            InitializeComponent();
            listviewaGönderme();
        }
        public void listviewaGönderme()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Adı", 83);
            listView1.Columns.Add("Soyadı", 84);
            listView1.Columns.Add("Numarası", 83);
            if (System.IO.File.Exists(FileWriterProgram.path + "\\daire1.json")) 
            {
                string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire1.json");
                int deneme = JArray.Parse(text).Count();
                for (int i = 0; i < deneme; i++)
                {
                    string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["no"].ElementAt(i).ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        private void apartmanadonenbuton_Click(object sender, EventArgs e)
        {
            Apartman apartman = new Apartman();
            apartman.Show();
            this.Hide();
        }
        public List<Sakinler> sakinListesi = new List<Sakinler>();
        int butonSayacı = 0;
        private void eklebutonu_Click(object sender, EventArgs e)
        {
            daire1kisiSayisi.Enabled = false;
            butonSayacı = butonSayacı + 1;
            if (butonSayacı == Convert.ToInt32(daire1kisiSayisi.Text))
            {
                daire1kisiAd.Enabled = false;
                daire1kisisoyAd.Enabled = false;
                daire1no.Enabled = false;
                onaylaButonu.Enabled = true;
            }
            SakinlerForm.Ad = daire1kisiAd.Text;
            SakinlerForm.Soyad = daire1kisisoyAd.Text;
            SakinlerForm.Numara = daire1no.Text;
            sakinListesi.Add(new Sakinler { isim = SakinlerForm.Ad, soyisim = SakinlerForm.Soyad, no = SakinlerForm.Numara }); //
        }
        string baslik;
        private void onaylaButonu_Click(object sender, EventArgs e)
        {
            baslik = this.Text;
            string Kisisayisi = daire1kisiSayisi.Text;
            int KisiSayisi = Convert.ToInt32(Kisisayisi);
            CreateJsonProgram.CreateJson(KisiSayisi, sakinListesi, baslik);
            listView1.Clear();
            listviewaGönderme();
        }
        public void daire1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
            onaylaButonu.Enabled = false;
            daire1kisiAd.Enabled = false;
            daire1kisisoyAd.Enabled = false;
            daire1no.Enabled = false;
        }
        private void daire1kisiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        void silbutonu_Click(object sender, EventArgs e)
        {
            /*string baslik = this.Text;
            string numara;
            for (int j = 0; j < sakinListesi.Count; j++)
            {
                if (sakinListesi[j].no == textBox1.Text)
                {
                    sakinler = sakinListesi[j];
                }
            }
            sakinListesi.Remove(sakinler);
            CreateJsonProgram.CreateJson(sakinListesi.Count(), sakinListesi, baslik);*/
        }
        private void daire1kisiSayisi_TextChanged(object sender, EventArgs e)
        {
            if (daire1kisiSayisi.Text != null)
            {
                daire1kisiAd.Enabled = true;
                daire1kisisoyAd.Enabled = true;
                daire1no.Enabled = true;
            }
        }
        private void daire1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
