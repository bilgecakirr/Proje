using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeYenidenYapım1
{
    public partial class Dersprogramım : UserControl
    {



        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        

        public Dersprogramım()
        {
            InitializeComponent();

        }
      
        private void verilerigoruntule()

        {
             baglanti = new SqlConnection("Data Source=TOSHIBA\\THANKYOU;Initial Catalog=YeniDersKaydı;Integrated Security=True");
             baglanti.Open();
            da=new SqlDataAdapter("select * from OgrenciDersTablom",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        
        private void Dersprogramım_Load(object sender, EventArgs e)
        {
            verilerigoruntule();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE OgrenciDersTablom Set Ders=@Ders,Konu=@Konu,KonuTekrari=@KonuTekrari,Test=@Test,SoruSayisi=@SoruSayisi,MolaArasi=@MolaArasi,Odev=@Odev,Hedef=@Hedef,Tarih=@Tarih,Puan=@Puan Where ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox10.Text));
            komut.Parameters.AddWithValue("@Ders", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@Konu", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@KonuTekrari", Convert.ToInt32(textBox3.Text));
            komut.Parameters.AddWithValue("@Test", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@SoruSayisi", Convert.ToInt32(textBox5.Text));
            komut.Parameters.AddWithValue("@MolaArasi", Convert.ToInt32(textBox6.Text));
            komut.Parameters.AddWithValue("@Odev", Convert.ToInt32(textBox7.Text));
            komut.Parameters.AddWithValue("@Hedef", Convert.ToInt32(textBox8.Text));
            komut.Parameters.AddWithValue("@Tarih", Convert.ToInt32(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@Puan", Convert.ToInt32(textBox9.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into OgrenciDersTablom(Ders,Konu,KonuTekrari,Test,SoruSayisi,MolaArasi,Odev,Hedef,Tarih,Puan) values(@Ders,@Konu,@KonuTekrari,@Test,@SoruSayisi,@MolaArasi,@Odev,@Hedef,@Tarih,@Puan)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ders", textBox1.Text);
            komut.Parameters.AddWithValue("@Konu", textBox2.Text);
            komut.Parameters.AddWithValue("@KonuTekrari", textBox3.Text);
            komut.Parameters.AddWithValue("@Test", textBox4.Text);
            komut.Parameters.AddWithValue("@SoruSayisi", textBox5.Text);
            komut.Parameters.AddWithValue("@MolaArasi", textBox6.Text);
            komut.Parameters.AddWithValue("@Odev", textBox7.Text);
            komut.Parameters.AddWithValue("@Hedef", textBox8.Text);
            komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@Puan", textBox9.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from OgrenciDersTablom where ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox10.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();

        }

        
    }
}
