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

namespace KitapeviProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void VeriListele()
        {
            SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true");
            SqlCommand cmd = con.CreateCommand();
            try
            {        
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Kitabevi.dbo.Kitap.kitapAdi as [Kitap Adı],"+
		                                "Kitabevi.dbo.Kitap.basimTarihi as [Basım Tarihi],"+
		                                "Kitabevi.dbo.Kitap.sayfaSayisi as[Sayfa Sayısı]," +
		                                "Kitabevi.dbo.Kitap.kitapAdeti as [Stok]," +
		                                "Kitabevi.dbo.Yazar.yazarAdi as [Yazar Adı], " + 
		                                "Kitabevi.dbo.Yazar.yazarSoyadi as  [Yazar Soyadı]," +
		                                "Kitabevi.dbo.Tur.turAdi as [Tür], " +
		                                "Kitabevi.dbo.Yayinevi.yayineviAdi as [Yayınevi]" +
                                        "FROM(((Kitabevi.dbo.Kitap " +
                                            "INNER JOIN Kitabevi.dbo.Yazar ON Yazar.yazarId = Kitap.yazarNo)" +
                                            "INNER JOIN Kitabevi.dbo.Tur ON Tur.turId = Kitap.turNo)" +
                                            "INNER JOIN Kitabevi.dbo.Yayinevi ON Yayinevi.yayineviId = Kitap.yayineviNo)";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VeriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            //this.Hide();
            f.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeriListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            //this.Hide();
            f.ShowDialog();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            //this.Hide();
            f.ShowDialog();
            //this.Close();
        }
    }
}
