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
    public partial class CaixaEletronico : Form
    {
        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new ContaCorrente{
                Numero = 1,
                Titular = new Cliente("Guilherme")
                {
                    Idade = 18
                }
            };

            contaGuilherme.Deposita(1200);

            bool sacou = contaGuilherme.Saca(300.0);//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.Saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            }

        }

        private void btnInvestir_Click(object sender, EventArgs e)
        {
            Conta umaConta = new ContaCorrente()
            {
                Numero = 1,
                Agencia = 23,
                Titular = new Cliente("Joaquim José")
                {
                    Cpf = "111.222.333-44"
                }
            };

            umaConta.Deposita(1200);

            MessageBox.Show("Rendimento agora é de: " + umaConta.CalculaRendimentoAnual());
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            Conta umaConta = new ContaCorrente()
            {
                Numero = 1,
                Agencia = 23,
                Titular = new Cliente("Joaquim José"){
                    Cpf = "111.222.333-44"
                }
            };

            Conta outraConta = new ContaCorrente()
            {
                Numero = 2,
                Agencia = 13,
                Titular = new Cliente("Antônio Augusto")
                {
                    Cpf = "294.537.318-11"
                }
            };

            MessageBox.Show(umaConta.Titular.Nome + " - " + umaConta.Titular.Cpf + " - " + umaConta.Agencia);
            MessageBox.Show(outraConta.Titular.Nome + " - " + outraConta.Titular.Cpf + " - " + outraConta.Agencia);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new ContaCorrente()
            {
                Numero = 1,
                Titular = new Cliente("Guilherme")
                {
                    Idade = 18
                }
            };

            Conta contaMauricio = new ContaCorrente()
            {
                Numero = 2,
                Titular = new Cliente("Mauricio")
                {
                    Idade = 20
                }
            };

            contaGuilherme.Deposita(1500);
            contaMauricio.Deposita(2500);

            contaGuilherme.Transfere(200.0, contaMauricio);

            MessageBox.Show("Saldo Guilherme: " + contaGuilherme.Saldo);
            MessageBox.Show("Saldo Maurício: " + contaMauricio.Saldo);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Conta umaConta = new ContaCorrente() {
                Titular = new Cliente("Victor")
                {
                    Rg = "12345678-9"
                }
            };

            MessageBox.Show("Nome: " + umaConta.Titular.Nome + " / RG: " + umaConta.Titular.Rg);
        }

        private void CaixaEletronico_Load(object sender, EventArgs e)
        {
            Conta c = new ContaCorrente()
            {
                Titular = new Cliente("Victor Harada")
            };

            txtTitular.Text = c.Titular.Nome;
        }
    }
}
