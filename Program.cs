using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;





namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Findamentos", Formatandonumero.Executar },
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Exercicios - Fundamentos",OperadoresExercicios.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },

                //estruturas de controle
                {"Estrutura If - Estruturas de controle",EstruturaIf.Executar },
                {"Exercicios If - Estruturas de controle", ExerciciosIf.Executar },
                {"Estrutura While e for - EStrutura de Controle",EstruturaWhileFor.Executar },
                {"Estrutura Swich - EStrutura de Controle",EstruturaSwitch.Executar },
                {"Exercicios While e For - Estrutura de controle",ExercicioWhileFor.Executar },
                {"Estrutura ForEach - Estrutura de controle",EstruturaForEach.Executar },
                
                //Classes e metodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Metodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
                {"Exercicios Converter - Classes e Métodos",ExerciciosConversao.Executar },
                { "Metodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Get e Set - Classes e Métodos",GetSet.Executar },
                {"Get e Set Segundo Exemplo- Classes e Métodos",GetESetsegundoExemplo.Executar },
                {"Exercicio 1 Get e Set - Classes e Métodos ", Ex1GetESet.Executar},
                { "Exercicio 2 Get e Set - Classes e Métodos ", Ex2GetESet.Executar },
                { "Exercicio 3 Get e Set - Classes e Métodos ", Ex3GetESet.Executar },

                //Coleção
                {"Array - Coloeções", Arrays.Executar },
                {"Coleçoes Queue - Coleções ", ColecoesQueue.Executar },
                {"Coleções Stack - Coleções", ColecoesStack.Executar },

                //POO 
                {"Herança - POO",Heranca.Executar },
                {"Construtor This - POO",ConstrutorThis.Executar },
                {"Encapsulamento - POO", POO.Encapsulamento.Executar }


            });

            central.SelecionarEExecutar();
        }
    }
}