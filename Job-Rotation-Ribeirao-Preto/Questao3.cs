using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation_Ribeirao_Preto
{
    internal static class Questao3
    {
        public static void Resposta3()
        {
            Console.Clear();
            Console.WriteLine("3 - Descubra a lógica e complete o próximo elemento:\n");
            Console.WriteLine("a) 1, 3, 5, 7, ?\n");
            Console.WriteLine("Resposta a: ");
            Console.WriteLine("Numeros inpares. ? = 9\n\n");


            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ?\n");
            Console.WriteLine("Resposta b: ");
            Console.WriteLine("Numero anterior multiplicado por 2. ? = 128\n\n");


            Console.WriteLine("c)  0, 1, 4, 9, 16, 25, 36, ?\n");
            Console.WriteLine("Resposta c: ");
            Console.WriteLine("Numeros da sequencia somados com numeros impares em sequencia, exemplo 0+1 = 1, 1+3 = 4, 4+5 = 9, 9+7 = 16, 16+9 = 25, 25+11 = 36, 36+13 = ?. ? = 49\n\n");


            Console.WriteLine("d) 4, 16, 36, 64, ?\n");
            Console.WriteLine("Resposta d: ");
            Console.WriteLine("Entre 4 e 16 existem 12 unidades, entre 16 e 36 existem 20 unidades ou seja, foram adicionadas 8 unidades as distancias,entre 36 e 64 existem 28 unidades de distancia, então entre 64 e ? deve haver 28+8 = 36 unidades de distancia, 64+36 = ?. ? = 100\n\n");


            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ?\n");
            Console.WriteLine("Resposta e: ");
            Console.WriteLine("Sequencia de Fibonacci que é a soma do numero anterior, exemplo 1+1=2, 2+1=3, 3+2=5 e etc. ? = 13\n\n");


            Console.WriteLine("f) 2, 10, 12, 16, 17, 18, 19, ?\n");
            Console.WriteLine("Resposta f: ");
            Console.WriteLine("Numeros que começam com a letra D. ? = 200");
            Console.ReadKey();
        }
    }
}
