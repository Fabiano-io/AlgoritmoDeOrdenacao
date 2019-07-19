using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class RadixSort : Display
    {
        public void PerformRadixSort(int[] arr)
        {
            radixSort(arr);
            DisplayArray("RadixSort",arr);
        }
        static void radixSort(int[] vetor)
        {
            int i;
            int[] b;
            int maior = vetor[0];
            int exp = 1;

            b = new int[vetor.Length];

            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];
            }

            while (maior / exp > 0)
            {
                int[] bucket = new int[10];
                for (i = 0; i < vetor.Length; i++)
                    bucket[(vetor[i] / exp) % 10]++;
                for (i = 1; i < 10; i++)
                    bucket[i] += bucket[i - 1];
                for (i = vetor.Length - 1; i >= 0; i--)
                    b[--bucket[(vetor[i] / exp) % 10]] = vetor[i];
                for (i = 0; i < vetor.Length; i++)
                    vetor[i] = b[i];
                exp *= 10;
            }
        }
    }
}
