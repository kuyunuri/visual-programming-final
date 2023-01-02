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
    public partial class Form8 : Form
    {
        public string Listbox2Content { get; internal set; }
        public Form8()
        {
            InitializeComponent();
            muzeListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ana = new Form2();
            ana.Show();
            this.Hide();
        }
        public void muzeListele()
        {
            listBox2.Items.Clear();
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                Console.WriteLine("veritabanına bağlanıyor...");
                conn.Open();
                string sql = "SELECT icerik FROM mlistesi";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + "--" + rdr[1]);
                    listBox2.Items.Add(rdr[1]);

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 mekle = new Form9(this);
            mekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                conn.Open();

                string sql = "DELETE FROM mlistesi WHERE icerik='" + listBox2.SelectedItem + "'";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Müze Bilginiz Silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 mguncel = new Form12();
            mguncel.Show();
            this.Hide();
        }
    }
}
