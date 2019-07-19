using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class InsertSort : Display
    {
        public void PerformInsertSort(int[] arr)
        {
            insertSort(arr);
            DisplayArray("InsertSort",arr);
        }
        static private void insertSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var valor_selecionado = arr[i];
                var indice_anterior = i - 1;

                while (indice_anterior >= 0 && arr[indice_anterior] > valor_selecionado)
                {
                    arr[indice_anterior + 1] = arr[indice_anterior];
                    indice_anterior -= 1;
                }
                arr[indice_anterior + 1] = valor_selecionado;
            }
        }
    }
}
