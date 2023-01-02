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
    public partial class Form6 : Form
    {
        public string Listbox1Content { get; internal set; }

        public Form6()
        {
            InitializeComponent();
            duyuruListele();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ana = new Form2();
            ana.Show();
            this.Hide();
        }
        public void duyuruListele()
        {
           

            listBox1.Items.Clear();
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                Console.WriteLine("veritabanına bağlanıyor...");
                conn.Open();
                string sql = "SELECT * FROM duyuru";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + "--" + rdr[1]);
                    listBox1.Items.Add(rdr[1]);

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
            Form7 dekle = new Form7(this);
            dekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                conn.Open();

                string sql = "DELETE FROM duyuru WHERE icerik='"+ listBox1.SelectedItem + "'";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Duyurunuz Silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();


            
        }

        private void button4_Click(object sender, EventArgs e)
        {

           


            Form11 dguncel = new Form11();
            dguncel.Show();
            this.Hide();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    }
    

