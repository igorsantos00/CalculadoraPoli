using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Divisao : Operacao
    {

        public override double FazAconta(double n1, double n2)
        {
            return n1 / n2;
        }

        public override string GetDescricao()
        {
            return ToString();
        }

    }
}
