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
    public partial class Formulario : Form
    {
        private Conta[] contas;
        private Conta c;
        private Conta p;

        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            p = new ContaPoupanca();
            /*c = new Conta()
            {
                Titular = new Cliente("Victor Harada"),
                Agencia = 933,
                Numero = 9644
            };

            c.Deposita(100);
            this.MostraConta();*/
            this.CriarContas();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Double valorDeposito = Convert.ToDouble(txtValor.Text);

            c.Deposita(valorDeposito);
            MessageBox.Show("Depósito Realizado com Sucesso!");

            this.MostraConta(c);
        }

        private void MostraConta(Conta contaSelecionada)
        {
            c = contaSelecionada;

            txtConta.Text = Convert.ToString(c.Agencia) + "/" + Convert.ToString(c.Numero);
            txtSaldo.Text = Convert.ToString(c.Saldo);
            txtTitular.Text = c.Titular.Nome;
            txtPoupanca.Text = Convert.ToString(p.Saldo);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Double valorSaque = Convert.ToDouble(txtValor.Text);

            if (c.Saca(valorSaque))
                MessageBox.Show("Saque Realizado com Sucesso!");
            else
            {
                MessageBox.Show("Operação não realizada!");
            }

            this.MostraConta(c);
        }

        private void btnDepositarPoupanca_Click(object sender, EventArgs e)
        {
            Double valorDeposito = Convert.ToDouble(txtValor.Text);
            p.Deposita(valorDeposito);

            this.MostraConta(c);
        }

        private void btnSacarPoupanca_Click(object sender, EventArgs e)
        {
            Double valorSaque = Convert.ToDouble(txtValor.Text);
            p.Saca(valorSaque);

            this.MostraConta(c);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas t = new TotalizadorDeContas();

            t.Soma(c);
            t.Soma(p);

            MessageBox.Show("Total de Contas: " + t.ValorTotal);
        }

        private void CriarContas()
        {
            contas = new Conta[3];

            Conta c1 = new ContaCorrente()
            {
                Titular = new Cliente("Roberta Cintra"),
                Agencia = 933,
                Numero = 9644
            };

            c1.Deposita(100);

            Conta c2 = new ContaCorrente()
            {
                Titular = new Cliente("Rodrigo Schemes"),
                Agencia = 123,
                Numero = 4567
            };

            c2.Deposita(500);

            Conta c3 = new ContaCorrente()
            {
                Titular = new Cliente("Raul Cintra"),
                Agencia = 456,
                Numero = 7890
            };

            c3.Deposita(1000);

            contas[0] = c1;
            contas[1] = c2;
            contas[2] = c3;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
                destinoDaTransferencia.Items.Add(conta.Titular.Nome);
            }


        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            c = this.contas[indiceSelecionado];

            this.MostraConta(c);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;
            Conta contaDestino = this.contas[indiceDaContaDestino];
            string textoValor = txtValor.Text;
            double valorTransferencia = Convert.ToDouble(textoValor);

            c.Transfere(valorTransferencia, contaDestino);
            this.MostraConta(c);
            MessageBox.Show("Transferência realizada com sucesso!");
        }
    }
}
