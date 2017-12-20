using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentos
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 42.0;
        }
    }
}
