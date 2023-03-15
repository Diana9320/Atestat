using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopoviciDianaMario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }      
        bool right, left, jump;
       
        int f;
        int g = 20;
        int k = 0;
        PictureBox[] coins=new PictureBox[7];
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                right = true;
            if (e.KeyCode == Keys.A)
                left = true;

            if (jump != true)
                if (e.KeyCode == Keys.W)
                {
                    jump = true;
                    f = g;
                }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                right = false;
            if (e.KeyCode == Keys.A)
                left = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //2
            if (mario.Right - 5 > pictureBox2.Left && mario.Left + mario.Width + 5 < pictureBox2.Left + pictureBox2.Width + mario.Width && mario.Top + mario.Height >= pictureBox2.Top && mario.Top < pictureBox2.Top)
            {
                mario.Top = pictureBox2.Location.Y - mario.Height;
                f = 0;
                jump = false;
            }
            if (mario.Right - 5 > pictureBox2.Left && mario.Left + mario.Width + 5 < pictureBox2.Left + pictureBox2.Width + mario.Width && mario.Top <= pictureBox2.Bottom && mario.Top > pictureBox2.Top)
            {
                mario.Top = pictureBox2.Location.Y + mario.Height;
                f = 0;
                jump = true;
            }
            //10
            if (mario.Left < pictureBox10.Right && mario.Bottom > pictureBox10.Top && mario.Top < pictureBox10.Bottom)
            {
                left = false;
            }
            //3
            if (mario.Right > pictureBox3.Left && mario.Bottom > pictureBox3.Top && mario.Top < pictureBox3.Bottom)
            {
                right = false;
            }
            //4
            if (mario.Right - 5 > pictureBox4.Left && mario.Left + mario.Width + 5 < pictureBox4.Left + pictureBox4.Width + mario.Width && mario.Top + mario.Height >= pictureBox4.Top && mario.Top < pictureBox4.Top)
            {
                mario.Top = pictureBox4.Location.Y - mario.Height;
                f = 0;
                jump = false;
            }
            if (mario.Right - 5 > pictureBox4.Left && mario.Left + mario.Width + 5 < pictureBox4.Left + pictureBox4.Width + mario.Width && mario.Top <= pictureBox4.Bottom && mario.Top > pictureBox4.Top)
            {
                mario.Top = pictureBox4.Location.Y + mario.Height;
                f = 0;
                jump = true;
            }
            //5
            if (mario.Right - 5 > pictureBox5.Left && mario.Left + mario.Width + 5 < pictureBox5.Left + pictureBox5.Width + mario.Width && mario.Top + mario.Height >= pictureBox5.Top && mario.Top < pictureBox5.Top)
            {
                mario.Top = pictureBox5.Location.Y - mario.Height;
                f = 0;
                jump = false;
            }
            if (mario.Right - 5 > pictureBox5.Left && mario.Left + mario.Width + 5 < pictureBox5.Left + pictureBox5.Width + mario.Width && mario.Top <= pictureBox5.Bottom && mario.Top > pictureBox5.Top)
            {
                mario.Top = pictureBox5.Location.Y + mario.Height;
                f = 0;
                jump = true;
            }
            //7
            if (mario.Right - 5 > pictureBox7.Left && mario.Left + mario.Width + 5 < pictureBox7.Left + pictureBox7.Width + mario.Width && mario.Top + mario.Height >= pictureBox7.Top && mario.Top < pictureBox7.Top)
            {
                mario.Top = pictureBox7.Location.Y - mario.Height;
                f = 0;
                jump = false;
            }
            if (mario.Right - 5 > pictureBox7.Left && mario.Left + mario.Width + 5 < pictureBox7.Left + pictureBox7.Width + mario.Width && mario.Top <= pictureBox7.Bottom && mario.Top > pictureBox7.Top)
            {
                mario.Top = pictureBox7.Location.Y + mario.Height;
                f = 0;
                jump = true;
            }
            //9
            if (mario.Right - 5 > pictureBox9.Left && mario.Left + mario.Width + 5 < pictureBox9.Left + pictureBox9.Width + mario.Width && mario.Top + mario.Height >= pictureBox9.Top && mario.Top < pictureBox9.Top)
            {
                mario.Top = pictureBox9.Location.Y - mario.Height;
                f = 0;
                jump = false;
            }
            if (mario.Right - 5 > pictureBox9.Left && mario.Left + mario.Width + 5 < pictureBox9.Left + pictureBox9.Width + mario.Width && mario.Top <= pictureBox9.Bottom && mario.Top > pictureBox9.Top)
            {
                mario.Top = pictureBox9.Location.Y + mario.Height;
                f = 0;
                jump = true;
            }
            //
            if (right == true)
                mario.Left += 5;
            if (left == true)
                mario.Left -= 5;
            if (jump == true)
            {
                mario.Top -= f;
                f--;
            }
            if (mario.Top + mario.Height >= panel1.Height)
            {
                mario.Top = panel1.Height - mario.Height;
                jump = false;
            }
            else
            {
                mario.Top += 3;
            }
        }
        int i;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            label2.Text = i.ToString();
            if (label2.Text == "7")
            {
                MessageBox.Show("Ai reusit sa colectezi "  + label1.Text+" moneda/monede in 7 secunde");
                timer2.Stop();
                this.Close();
            }
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            coins[0] = coin1;
            coins[1] = coin2;
            coins[2] = coin3;
            coins[3] = coin4;
            coins[4] = coin5;
            coins[5] = coin6;
            coins[6] = coin7;
            timer2.Stop();
            
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            for (int i = 0; i < 7; i++)
            {
              
                if (mario.Bounds.IntersectsWith(coins[i].Bounds) && coins[i].Visible)
                {
                    coins[i].Visible = false;
                    k += 1;
                    label1.Text = k.ToString();
                }

            }
            timer3.Enabled = true;
        }
    }
}
