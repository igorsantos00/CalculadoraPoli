using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        public static void Menu() {
            Console.WriteLine("Digite qual a Operação ?");
            Console.WriteLine("");
            Console.WriteLine("0.Soma");
            Console.WriteLine("1.Subtração");
            Console.WriteLine("2.Divisão");
            Console.WriteLine("3.Multiplicação");


        }


        static void Main(string[] args)
        {

            Operacao[] operacoes = new Operacao[4];

           operacoes [0] = new Soma();
           operacoes [1] = new Subtracao();
           operacoes [2] = new Divisao();
           operacoes [3] = new Multiplicacao();


            Console.WriteLine("Digite um número");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual a Operação ?");

            for (int i = 0; i < operacoes.Length ; i++)
            {
                Console.WriteLine(i + " - " + operacoes[i].GetDescricao());
            }

            int opc = int.Parse(Console.ReadLine());

            Operacao escolhida = operacoes[opc];
            double resultado = escolhida.FazAconta(n1, n2);

            Console.WriteLine(resultado);

        }
    }
}
