using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine("insira um numero inteiro");
int primo= int.Parse(Console.ReadLine());
int final= primo2(primo);
if(final==0)
    Console.WriteLine("numero primo");        
else
    Console.WriteLine("não é primo");

int primo2(int primo){
    int sup=0;
    for(int i=2; i<primo; i++){
        if(primo%i == 0)
            sup++;
}
    return sup;
}


for(int i=1; i<1000; i++){
    int b=0;
    for(int j=1; j<i; j++)
    {
        int a=0;
        a = divisor(i,j);
        if(a>0)
            b=soma(b,a);
    }
    if(b==i)
        Console.WriteLine(b);
}

int soma(int x, int y)
{
    return (x+y);
}

int divisor( int n, int p)
{
    if(n%p==0)
        return p;
    else
        return 0;
}

        }

    }

}
