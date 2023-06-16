using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ExercicioPoli
    {
       public class Cliente
        {
            public string Nome;
            public string Tipo;
   
        }

       public class Juridico : Cliente
        {

        }

        public class Fisico : Cliente
        {

        }


        public static void Executar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Informe seu nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Você é uma pessoa física ou jurídica? ");
            cliente.Tipo = Console.ReadLine();

            Console.WriteLine($"{cliente.Nome} você é uma pessoa {cliente.Tipo}");

        }
    }
}
