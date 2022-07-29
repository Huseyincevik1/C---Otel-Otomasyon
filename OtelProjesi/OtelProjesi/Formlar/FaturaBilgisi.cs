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

namespace OtelProjesi.Formlar
{
    public partial class FaturaBilgisi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1E3PP0A;Initial Catalog=OTEL;Integrated Security=True");
  
        SqlDataAdapter adtr;
        DataTable tablo = new DataTable();

        public FaturaBilgisi()
        {
            InitializeComponent();
        }

        public void Fatura()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("sp_faturabilgisi", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void FaturaBilgisi_Load(object sender, EventArgs e)
        {
            Fatura();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MüşteriID:" + textBox1.Text+"\n" + "Müşteri Adı" + textBox2.Text + "\n" + "Müşteri Soyadı:" + textBox3.Text + "\n" +
                "Telefon No:" + textBox4.Text + "\n" + "E-posta:" + textBox5.Text + "\n" + "Oda No:" + textBox6.Text + "\n" +
                "Taban Fiyat:" + textBox7.Text + "\n" + "RezervasyonID:" + textBox8.Text + "\n" + "Geliş Tarih:" + textBox9.Text + "\n" +
                "Gidiş Tarihi:" + textBox10.Text + "\n" + "Kalma Fiyat:" + textBox11.Text + "\n" + "Rezervasyon Tipi:" + textBox12.Text + "\n" +
                "Rezervasyon Adı:" + textBox13.Text + "\n" + "İndirim Yüzdesi:" + textBox14.Text + "\n");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
