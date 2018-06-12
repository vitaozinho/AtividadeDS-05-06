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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);
            if (n1 <= 50)
            {
                double i=1;
                do
                {
                    richTextBox1.Text += i.ToString() + "\n";
                    i++;
                }
                while (i <= n1);
            }
            else {
                richTextBox1.Text = "Seu número é maior que 50";
            }
            }

    }
}
