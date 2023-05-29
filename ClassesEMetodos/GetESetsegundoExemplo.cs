using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetESetsegundoExemplo
    {
        public class CarroOpcinal
        {
           private double desconto = 0.1;
            private string nome;

            public string Nome
            {
                get
                {
                    return "Opcional" + nome;
                }
                set { 
                    
                    nome = value; 
                }
            }
        

            //propriedade autoimplementada
            public double Desconto {get;set;}
            
            public double Preco { get; set; }

            public double PrecoComDesconto
            {
                get
                {
                    return Preco - (desconto * Preco); 
                }
            }

            public CarroOpcinal(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

        }

        public static void Executar()
        {
            var op = new CarroOpcinal("Aerofólio", 1.500);
            var op2 = new CarroOpcinal("Ar condicionado", 3.200);

            Console.WriteLine(op.PrecoComDesconto);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
