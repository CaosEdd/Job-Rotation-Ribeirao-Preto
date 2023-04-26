using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation_Ribeirao_Preto
{
    internal static class Questao5
    {
        public static void Resposta5()
        {
            Console.Clear();
            Console.WriteLine("5 - Escreva um programa que inverta os caracteres de um string.");
            Console.WriteLine("Resposta:\n");
            Console.WriteLine("Escreva o seu texto");
            var texto = Console.ReadLine();
            if (string.IsNullOrEmpty(texto) || string.IsNullOrWhiteSpace(texto))
            {
                Console.Clear();
                Console.WriteLine("Você não digitou uma string valida !");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Texto normal:{texto}");
                string textoInvertido = new string(texto.Reverse().ToArray());
                Console.WriteLine($"Texto invertido:{textoInvertido}");
            }
            Console.ReadKey();
        }

        public static string InverteString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
