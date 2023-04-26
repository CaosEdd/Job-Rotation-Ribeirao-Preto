using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation_Ribeirao_Preto
{
    internal class Questao2
    {
        public static void Resposta2()
        {
            Console.Clear();
            Console.WriteLine("2 - Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.");
            Console.WriteLine("Resposta:\n");

            int numero = 0;
            static bool QuadradoPerfeito(int x)
            {
                int s = (int)Math.Sqrt(x);
                return (s * s == x);
            }
            static bool Fibonacci(int n)
            {
                return QuadradoPerfeito(5 * n * n + 4) ||
               QuadradoPerfeito(5 * n * n - 4);
            }
            Console.WriteLine("Digite um numero !");
            numero = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Fibonacci(numero) ? numero +
                             " \nÉ um numero que pertence a sequencia Fibonacci" : numero +
                             " \nÉ um numero que NÃO pertence a sequencia Fibonacci");
            Console.ReadKey();
        }

    }
}
