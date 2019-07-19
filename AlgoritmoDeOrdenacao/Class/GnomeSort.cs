using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class GnomeSort : Display
    {
        public void PerformGnomeSort(int[] arr)
        {
            gnomeSort(arr);
            DisplayArray("GnomeSort",arr);
        }
                
        static void gnomeSort(int[] arr)
        {
            for (int i = 1, temp_value; i < arr.Length;)
            {
                if (arr[i - 1] <= arr[i])
                    i += 1;
                else
                {
                    temp_value = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp_value;
                    i -= 1;
                    if (i == 0)
                        i = 1;
                }
            }
        }
    }
}
