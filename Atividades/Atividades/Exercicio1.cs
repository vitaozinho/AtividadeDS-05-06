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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);
            double n2 = System.Convert.ToDouble(textBox2.Text);
            double res = n1 + n2;

            if (res > 20)
            {
                double r = res + 8;
                result.Text = r.ToString();
            }
            else 
            {
                double r = res - 5;
                result.Text = r.ToString();
            }
        }
    }
}
