using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresExercicios
    {

        public static void Executar()
        {
            /*exercicio 1

                Console.WriteLine("Informe a primeira nota: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a segunda nota: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a terceira nota: ");
                double n3 = double.Parse(Console.ReadLine());

                double total = (n1 + n2 + n3) / 3;
                Console.WriteLine("A média do aluno é: " + total.ToString("#.##"));

                /*exercicio 2 


            Console.WriteLine("Informe a primeira nota: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a segunda nota: ");
                double n2 = double.Parse(Console.ReadLine());

                double total = (n1 * 3.5 + n2 * 7.5) / 11;

                Console.WriteLine("A média do aluno é: " + total.ToString("#.##")); */

            //exercicio 3

            Console.WriteLine("Informe seu número de funcionários");
            int fun = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe suas horas trabalhadas: ");
            int vh = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantas horas você trabalhou: ");
            double ht = double.Parse(Console.ReadLine());

            double vht = ht * vh;

            Console.WriteLine($"Número de funcionário: {fun} Salário: {vht}");




        }

    }

}

        

