using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

Console.Write("inserir o valor da base");
int D = int.Parse(Console.ReadLine());
Console.Write("Inserir o valor da potencia");
int pot = int.Parse(Console.ReadLine());
potencia(ref D, pot);
Console.Write("O resultado é: {0}", D);

void potencia (ref int x, int y){
    int sup=x;
    for(int i=1; i<y; i++)
       x=x*sup;
}

        }

    }

}