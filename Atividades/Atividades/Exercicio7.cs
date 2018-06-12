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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double n1 = 1.50;
            double n2 = 1.10;
            double i = 1;
            while (n2 <= n1)
            {
                n1 += 0.02;
                n2 += 0.03;
                i++;
            }
            richTextBox1.Text = "Manoel passou Arlindo em: " + i + " anos.";

        }
        }
    }

