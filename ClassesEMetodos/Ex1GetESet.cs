using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Ex1GetESet
    {
        class Pessoa
        {
            string nome;
            DateTime nascimento;
            double altura;

            public string Nome
            {
                get {return nome;}
                set {nome = value;}
            }

            public DateTime Nascimento
            {
                get{return nascimento;}
                set {  nascimento = value; }
            }

            public double Altura
            {
                get { return altura; }
                set { altura = value; }
            }





            public Pessoa(string nome, DateTime nascimento ,double altura)
            {
                Nome = nome;
                Nascimento = nascimento;
                Altura = altura;
            }

            public Pessoa()
            {
            }

            public void imprimir()
            {
                Console.WriteLine($"Olá {nome} sua data de nascimento é {nascimento}  e tem {altura} de altura");
            }

            public int idade()
            {
                return DateTime.Today.Year - nascimento.Year ;
            }

        }
        public static void Executar()
        {
            var pessoa1 = new Pessoa();
            pessoa1.Nome = "Cleber";
            pessoa1.Altura = 1.58;
            pessoa1.Nascimento = new DateTime(2004, 06, 10); 
            pessoa1.imprimir();
            pessoa1.idade();
            int idade = pessoa1.idade();
            Console.WriteLine($"você tem {idade} anos");
           


        }
    }
}
