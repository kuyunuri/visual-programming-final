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
    public partial class Form11 : Form
    {
        private object SelectedItem;


        public Form11()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            Form6 form6 = new Form6();
            string selectedItem = (string)form6.listBox1.SelectedItem;

            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=muze;password=");
            try
            {
                conn.Open();

                string v = "UPDATE duyuru SET icerik='" + richTextBox1.Text + "' Where icerik =  '" + form6.listBox1.SelectedItem + "'";
                string sql = v;


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Duyurunuz Güncellendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 duy = new Form6();
            duy.Show();
            this.Hide();
        }
    }
}
