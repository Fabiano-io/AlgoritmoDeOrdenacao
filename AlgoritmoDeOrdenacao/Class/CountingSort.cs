using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDeOrdenacao.Class
{
    class CountingSort : Display
    {
        public void PerformCountingSort(int[] arr)
        {
            int[] sorted = countingSort(arr);
            DisplayArray("CountingSort", sorted);
        }

        static int[] countingSort(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];

            // find smallest and largest value
            int minVal = arr[0];
            int maxVal = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minVal) minVal = arr[i];
                else if (arr[i] > maxVal) maxVal = arr[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[arr[i] - minVal]--] = arr[i];
            }

            return sortedArray;
        }
    }
}
