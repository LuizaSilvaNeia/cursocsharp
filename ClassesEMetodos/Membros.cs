using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            // instanciando a classe pessoa e criando objetos

            /* Pessoa pessoa1 = new Pessoa();
             pessoa1.Nome = "Cleiton Peres";
             pessoa1.Idade = 22 ;

             Pessoa pessoa2 = new Pessoa();
             pessoa2.Nome = "Helena";
             pessoa2.Idade = 20;

             pessoa1.ApresentarNoConsole();

            // Console.WriteLine($"seu nome é {pessoa2.Nome} e tem {pessoa2.Idade} anos") ;*/

            Animais animal1 = new Animais();
            animal1.Nome = "Mel";
            animal1.Especie = "Cachorro";

            animal1.ApresentarNoConsole();
            Console.WriteLine($"Este é meu bichinho que se chama {animal1.Nome} e ele(a) é um {animal1.Especie}");

        }
    }
}
