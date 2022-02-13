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
    public partial class Apartman : Form
    {
        public Apartman()
        {
            InitializeComponent();
        }
        private void anamenuyedonenbuton_Click(object sender, EventArgs e)
        {
            Ana_Menu anamenu = new Ana_Menu();
            anamenu.Show();
            this.Hide();
        }
        private void daire1egidenbuton_Click(object sender, EventArgs e)
        {
            daire1 daire1 = new daire1();
            daire1.Show();
            this.Hide();
        }
        private void daire2yegidenbuton_Click(object sender, EventArgs e)
        {
            daire2 daire2 = new daire2();
            daire2.Show();
            this.Hide();
            //daire2.listviewaGönderme();
        }
        private void daire3egidenbuton_Click(object sender, EventArgs e)
        {
            daire3 daire3 = new daire3();
            daire3.Show();
            this.Hide();
        }
        private void daire4egidenbuton_Click(object sender, EventArgs e)
        {
            daire4 daire4 = new daire4();
            daire4.Show();
            this.Hide();
        }
        private void Apartman_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
        }
        private void Apartman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
