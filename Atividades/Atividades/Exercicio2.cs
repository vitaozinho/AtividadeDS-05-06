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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(textBox1.Text);
            double res1 = n1 % 2;
            double res2 = n1 % 5;
            double res3 = n1 % 10;

            if (res1 == 0 && res2 == 0 && res3 == 0) {
                textBox2.Text = "É divisivel pelos 3 números";
            }
            else if(res1 != 0 && res2 == 0 && res3 ==0){
                textBox2.Text = "É divisivel somente por 5 e 10";
            }
            else if (res1 != 0 && res2 != 0 && res3 == 0)
            {
                textBox2.Text = "É divisivel somente por 10";
            }
            else if (res1 == 0 && res2 == 0 && res3 != 0)
            {
                textBox2.Text = "É divisivel somente por 2 e 10";
            }
            else if (res1 == 0 && res2 == 0 && res3 != 0)
            {
                textBox2.Text = "É divisivel somente por 2 e 5";
            }
            else if (res1 == 0 && res2 != 0 && res3 != 0)
            {
                textBox2.Text = "É divisivel somente por 2";
            }
            else if (res1 != 0 && res2 == 0 && res3 != 0)
            {
                textBox2.Text = "É divisivel somente por 5";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
