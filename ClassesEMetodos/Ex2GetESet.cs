using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Ex2GetESet
    {
        class Aluno
        {
            double n1;
            double n2;
            double n3;

            public double N1
            {
                get { return n1; }
                set { n1 = value; }
            }
            public double N2
            {
                get { return n2; }
                set { n2 = value; }
            }
            public double N3
            {
                get { return n3; }
                set { n3 = value; }
            }

            public double media
            {
                get { return (n1 + n2 + n3) / 3; }

            }
            public Aluno(double n1, double n2, double n3)
            {
                N1 = n1;
                N2 = n2;
                N3 = n3;
            }

        }

        public static void Executar()
        {
            var aluno1 = new Aluno(5.0,6.5,7.9);
            Console.WriteLine($"A media do aluno é {aluno1.media}");

        }
    }
}
