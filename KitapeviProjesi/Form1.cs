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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {     
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true");
                SqlCommand com = new SqlCommand("SELECT * FROM Personel WHERE kullaniciAdi=@kullaniciAdi and sifre=@sifre", con);
                con.Open();
                com.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdiTextBox.Text);
                com.Parameters.AddWithValue("@sifre", sifreTextBox.Text);
                SqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    // GİRİŞ YAPILDI
                    Controls.Remove(kullaniciAdiTextBox);
                    Controls.Remove(sifreTextBox);
                    Controls.Remove(girisButton);
                    Controls.Remove(girisGorsel);
                    //YENİ FORMA YÖNLENDİR
                    Form2 f = new Form2();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {  
                    // HATALI ŞİFRE VEYA KULLANICI ADI
                    MessageBox.Show("Lütfen kullanıcı adınızı ve parolanızı doğru giriniz");
                    kullaniciAdiTextBox.Text = "";
                    sifreTextBox.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void kullaniciAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;

            if (string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = (string)textbox.Tag;
            }
        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;

            if (string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = (string)textbox.Tag;
                sifreTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                sifreTextBox.UseSystemPasswordChar = true;
            }
        }

    }
}
