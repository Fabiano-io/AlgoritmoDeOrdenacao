using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class SelectionSort : Display
    {
        public void PerformSelectionSort(int[] arr)
        {
            selectionSort(arr);
            DisplayArray("SelectionSort",arr);
        }
        static private void selectionSort(int[] arr)
        {
            for (int indice = 0; indice < arr.Length; indice++)
            {
                var indiceMenor = indice;

                for (int indiceSeguinte = indice + 1; indiceSeguinte < arr.Length; indiceSeguinte++)
                {
                    if (arr[indiceSeguinte] < arr[indiceMenor])
                    {
                        indiceMenor = indiceSeguinte;
                    }
                }

                var aux = arr[indice];
                arr[indice] = arr[indiceMenor];
                arr[indiceMenor] = aux;
            }
        }
    }
}
