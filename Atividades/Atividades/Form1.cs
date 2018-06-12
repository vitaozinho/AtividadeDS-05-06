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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1();
            ex1.MdiParent = this;
            ex1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();
            ex2.MdiParent = this;
            ex2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio3 ex3 = new Exercicio3();
            ex3.MdiParent = this;
            ex3.Show();
        }

        private void exercico4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio4 ex4 = new Exercicio4();
            ex4.MdiParent = this;
            ex4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio5 ex5 = new Exercicio5();
            ex5.MdiParent = this;
            ex5.Show();
        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio6 ex6 = new Exercicio6();
            ex6.MdiParent = this;
            ex6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio7 ex7 = new Exercicio7();
            ex7.MdiParent = this;
            ex7.Show();
        }
    }
}




