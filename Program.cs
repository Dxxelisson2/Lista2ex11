using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double m;

            m = 5;
            Console.Write("Digite o valor de P1:");
            p1 = double.Parse(Console.ReadLine());
            p2 = (m * 3 - p1) / 2;
            Console.WriteLine("O aluno precisa tirar na p2:" + p2);
        

    }
  }
}
