using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplCaptcha
{
    public partial class SayısalLoto : Form
    {
        public SayısalLoto()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rnd.Next(0, 5);
            s2 = rnd.Next(0, 5);
            s3 = rnd.Next(0, 5);
            s4 = rnd.Next(0, 5);
            s5 = rnd.Next(0, 5);
            label1.Text=s1.ToString();
            label2.Text=s2.ToString();
            label3.Text=s3.ToString();
            label4.Text=s4.ToString();
            label5.Text=s5.ToString();
            //1
            if (label1.Text==textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor= Color.Red;
            }
            //2
            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            //3
            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            //4
            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            //5
            if (label5.Text == textBox5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
        }
    }
}
