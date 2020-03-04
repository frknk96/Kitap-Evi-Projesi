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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"server=localhost\SQLEXPRESS;database=Kitabevi;Integrated Security=true"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Add_Tur", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TurAdi", SqlDbType.VarChar).Value = textBox1.Text;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tür Başarıyla Eklendi");
                textBox1.Text = "";
                this.Close();
            }

            else
            {

                MessageBox.Show("Lütfen bir kategori adı giriniz");

            }
        }
    }
}
