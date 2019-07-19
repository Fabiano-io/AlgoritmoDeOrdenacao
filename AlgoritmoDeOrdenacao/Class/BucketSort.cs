using System;
using System.Collections.Generic;

namespace AlgoritmoDeOrdenacao.Class
{
    class BucketSort : Display
    {
        public void PerformBucketSort(int[] arr)
        {
            bucketSort(arr);
            DisplayArray("BucketSort",arr);
        }        
        static void bucketSort(int[] arr){
            int min = int.MaxValue;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }

            List<int>[] b = new List<int>[max - min + 1];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new List<int>();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                b[arr[i] - min].Add(arr[i]);
            }

            int k = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].Count > 0)
                {
                    for (int j = 0; j < b[j].Count; j++)
                    {
                        arr[k] = b[i][j];
                        k++;
                    }
                }
            }

        }
    }
}
