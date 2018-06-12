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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);
            
            
                double i = 1;
                do
                {
                    richTextBox1.Text += i.ToString() + " - Brasil\n";
                    i++;
                }
                while (i <= n1);
            }        
    }
}
