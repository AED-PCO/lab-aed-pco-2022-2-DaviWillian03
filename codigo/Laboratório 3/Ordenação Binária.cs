 public static int[] insertionSort(int[] vetor)
{

    int i, j, atual;

    for (i = 1; i < vetor.Length; i++)

    {

        atual = vetor[i];

        j = i;

        while ((j > 0) &amp;&amp; (vetor[j - 1] > atual))

        {

            vetor[j] = vetor[j - 1];

            j = j - 1;

        }

        vetor[j] = atual;

    }

    return vetor;

}
