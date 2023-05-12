using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
           

            if(media >= 7.0){
                Console.WriteLine($"Você teve a média {media} e foi aprovado");
            }else{
                Console.WriteLine($"Você teve a média {media} e foi reprovado");
            }
        }
    }
}
