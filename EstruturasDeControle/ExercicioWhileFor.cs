using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class ExercicioWhileFor
    {
        public static void Executar()
        {


            /*int soma = 0;
            //Exercicio 1 
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Digite um número: ");
                int.TryParse(Console.ReadLine(), out int n);

                 soma += n;
            }
                Console.WriteLine($"a soma dos números é: {soma}"); 
             


            /*Exercicio 2*/
             
            Console.WriteLine("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int n);

            int contador = 0;

            while (contador < n)
            {
                Console.WriteLine(contador);
                contador++;
            }
            /* Exercicio 3
            Console.WriteLine("informe um número: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{n} * {contador} = {n*contador}");
            }*/
        }
    }
}

