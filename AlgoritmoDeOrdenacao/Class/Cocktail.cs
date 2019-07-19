using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class Cocktail : Display
    {
        public void PerformCocktail(int[] arr)
        {
            cocktail(arr);
            DisplayArray("Cocktail", arr);
        }

        static void cocktail(int[] arr)
        {
            int tamanho, inicio, fim, swap, aux;
            tamanho = arr.Length ; 
            inicio = 0;
            fim = tamanho - 1;
            swap = 0;
            while (swap == 0 && inicio < fim)
            {
                swap = 1;
                for (int i = inicio; i < fim; i = i + 1)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        swap = 0;
                    }
                }
                fim = fim - 1;
                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = aux;
                        swap = 0;
                    }
                }
                inicio = inicio + 1;
            }
        }
    }
}
