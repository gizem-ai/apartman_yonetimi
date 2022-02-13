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
    public partial class daire3 : Form
    {
        public List<Sakinler> sakinListesi = new List<Sakinler>();
        public daire3()
        {
            InitializeComponent();
            listviewaGönderme();
        }
        public void listviewaGönderme()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Adı", 80);
            listView1.Columns.Add("Soyadı", 84);
            listView1.Columns.Add("Numarası", 86);
            if (System.IO.File.Exists(FileWriterProgram.path + "\\daire3.json"))
            {
                string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire3.json");
                int deneme = JArray.Parse(text).Count();
                for (int i = 0; i < deneme; i++)
                {
                    string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["no"].ElementAt(i).ToString() };
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
        int butonSayacı = 0;
        private void eklebutonu_Click(object sender, EventArgs e)
        {
            daire3kisiSayisi.Enabled = false;
            butonSayacı = butonSayacı + 1;
            if (butonSayacı == Convert.ToInt32(daire3kisiSayisi.Text))
            {
                daire3kisiAd.Enabled = false;
                daire3kisisoyAd.Enabled = false;
                daire3no.Enabled = false;
                onaylaButonu.Enabled = true;
            }
            SakinlerForm.Ad = daire3kisiAd.Text;
            SakinlerForm.Soyad = daire3kisisoyAd.Text;
            SakinlerForm.Numara = daire3no.Text;
            sakinListesi.Add(new Sakinler { isim = SakinlerForm.Ad, soyisim = SakinlerForm.Soyad, no = SakinlerForm.Numara });
        }
        private void onaylaButonu_Click(object sender, EventArgs e)
        {
            string baslik = this.Text;
            string Kisisayisi = daire3kisiSayisi.Text;
            int KisiSayisi = Convert.ToInt32(Kisisayisi);
            CreateJsonProgram.CreateJson(KisiSayisi, sakinListesi, baslik);
            listView1.Clear();
            listviewaGönderme();
        }
        private void daire3kisiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void daire3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
            onaylaButonu.Enabled = false;
            daire3kisiAd.Enabled = false;
            daire3kisisoyAd.Enabled = false;
            daire3no.Enabled = false;
        }
        private void daire3kisiSayisi_TextChanged(object sender, EventArgs e)
        {
            if (daire3kisiSayisi.Text != null)
            {
                daire3kisiAd.Enabled = true;
                daire3kisisoyAd.Enabled = true;
                daire3no.Enabled = true;
            }
        }
        private void daire3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
