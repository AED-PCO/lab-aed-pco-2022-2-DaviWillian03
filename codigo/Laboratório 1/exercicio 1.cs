using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

for(int i=1000; i<=9999; i++)
{
    int untilhundred = i/100;
    int untilten = i% 100;
     if(Math.Pow((untilhundred+untilten), 2)==i)
        Console.WriteLine("{0}", i);
}

                            }

    }
}
