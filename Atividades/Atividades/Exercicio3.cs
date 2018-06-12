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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);
            double n2 = System.Convert.ToDouble(textBox2.Text);
            double n3 = System.Convert.ToDouble(textBox3.Text);

            if (n1 == n2 && n2 == n3) {
                textBox4.Text = "Seu Triângulo é Equilátero";
            
                }
            else if (n1 == n2 && n1 != n3)
            {
                textBox4.Text = "Seu Triângulo é Isóceles";
            }
            else {
                textBox4.Text = "Seu Triângulo é Escaleno";
            }
 
        }
    }
}
