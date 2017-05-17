using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Exponencial : Operacao
    {
        public override double FazAconta(double n1, double n2)
        {
            return Math.Pow(n1,n2);
        }
    }
}
