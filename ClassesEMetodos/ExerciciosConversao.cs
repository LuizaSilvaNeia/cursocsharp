using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosConversao
    {      
        class Converter
        {
           
            public double Dolar()
            {
                Console.WriteLine("Informe o valor em reais ? ");
                double.TryParse(Console.ReadLine(), out double r);
                double d = 0.0;
                return d = r * 5;
            }
            public double Fahrenheit()
            {
                Console.WriteLine("Informe a temperatura em graus Celsius? ");
                double.TryParse(Console.ReadLine(), out double c);
                double f = 0.0;
                return f = c * 1.2 + 32;
            }
        }

        public static void Executar()
        {
           
            var Converter = new Converter();

            var valor = Converter.Dolar();
            Console.WriteLine($"Equivalente a {valor} dolares.");

            var resultado = Converter.Fahrenheit();
            Console.WriteLine($"Equivalente a {resultado} graus Fahrenheit.");



        }
    }
}
