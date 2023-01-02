using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselprogfinalodevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cık = new Form1();

            cık.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 ilet = new Form5();

            ilet.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 hak = new Form3();

            hak.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 kart = new Form4();

            kart.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 duyuru = new Form6();

            duyuru.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 bilet = new Form10();

            bilet.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 muzeler = new Form8();

            muzeler.Show();
            this.Hide();
        }
    }
}
