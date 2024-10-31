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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgeleCaptchaÜretme_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "-", "$", "#" };
            string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G" };
            int s1, s2, s3;

            Random rnd = new Random();
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, sembol3.Length);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s2.ToString() + sembol3[s3].ToString() + s3.ToString();


        }

        private void btnSayısalLotoyaGeçiş_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                SayısalLoto syslt = new SayısalLoto();
                syslt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış girdiniz lütfen tekrar denemeyiniz");
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
