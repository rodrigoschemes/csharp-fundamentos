using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentos
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }

        public Cliente() { }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            return this.Idade >= 18;
        }
    }
}
