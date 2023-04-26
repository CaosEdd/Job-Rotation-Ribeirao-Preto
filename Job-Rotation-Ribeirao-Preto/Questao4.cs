using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation_Ribeirao_Preto
{
    internal static class Questao4
    {
        public static void Resposta4()
        {
            Console.Clear();
            Console.WriteLine("4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?");
            Console.WriteLine("\r\nIMPORTANTE:\r\n\r\n" +
                "a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.\r\n\r\n" +
                "b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)\r\n\r\n" +
                "c) Explique como chegou no resultado.\n\n");
            Console.WriteLine("Resposta:");
            Console.WriteLine("Ambos estarão a mesma distancia de Ribeirão preto pois estão se cruzando, então sua posição é a mesma." +
                "Já em relação ao ponto de encontro, está a 60,9 km de Ribeirão Preto e a equação usada para determinar o ponto de encontro foi:" +
                " \"distancia = velocidadeCarro * tempo\"" +
                " para o carro e: \"distancia = 100km - velocidadeCaminhão * tempo\" para o caminhão");
            Console.WriteLine("Outras formulas usadas: TempoTotalCaminhão(sem pedagios) = distanciaTotal/velocidadeConstante = 1,25h \n" +
                "VelocidadeCaminhão = distanciaTotal/tempoCaminhão(com pedagios) = 70,6 km/h");


            Console.ReadKey();
        }
    }
}
