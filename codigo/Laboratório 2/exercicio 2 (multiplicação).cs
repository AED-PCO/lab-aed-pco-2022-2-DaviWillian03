// See https://aka.ms/new-console-template for more information
   static void Exercicio 2 do lab 2()
    {


        int N1, N2, result;

        Console.WriteLine("Digite um numero inteiro:");
        N1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor inteiro:");
        N2 = int.Parse(Console.ReadLine());

        result = Multiplicacao(N1, N2);
        Console.WriteLine("A multiplicação de {0} X {1} é: {2}", N1, N2, result);
    }

    static int Multiplicacao(int valor1,int valor2)
    {
        if (valor2 == 0)
        {
            return N2;
        }
        else
        {
            return N1 + Multiplicacao(N1, N2 - 1);
        }
    }
