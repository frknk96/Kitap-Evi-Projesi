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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Add_Yazar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@YazarAdi", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@YazarSoyadi", SqlDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = textBox4.Text;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Yazar Başarıyla Eklendi");
                textBox1.Text = "";
                this.Close();
            }

            else
            {

                MessageBox.Show("Lütfen yazarla ilgili alanları doldurunuz");

            }
        }
    }
}
