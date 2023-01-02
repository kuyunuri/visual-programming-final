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
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;



        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=muze;user=root;Pwd=;SslMode=none");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtKullanici.Text;
            string pass = txtSifre.Text;
            cmd=new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where usr='" + txtKullanici.Text + "' AND pwd='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
             
                //  MessageBox.Show("Başarıyla giriş yaptınız.");
                Form2 ana = new Form2();
                
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                




            }
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Giriş Ekrannı";
        }
    }
}
