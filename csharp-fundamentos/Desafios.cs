using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_fundamentos
{
    public partial class Desafios : Form
    {
        public Desafios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 5;
            int c = 2;

            double delta;
            double a1;
            double a2;


            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("Resultado 1: " + a1);
            MessageBox.Show("Resultado 2: " + a2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show("A soma dos números de 1 até 1000 é: " + soma);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("O número " + i + " é um múltiplo de 3");
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("fatorial(" + n + ") = " + fatorial);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";
            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }
    }
}
