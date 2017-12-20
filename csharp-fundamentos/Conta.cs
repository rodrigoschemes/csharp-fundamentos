using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentos
{
    abstract class Conta
    {
        public double Agencia { get; set; }
        public double Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public abstract bool Saca(double valorASerSacado);


        public virtual void Deposita(double valor)
        {
            if (valor > 0 )
                this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
                this.Saca(valor);
                destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }

        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }
    }
}
