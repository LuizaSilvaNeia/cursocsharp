using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Heranca
    {

        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            //a variavel velocidadeMaxima será transmitida por herença usando o protected
            int velocidadeAtual;

            //criando o construtor de carro
            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            // criando método para acelerar o carro
            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = velocidadeAtual + delta;
                if (novaVelocidade < 0)
                {
                    velocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima)
                {
                    velocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    velocidadeAtual = novaVelocidade;
                }
                return velocidadeAtual;
            }

            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        // ao colocar : estamos fazendo a herança
        public class Uno : Carro
         {
            public Uno() : base(200)
            {

            }
         }

        public class Corsa : Carro
        {
            public Corsa() : base(150)
            {

            }
        }
        public static void Executar()
        {
//Console.WriteLine("Uno ...");
            //instanciar carro1 em Uno
            //Uno carro1 = new Uno();
            //Console.WriteLine(carro1.Acelerar());
            //Console.WriteLine(carro1.Acelerar());
            //Console.WriteLine(carro1.Frear());

            Console.WriteLine("Corsa...");
            Corsa carro2 = new Corsa();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
           


        }
    }
}
