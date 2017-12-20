using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentos
{
    class ContaPoupanca:Conta, ITributavel
    {
        public override bool Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);

            return true;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor + 0.1;
        }

        public override void Atualiza(double taxa)
        {
            base.Atualiza(taxa * 3);
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }
}
