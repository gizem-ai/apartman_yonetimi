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
    public partial class Ana_Menu : Form
    {
        public Ana_Menu()
        {
            InitializeComponent();
            gelirJsonUstuneEkleme.gelirinUstuneEkleme();
            giderJsonUstuneEkleme.giderinUstuneEkleme();
        }
        private void aparmanagidenbuton_Click(object sender, EventArgs e)
        {
            Apartman aprtmn = new Apartman();
            aprtmn.Show();
            this.Hide();
        }
        private void kasayagidenbuton_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
            this.Hide();
        }
        private void Ana_Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
        }
        private void Ana_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
