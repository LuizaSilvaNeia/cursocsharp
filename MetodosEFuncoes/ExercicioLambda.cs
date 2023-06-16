using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExercicioLambda
    {
        public static void Executar()
        {
            Func<int,bool> ParOuImpar = (Numero) =>
            {
                if (Numero % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            };
            Console.WriteLine(ParOuImpar(6));
        }
    }
}
