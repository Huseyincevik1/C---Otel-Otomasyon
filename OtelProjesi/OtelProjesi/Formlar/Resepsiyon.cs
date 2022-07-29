using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProjesi.Formlar
{
    public partial class Resepsiyon : Form
    {
        public Resepsiyon()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FaturaBilgisi fatura = new FaturaBilgisi();
            fatura.Show();
            this.Hide();
        }
    }
}
