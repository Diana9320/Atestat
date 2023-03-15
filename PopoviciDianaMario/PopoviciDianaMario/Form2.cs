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
using System.Data.OleDb;

namespace PopoviciDianaMario
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Colecteza cat mai multe monede in timpul acordat de fondator \n2.Nu poti sa sari atat timp cat esti pe suprafata unei placi\n3.Ai doar o singura sansa \n TASTELE FOLOSITE SUNT:\n   1.A-STANGA\n   2.D-DREAPTA\n   3.W-SARITURA");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="player" && textBox2.Text=="123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                Label l1 = new Label();
                l1.Text = "0";
                f2.timer2.Enabled = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                label1.Visible = true;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            else
                MessageBox.Show("Parola sau user incorecta!\nMai incearca");  
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UserName: player \n Pass: 123");
        }
    }
}
