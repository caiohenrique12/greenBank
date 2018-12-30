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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
            label1.Text = "Seu Email";
            label2.Text = "Senha";
            label3.Text = "Repetir Senha";
            button1.Text = "Criar Conta";
            button2.Text = "0 ou 4";
            button3.Text = "2 ou 7";
            button4.Text = "1 ou 9";
            button5.Text = "3 ou 5";
            button6.Text = "6 ou 8";
            button7.Text = "6 ou 8";
            button8.Text = "0 ou 4";
            button9.Text = "1 ou 9";
            button10.Text = "2 ou 7";
            button11.Text = "3 ou 5";
            linkLabel1.Text = "Entrar no Green Bank";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
