using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class BubbleSort : Display
    {
        public void PerformBubbleSort(int[] arr)
        {
            bubbleSort(arr);
            DisplayArray("BubbleSort", arr);
        }
        static private void bubbleSort(int[] arr)
        {
            int t;

            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
    }
}
