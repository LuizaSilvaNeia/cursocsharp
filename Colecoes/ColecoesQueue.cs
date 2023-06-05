using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            //enfileirar
            fila.Enqueue("Cleiton");
            fila.Enqueue("Carlos");
            fila.Enqueue("Rodrigo");
            fila.Enqueue("Josiscleuda");
            fila.Enqueue("Josivalda");


            Console.WriteLine(fila.Peek());//Peek pega o primeiro elemento da fila
            Console.WriteLine(fila.Count());//contando os elementos da fila
            Console.WriteLine(fila.Dequeue());//removendo o primeiro elemento da fila
            Console.WriteLine(fila.Count());

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

        }
    }
}
