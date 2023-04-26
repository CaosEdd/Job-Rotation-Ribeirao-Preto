using Job_Rotation_Ribeirao_Preto;

internal class Program
{
    private static void Main(string[] args)
    {
        //Menu
        int op = 1;
        while (op != 0)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo, escolha entre uma das seguintes opções");
            Console.WriteLine("Digite 1 para ir a primeira questão");
            Console.WriteLine("Digite 2 para ir a segunda questão");
            Console.WriteLine("Digite 3 para ir a terceira questão");
            Console.WriteLine("Digite 4 para ir a quarta questão");
            Console.WriteLine("Digite 5 para ir a quinta questão");
            Console.WriteLine("Digite 0 para fechar a aplicação");


            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !char.IsDigit(input[0]))
                continue;
            else
                op = int.Parse(input[0].ToString());



            switch (op)
            {
                case 1:
                    Console.Clear();
                    Questao1.Resposta1();
                    break;


                case 2:
                    Console.Clear();
                    Questao2.Resposta2();
                    break;


                case 3:
                    Console.Clear();
                    Questao3.Resposta3();
                    break;


                case 4:
                    Console.Clear();
                    Questao4.Resposta4();
                    break;


                case 5:
                    Console.Clear();
                    Questao5.Resposta5();
                    break;

                case 0:
                    break;

                default:
                    continue;
            }
        }
    }
}

