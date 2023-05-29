using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Ex3GetESet
    {
       
        class Animais
        {         
            string especie;
            string nome;

            public string Nome
            {             
                get { return nome; }
                set { nome = value; }
            }
            public string Especie
            {
                get { return especie; }
                set { especie = value; }
            }

        }


        public static void Executar()
        {
            var Animais = new Animais();

            Console.WriteLine("Informe o nome do seu animal: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a espécie do seu animal: ");
            string especie = Console.ReadLine();

          
            if (especie != "cachorro" && especie != "gato" && especie != "ave")
            {
                especie = "ave";
                Console.WriteLine($"O {nome} e a especie é {especie} ");
            }
            else
            {
               
                Console.WriteLine($"O {nome} e a especie é {especie} ");
            }


        }
    }
}
