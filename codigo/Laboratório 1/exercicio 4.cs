using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

     
int [,]A = new int [5, 3]; 

Console.WriteLine("Informe valores para a matriz A");
LeMatriz(A); 
imprimeMatriz(A);
float colunaA = somaColuna(A, 0, A, 1, A, 2);


float linhaABC = somalinha(A, 0, A, 1, A,2);
float linhaDE = somalinha(A, 3, A , 4);
Console.WriteLine("Coulunas somadas: {0}, {1} e {2}", colunaA);
Console.WriteLine("A soma dos elementos das linhas foi respectivamente: {0}, {1}, {2}, {3} e {4}", linhaA, linhaB, linhaC, linhaD, linhaE);

float somaColuna(int [,] A, int col)
{ 
float soma=0;
for (int i = 0; i < A.GetLength(0); i++)       
        soma+= A[i, col];
return soma;
}

float somalinha(int [,] A, int linha)
{ 
float soma=0;
for (int i = 0; i < A.GetLength(1); i++)       
        soma+= A[linha, i];
return soma;
}

void LeMatriz(int [,] Matriz) 
{                   
for (int i = 0; i < Matriz.GetLength(0); i++)
    for (int j = 0; j < Matriz .GetLength(1); j++) {
        Console.WriteLine("[{0}, {1}] = ", i, j);
        Matriz[i, j] = int.Parse(Console.ReadLine()); 
    }
}

void imprimeMatriz(int [,] A)
{ 
int i, j; 
for (i = 0; i < A.GetLength(0); i++) 
{
    for (j = 0; j < A.GetLength(1); j++) 
        Console.WriteLine( A[i, j] + "l") ;
    Console.WriteLine();
}
}   

        }

    }

}