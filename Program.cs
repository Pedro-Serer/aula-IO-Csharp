using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Cria um scriupt que solicite 2 números ao usuário
             * e ao final moste a soma dos valores.
             */

            // Define as variáveis
            decimal numero_um;
            decimal numero_dois;
            decimal soma;
            decimal subtracao;
            decimal multiplicacao;
            decimal divisao;

            Console.WriteLine("SOMA APP 3000");

            Console.WriteLine("Informe o primeiro número: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Infome o segundo número: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            // Operações
            soma          = numero_um + numero_dois;
            subtracao     = numero_um - numero_dois;
            multiplicacao = numero_um * numero_dois;
            divisao       = numero_um / numero_dois;

            // Resultado das operações
            Console.WriteLine(
                "A soma do número " + numero_um 
                + " mais o número " + numero_dois + " é " + soma
            );

            Console.WriteLine(
                "A subtração do número " + numero_um
                + " menos o número " + numero_dois + " é " + subtracao
            );

            Console.WriteLine(
                "A multiplicação do número " + numero_um
                + " com o número " + numero_dois + " é " + multiplicacao
            );

            Console.WriteLine(
                "A divisão do número " + numero_um
                + " com o número " + numero_dois + " é " + divisao
            );
        }
    }
}
