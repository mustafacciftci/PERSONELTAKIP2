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


namespace PERSONELTAKIP2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;


        public Form1()
        {
            InitializeComponent();
        }
        public void musterigetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=ticaret;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From musteri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musterigetir();


        }

        
    }
}
