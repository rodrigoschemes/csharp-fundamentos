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
    public partial class TesteTributos : Form
    {
        public TesteTributos()
        {
            InitializeComponent();
        }

        private void TesteTributos_Load(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca cp = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();

            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);

            MessageBox.Show("Total: " + gerenciador.Total);
        }
    }
}
