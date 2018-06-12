using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);

            if (n1 == 1) {
                textBox2.Text = "O mês referente ao número que você digitou é Janeiro";
            }
            else if (n1 == 2) {
                textBox2.Text = "O mês referente ao número que você digitou é Fevereiro";            
            }
            else if (n1 == 3)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Março";
            }
            else if (n1 == 4)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Abril";
            }

            else if (n1 == 5)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Maio";
            }
            else if (n1 == 6)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Junho";
            }
            else if (n1 == 7)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Julho";
            }
            else if (n1 == 8)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Agosto";
            }
            else if (n1 == 9)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Setembro";
            }
            else if (n1 == 10)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Outubro";
            }
            else if (n1 == 11)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Novembro";
            }
            else if (n1 == 12)
            {
                textBox2.Text = "O mês referente ao número que você digitou é Dezembro";
            }
            else {
                textBox2.Text = "Não existe um mês com esse número";
            }



        }
    }
}
