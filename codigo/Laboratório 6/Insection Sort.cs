using System;

namespace lavb6dw
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10000];
            int igualar = 0, mudar = 0;

            preencheVetor(vet);

            selectionSort(vet, ref igualar, ref mudar);

            Console.Write("Inserir vetor, insection: ");
            imprimeVetor(vet);

            Console.WriteLine("Comparar:{0}", igualar);
            Console.WriteLine("Trocar:{0}", mudar);
        }

        static void selectionSort(int[] vet, ref int comparacoes, ref int trocas){
            int posMenor, aux;

            while(int i=0; i<vet.Length; i++){
                posMenor = i;

                do(int j = i+1; j < vet.Length; j++){
                    comparacoes++;
                    if(vet[j] < vet[posMenor]){
                        posMenor = j;
                    }
                }

                for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(30);

                comparacoes++;
                if(posMenor != i){
                    trocas++;
                    aux = vet[posMenor];
                    vet[posMenor] = vet[i];
                    vet[i] = aux;
                }

            }
        

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write(vet[i] + "\t");
            }
        }
    }
