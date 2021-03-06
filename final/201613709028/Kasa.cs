using Newtonsoft.Json;
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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
            geliriListviewaGonderme();
            giderListviewaGonderme();
            Hesaplama();
        }
        private void Kasa_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            this.Location = new Point(300, 200);
            textBox2.Enabled = false;
            listView3.View = View.Details;
            listView3.GridLines = true;
            listView3.FullRowSelect = true;
            listView3.Columns.Add("Adı", 85);
            listView3.Columns.Add("Soyadı", 85);
        }
        public void geliriListviewaGonderme()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Adı", 67);
            listView1.Columns.Add("Soyadı", 67);
            listView1.Columns.Add("Daire No", 60);
            listView1.Columns.Add("Ödeme Türü", 75);
            listView1.Columns.Add("Tutar", 70);
            listView1.Columns.Add("Tarih", 80);
            if (System.IO.File.Exists(FileWriterProgram.path + "\\Gelir.json"))
            {
                string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\Gelir.json");
                int deneme = JArray.Parse(text).Count();
                for (int i = 0; i < deneme; i++)
                {
                    string[] row = { JArray.Parse(text).Children()["Isim"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["Soyisim"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["DaireNo"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["Odeme_turu"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["Tutar"].ElementAt(i).ToString(), 
                                     JArray.Parse(text).Children()["Tarih"].ElementAt(i).ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        
        public void giderListviewaGonderme()
        {
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("Gider Türü", 90);
            listView2.Columns.Add("Tutar", 85);
            listView2.Columns.Add("Tarih", 90);
            if (System.IO.File.Exists(FileWriterProgram.path + "\\Gider.json"))
            {
                string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\Gider.json");
                int deneme = JArray.Parse(text).Count();
                for (int i = 0; i < deneme; i++)
                {
                    string[] row = { JArray.Parse(text).Children()["GiderTuru"].ElementAt(i).ToString(),
                                     JArray.Parse(text).Children()["Tutar"].ElementAt(i).ToString(),
                                     JArray.Parse(text).Children()["Tarih"].ElementAt(i).ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView2.Items.Add(listViewItem);
                }
            }
        }
        public void Hesaplama()
        {
            double toplagelir = 0, toplaGider = 0, Total = 0;
            for (int sayi = 0; sayi <= listView1.Items.Count - 1; sayi++)
            {
                double sayi1;
                string sayi3;
                sayi3 = listView1.Items[sayi].SubItems[4].Text;
                sayi1 = Convert.ToDouble(sayi3);
                toplagelir = toplagelir + sayi1;
            }
            for (int sayi = 0; sayi <= listView2.Items.Count - 1; sayi++)
            {
                double sayi1;
                string sayi3;
                sayi3 = listView2.Items[sayi].SubItems[1].Text;
                sayi1 = Convert.ToDouble(sayi3);
                toplaGider = toplaGider + sayi1;
            }
            Total = toplagelir - toplaGider;
            string total = Total.ToString();
            label10.Text = total;
            label11.Text = Convert.ToString(toplaGider);
            label12.Text = toplagelir.ToString();
        }
        public DateTime bugun = DateTime.Now;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Daire 1")
            {
                listView3.Items.Clear();
                daireNo = "1";
                if (System.IO.File.Exists(FileWriterProgram.path + "\\daire1.json"))
                {
                    string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire1.json");
                    int deneme = JArray.Parse(text).Count();
                    for (int i = 0; i < deneme; i++)
                    {
                        string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Daire 2")
            {
                listView3.Items.Clear();
                daireNo = "2";
                if (System.IO.File.Exists(FileWriterProgram.path + "\\daire2.json"))
                {
                    string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire2.json");
                    int deneme = JArray.Parse(text).Count();
                    for (int i = 0; i < deneme; i++)
                    {
                        string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Daire 3")
            {
                listView3.Items.Clear();
                daireNo = "3";
                if (System.IO.File.Exists(FileWriterProgram.path + "\\daire3.json"))
                {
                    string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire3.json");
                    int deneme = JArray.Parse(text).Count();
                    for (int i = 0; i < deneme; i++)
                    {
                        string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Daire 4")
            {
                listView3.Items.Clear();
                daireNo = "4";
                if (System.IO.File.Exists(FileWriterProgram.path + "\\daire4.json"))
                {
                    string text = System.IO.File.ReadAllText(FileWriterProgram.path + "\\daire4.json");
                    int deneme = JArray.Parse(text).Count();
                    for (int i = 0; i < deneme; i++)
                    {
                        string[] row = { JArray.Parse(text).Children()["isim"].ElementAt(i).ToString(), JArray.Parse(text).Children()["soyisim"].ElementAt(i).ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_Menu= new Ana_Menu();
            ana_Menu.Show();
            this.Hide();
        }
        public string isim, soyisim, odemeTuru, daireNo;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Aidat")
                odemeTuru = "Aidat";
            else if (comboBox3.SelectedItem == "Kira")
                odemeTuru = "Kira";
            else if (comboBox3.SelectedItem == "Diğerleri")
                odemeTuru = "Diğerleri";
        }
        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                ListViewItem item = listView3.SelectedItems[0];
                isim = item.SubItems[0].Text;
                soyisim = item.SubItems[1].Text;
            }
        }
        public string giderTuru;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Bina Faturaları")
            {
                textBox2.Enabled = false;
                giderTuru = "Bina Faturaları";
            }
            else if (comboBox2.SelectedItem == "Arıza") 
            {
                textBox2.Enabled = false;
                giderTuru = "Arıza";
            }
            else if (comboBox2.SelectedItem == "Kapıcı") 
            {
                textBox2.Enabled = false;
                giderTuru = "Kapıcı";
            }
            else if (comboBox2.SelectedItem == "Temizlik") 
            {
                textBox2.Enabled = false;
                giderTuru = "Temizlik";
            }
            else if (comboBox2.SelectedItem == "Diğerleri")
            {
                textBox2.Enabled = true;
                giderTuru = textBox2.Text;
            }
        }
        int i = 0, j = 0;
       
        private void button4_Click(object sender, EventArgs e)
        {
            j = j + 1;
            if (j > 0)
                button5.Enabled = true;
            DateTime bugun = DateTime.Now;
            string tarih = bugun.ToString("d");
            string tutar = textBox3.Text;
            if (tutar == null || comboBox2.SelectedItem == null || giderTuru == null) 
            {
                MessageBox.Show("Eksik Giriş");
            }
            else
                kasaListGider.ListeEkle(new JsonVerilerG(giderTuru, tutar, tarih));
            //ekle
        }

        private void Kasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            appKapatma.app_kapatma();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kasa_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            CreatJsonGider.CreateJsonG(j, kasaListGider.jsonVerilerGs, "Gider");
            giderListviewaGonderme();
            Hesaplama();
            //onayla
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //eklebutonu
            i = i + 1;
            DateTime bugun = DateTime.Now;
            string tarih = bugun.ToString("d");
            string tutar = textBox1.Text;
            int tutAr = Convert.ToInt32(tutar);
            if (tutar == null || comboBox3.SelectedItem == null || comboBox1.SelectedItem == null || listView3.SelectedItems == null)
            {
                MessageBox.Show("Eksik Giriş");
            }
            else
                kasaList.ListeEkle(new JsonVeriler(isim, soyisim, daireNo, odemeTuru, tutar, tarih));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            CreateJsonKasa.CreateJsonK(i, kasaList.jsonVerilerL, "Gelir");
            geliriListviewaGonderme();
            Hesaplama();
        }
    }
}
