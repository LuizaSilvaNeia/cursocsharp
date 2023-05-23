using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Animais
    {
        public string Especie;
        public string Nome;
        
        public string Apresentar()
        {
            return string.Format($"Este é meu bichinho que se chama {Nome} e ele(a) é um {Especie}");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

    }
}
