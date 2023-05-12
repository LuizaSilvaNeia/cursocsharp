using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;



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
                {"Estrutura If - Estruturas de controle",EstruturaIf.Executar }

            });

            central.SelecionarEExecutar();
        }
    }
}