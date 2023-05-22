using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie o meu atendimento com 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);
        }
    }
}
