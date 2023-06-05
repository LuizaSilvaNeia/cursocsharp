using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Arrays
    {
        public static void Executar()
        {
            // criar um array com um valor delimitado
            /*string[] alunos = new string[5];

            alunos[0] = "Vanderlei";
            alunos[1] = "Jose";
            alunos[2] = "Ale";
            alunos[3] = "Loloisa";
            alunos[4] = "Vini";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }*/


            // soma existe para se atribuir um valor de uma nota do array notas a ela 
            double soma = 0;
            double[] notas = { 8.5, 7.5, 6.5 };

            foreach (var nota in notas)
            {
                soma += nota;
            }
            double media = soma / notas.Length;
            Console.WriteLine(media);
        }
    }
}
