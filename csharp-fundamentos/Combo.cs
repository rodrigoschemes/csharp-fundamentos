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
    public partial class Combo : Form
    {
        Conta[] contas;

        public Combo()
        {
            InitializeComponent();
        }

        private void Combo_Load(object sender, EventArgs e)
        {
            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente("Victor");
            contaDoVictor.Numero = 1;
            contaDoVictor.Deposita(500);

            Conta contaDoMario = new ContaCorrente();
            contaDoMario.Titular = new Cliente("Mario");
            contaDoMario.Numero = 2;
            contaDoMario.Deposita(1200);

            this.contas = new Conta[2];
            this.contas[0] = contaDoVictor;
            this.contas[1] = contaDoMario;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }
    }
}
