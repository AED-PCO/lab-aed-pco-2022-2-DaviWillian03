// See https://aka.ms/new-console-template for more information
   static void Atividade2()
    {
        Console.WriteLine("\nEscreva um método recursivo que realize a multiplicação de doisnúmeros inteiros, A e B, recebidos por parâmetro.");

        int valor1, valor2, result;

        Console.WriteLine("\nInsira o primeiro valor desejado:");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nInsira o segundo valor desejado:");
        valor2 = int.Parse(Console.ReadLine());

        result = Multiplicacao(valor1,valor2);
        Console.WriteLine("A multiplicação de {0} X {1} é: {2}", valor1, valor2, result);
    }

    static int Multiplicacao(int valor1,int valor2)
    {
        if (valor2 == 0)
        {
            return valor2;
        }
        else
        {
            return valor1 + Multiplicacao(valor1, valor2 - 1);
        }
    }
