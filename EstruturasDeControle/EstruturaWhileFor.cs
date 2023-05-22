using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhileFor
    {
        public static void Executar()
        {

            Console.WriteLine("Informe um valor: ");
            int.TryParse(Console.ReadLine(), out int valor);

            int contador = 1;

            while (contador <= valor)
            {
                Console.WriteLine(contador);
                contador++;
            }

            /* for
            for (int contador = 1; contador < 10; contador++)
            {
                Console.WriteLine(contador);

            }*/
        }
    }
}
