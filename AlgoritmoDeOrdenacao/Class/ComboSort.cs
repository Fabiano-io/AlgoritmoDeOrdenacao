using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class ComboSort : Display
    {
        public void PerformComboSort(int[] arr)
        {
            comboSort(arr);
            DisplayArray("ComboSort",arr);
        }
        static private void comboSort(int[] arr)
        {
            int i, j, intervalo, trocado = 1;
            int aux;
            intervalo = arr.Length;

            while (intervalo > 1 || trocado == 1)
            {
                intervalo = intervalo * 10 / 13;
                if (intervalo == 9 || intervalo == 10) intervalo = 11;
                if (intervalo < 1) intervalo = 1;
                trocado = 0;
                for (i = 0, j = intervalo; j < arr.Length; i++, j++)
                {
                    if (arr[i] > arr[j])
                    {
                        aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                        trocado = 1;
                    }
                }
            }
        }
    }
}
