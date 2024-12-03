using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kisiISLEMLERIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formKisiIslrmlri kisiler_islem = new formKisiIslrmlri();
            kisiler_islem.Show();// form nesnesi oluşturup formu çektik
        }
    }
}
