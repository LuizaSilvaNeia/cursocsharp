using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        class Cliente
        {
            // o modificador private vai garantir que só a class Cliente
            // tenha acesso aos atributos.
            private string nome;

            // porém poderemos tirar o valor privado para abstrir
            // alguma informação usando o Get e Set.
            //GET PEGA O VALOR E SET ENVIA O VALOR

            // GET  e o SET tem que ser IGUAIS ao atributo da classe
            // com a primeira letra maiuscula.
            public string Nome
            {
                get
                {
                    //para pegar valor de nome é preciso um return
                    return nome;
                }
                set
                {
                    //envio do valor do atributo insformado na outra classe
                    nome = value;
                }


            }
        }


        public static void Executar()
        {
            //inicializar um objeto da classe Cliente
            Cliente cliente1 = new Cliente();

            //Exemplo de GET cliente.Nome;

            cliente1.Nome = "Cleiton";
            Console.WriteLine(cliente1.Nome);

        }
    }
}
