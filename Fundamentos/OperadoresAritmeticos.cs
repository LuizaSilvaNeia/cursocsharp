using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
            /*/public static void Executar() {
            Console.WriteLine("informe um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            int total = n1 + n2;

            Console.WriteLine($"A some de {n1} + {n2} = {total}");
            }*/

            public static void Executar() {

            Console.WriteLine("Informe a medida da base: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            double a = double.Parse(Console.ReadLine());

            double total = (b * a) / 2;
            Console.WriteLine($" as dimensões do triângolo são {b} * {a} / 2 = {total}");

        }

        
    }
}
