using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("C = vetor");
for(int i =0; i<a.Length; i++)
Console.Write(c[i]+"\t");
Console.WriteLine();
Console.WriteLine("D = vetor");
for(int i =0; i<a.Length; i++)
    Console.Write(d[i]+"\t");

float []a = new float[5]{10, 11, 12, 13, 14};
float []b = new float[5]{8, 9, 10, 12, 14};
float []c = new float[5];
float []d = new float[5];
vetorcor(a, b);

void vetorcor( float []vetorA, float []vetorB)
{
for (int  i = 0; i < vetorA.Length; i++ ){
    int cont=0;
    for(int j=0; j<vetorB.Length; j++){
        if(vetorA[i]==vetorB[j]){
            c[i]=vetorA[i];
            cont++;
        }
    }
    if(cont==0)
        d[i]=vetorA[i];
        cont=0;
    }
}     

        }

    }

}