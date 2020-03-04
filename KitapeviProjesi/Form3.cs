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
using System.Data.OleDb;

namespace KitapeviProjesi
{
    public partial class Form3 : Form
    {
        int seciliYayinEviId = 0;
        int seciliYazarId = 0;
        int seciiTurId = 0;

        int yazarId = -1;
        int turId = -1;
        int yayineviId = -1;

        public Form3()
        {
            InitializeComponent();
        }
       
        public void comboBoxDoldur()
        {
            SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Kitabevi.dbo.Yazar.yazarAdi" +
        " FROM Kitabevi.dbo.Yazar", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["yazarAdi"]);
                }
                dr.Close();

                cmd = new SqlCommand("SELECT Kitabevi.dbo.Tur.turAdi" +
        " FROM Kitabevi.dbo.Tur", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["turAdi"]);
                }
                dr.Close();

                cmd = new SqlCommand("SELECT Kitabevi.dbo.Yayinevi.yayineviAdi" +
        " FROM Kitabevi.dbo.Yayinevi", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["yayineviAdi"]);
                }
                dr.Close();

                /*
                cmd = new SqlCommand("SELECT Kitabevi.dbo.Yazar.yazarId" +
" FROM Kitabevi.dbo.Yazar WHERE yazarAdi= '"+comboBox1.SelectedText+"'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    yazarId = (int)(dr["yazarId"]);
                }
                dr.Close();

                cmd = new SqlCommand("SELECT Kitabevi.dbo.Tur.TurId" +
" FROM Kitabevi.dbo.Tur WHERE turAdi= '" + comboBox2.SelectedText + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    turId = (int)(dr["yazarId"]);
                }
                dr.Close();

                cmd = new SqlCommand("SELECT Kitabevi.dbo.Yayinevi.yayineviId" +
" FROM Kitabevi.dbo.Yayinevi WHERE yayineviId= '" + comboBox3.SelectedText + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    yayineviId = (int)(dr["yazarId"]);
                }
                dr.Close();
                */
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

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Kitabevi.dbo.Kitap" +
                    "(kitapAdi, basimTarihi, sayfaSayisi, kitapAdeti, yazarNo, turNo, yayineviNo)" +
                                    "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','" + yazarId + "', '" + turId + "', '" + yayineviId + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap başarıyla eklendi");

                // FORMUN AÇIK KALMASI İSTENİRSE
                /*
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                */

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Kitabevi.dbo.Yazar.yazarId" +
                    " FROM Kitabevi.dbo.Yazar WHERE yazarAdi= '" +comboBox1.SelectedText+ "'      ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yazarId = (int)(dr["yazarId"]);
                label8.Text = "sonuc var";
            }
            else
            {
                label8.Text = "sonuc yok";
            }
            dr.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
