using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace görselprogfinalodevi
{
    public partial class Form9 : Form
    {
        Form8 muze;
        public Form9(Form8 parametredengelenekran)
        {
            InitializeComponent();
            muze = parametredengelenekran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                Console.WriteLine("MYSQL veritabanına bağlanıyor...");
                conn.Open();

                string sql = "INSERT INTO muzeler Values('" + richTextBox1.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Müze İçeriğiniz Eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            muze.muzeListele();
            muze.Show();
        }
    }
}
