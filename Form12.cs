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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 mana = new Form8();
            mana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();
            string selectedItem = (string)form8.listBox2.SelectedItem;

            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                conn.Open();

                string v = "UPDATE muzeler SET icerik='" + richTextBox1.Text + "' Where icerik =  '" + form8.listBox2.SelectedItem + "'";
                string sql = v;


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Müze Bilginiz Güncellendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}
