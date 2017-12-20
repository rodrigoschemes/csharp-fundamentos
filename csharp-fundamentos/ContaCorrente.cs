using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentos
{
    class ContaCorrente:Conta
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }

        public int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor < 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= (valor + 0.1);
                return true;
            }
        }

        public override void Atualiza(double taxa)
        {
            base.Atualiza(2 * taxa);
        }
    }
}
