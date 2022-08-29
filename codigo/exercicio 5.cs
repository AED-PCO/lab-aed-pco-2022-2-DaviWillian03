using System;

namespace roteiro_1_dw
{
    class Program
    {
        static void Main(string[] args)
        {

int [,]A = new int [5, 3]; 

Console.Write("Insira numeros inteiros para a MatrizA");
LeMatriz(A); 
imprimeMatriz(A);
float coluna1 = SC(A, 0);
float coluna2 = SC(A, 1);
float coluna3 = SC(A, 2);

float linha1 = SM(A, 0);
float linha2 = SM(A, 1);
float linha3 = SM(A, 2);
float linha4 = SM(A, 3);
float linha5 = SM(A, 4);
Console.Write("coluna(soma) =: {0}, {1} e {2}", coluna1, coluna2, coluna3);
Console.Write("linha(soma) =: {0}, {1}, {2}, {3} e {4}", linha1, linha2, linha3, linha4, linha5);

float SM(int [,] A, int col)
{ 
float soma=0;
for (int i = 0; i < A.GetLength(0); i++)       
        soma+= A[i, col];
return soma;
}

float SL(int [,] A, int linha)
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
        Matriz[i,
               j] = int.Parse(Console.ReadLine()); 
    }
}

void imprimeMatriz(int [,] A)
{ 
int i, j; 
for (i = 0; i < A.GetLength(0); i++) {
    for (j = 0; j < A.GetLength(1); j++) 
        Console.Write( A[i, j] + "\t") ;
    Console.Write();
}
}

        }

    }

}