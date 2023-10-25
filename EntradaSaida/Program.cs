using System;
using Microsoft.VisualBasic;

namespace EntradaSaida {
    internal class Program {
        static void Main(string[] args) {
            // Vetor com as perguntas
            string[] dadosPessoa = new string[5] {
                "Digite seu nome: ",
                "Digite sua profissão: ",
                "Digite seu telefone; ",  
                "Digite seu email: ",
                "Digite sua frase do coração: "
            };

            // Vetor com as respostas da pergunta
            string[]? valoresDados = new string[5];

            // Preenche o vetor com dados
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(dadosPessoa[i]);
                valoresDados[i] = Console.ReadLine();
                Console.WriteLine("\n");
                
            }

            // Apresenta os dados na tela
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(formataStrings("x    " + valoresDados[i]));
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

        }

        string formataStrings( (string mensagem))
        {
            return '';
        }
    }
}