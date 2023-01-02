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
    public partial class Form7 : Form
    {
        Form6 duyuru;
        public Form7(Form6 parametredengelenForm)
        {
            InitializeComponent();
            duyuru = parametredengelenForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                Console.WriteLine("MYSQL veritabanına bağlanıyor...");
                conn.Open();

                string sql = "INSERT INTO duyuru Values('" + textBox1.Text + "','" + richTextBox1.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Duyurunuz Eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            duyuru.duyuruListele();
            duyuru.Show();

        }
    }
}
