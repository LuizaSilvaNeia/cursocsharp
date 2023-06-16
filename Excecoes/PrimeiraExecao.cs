using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExecao
    {
        public class Conta
        {
            private double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }
            public void Sacar(double valor)
             {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente");
                }

                Saldo -= valor;
             }
        }

        
        public static void Executar()
        {
            var conta = new Conta(1200);

            try
            {
                // tentar sacar o dinheiro, caso de certo o valor sera retirado
                conta.Sacar(500);
                Console.WriteLine("Valor sacado com sucesso");
            }
            catch(Exception ex)
            {
                // receber a exceção do erro que foi lançado
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }


        }
    }
}
