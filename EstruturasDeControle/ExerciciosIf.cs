using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class ExerciciosIf
    {
        public static void Executar()
        {
            /* exercicio 1
            Console.WriteLine("Informe seu ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = 2023 - nascimento  ;

            if( idade <= 70 && idade >= 18){
                Console.WriteLine($"Você tem {idade} e pode votar!");
            }else{
                Console.WriteLine($"Você tem {idade} e não pode votar!");
            }*/

            /*exercicio 2
            Console.WriteLine("informe sua senha: ");
            string senha = Console.ReadLine();

            if(senha == "7taz9HvJ")
            {
                Console.WriteLine("ACESSO PERMITIDO!");
            }else
            {
                Console.WriteLine("ACESSO NEGADO!");
            }*/

            /*exercicio 3
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if(media >= 7)
            {
                Console.WriteLine($"Sua nota é {media}, está aprovado!");
            }else if(media>= 5 && media < 7)
            {
                Console.WriteLine($"Sua nota é {media}, você está de recuperação!");
            }
            else
            {
                Console.WriteLine($"Sua nota é {media}, você está reprovado!");
            }*/

            //exercicio 4 
            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura*altura);
            

            if(imc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {imc.ToString("##.#")}, você está abaixo do peso  ");
            }
            else if (imc >=18.5 && imc <=24.9){
                Console.WriteLine($"Seu IMC é { imc.ToString("##.#")}, seu  peso está normal");
            }
            else if (imc >24.9 && imc <= 29.9)
            {
                Console.WriteLine($"Seu IMC é { imc.ToString("##.#")}, você está acima do peso");
            }
            else if (imc > 29.9 && imc <= 34.9)
            {
                Console.WriteLine($"Seu IMC é { imc.ToString("##.#")}, você está com Obesidade Grau I");
            }
            else if (imc > 34.9 && imc <= 39.9)
            {
                Console.WriteLine($"Seu IMC é { imc.ToString("##.#")}, você está com Obesidade Grau II");
            }
            else 
            {
                Console.WriteLine($"Seu IMC é { imc.ToString("##.#")}, você está com Obesidade Grau III");
            }




        }
    }
}
