using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa{
        //public para que os atributos fiquem visiveis
        //para minha classe
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos");
        }
        //o metodo Format retorna um a string formatada e imprime no console
        
        public void ApresentarNoConsole()
        {
            // chamar no console para apresentar o metodo que criamos
            Console.WriteLine(Apresentar());
        }
    }
}
