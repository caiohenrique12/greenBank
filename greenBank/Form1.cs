using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenBank
{
    public partial class Form1 : Form
    {
        private signUp signup;

        public Form1()
        {
            InitializeComponent();
            button1.Text = "Entrar";
            button2.Text = "0 ou 4";
            button3.Text = "2 ou 7";
            button4.Text = "1 ou 9";
            button5.Text = "3 ou 5";
            button6.Text = "6 ou 8";
            label1.Text = "Login";
            label2.Text = "Senha";
            label3.Text = "Green Bank";
            linkLabel1.Text = "Esqueci minha senha.";
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            signup = new signUp();
            signup.Show();
        }
    }
}
