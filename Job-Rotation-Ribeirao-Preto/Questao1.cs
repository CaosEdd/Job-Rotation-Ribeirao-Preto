using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Job_Rotation_Ribeirao_Preto
{
    internal static class Questao1
    {
        public static void Resposta1()
        {
            Console.Clear();
            Console.WriteLine("1) Observe o trecho de código abaixo:\n" +
                "int INDICE = 13, SOMA = 0, K = 0; \n" +
                " enquanto K < INDICE faça\n" +
                "{\n" +
                "K = K + 1;\n" +
                "SOMA = SOMA + K;\n" +
                "}\n" +
                "imprimir(SOMA);");

            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }
            Console.WriteLine($"\nSOMA = {soma}");
            Console.ReadKey();
        }
    }
}
