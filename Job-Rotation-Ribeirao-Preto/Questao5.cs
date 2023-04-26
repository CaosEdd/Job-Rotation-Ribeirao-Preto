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
                Console.WriteLine($"Texto invertido:{InverterString(texto)}");
                

                // string textoInvertido = new string(texto.Reverse().ToArray());
                // Console.WriteLine($"Texto invertido:{textoInvertido}");
            }
            Console.ReadKey();
        }
        // Metodo seu utilizar o Array.Reverse()
        private static string InverterString(string stringInput)
        {
            string invertida = "";
            int tamanho;

            tamanho = stringInput.Length - 1;

            while (tamanho >= 0)
            {
                invertida = invertida + stringInput[tamanho];
                tamanho--;
            }
            return invertida;

        }

        // Metodo utilizando o Array.Reverse()

        //private static string InverteString(string s)
        //{
        //    char[] arr = s.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}
    }
}
