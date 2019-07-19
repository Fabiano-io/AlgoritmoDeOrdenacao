namespace AlgoritmoDeOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 1, 4, 3 };
            Class.InsertSort insertSort = new Class.InsertSort();
            insertSort.PerformInsertSort(arr);


            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.SelectionSort selectionSort = new Class.SelectionSort();
            selectionSort.PerformSelectionSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.BubbleSort bubbleSort = new Class.BubbleSort();
            bubbleSort.PerformBubbleSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.ComboSort comboSort = new Class.ComboSort();
            comboSort.PerformComboSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.MergeSort mergeSort = new Class.MergeSort();
            mergeSort.PerformMergeSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.QuickSort quickSort = new Class.QuickSort();
            quickSort.PerformQuickSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.HeapSort heapSort = new Class.HeapSort();
            heapSort.PerformHeapSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.ShellSort shellSort = new Class.ShellSort();
            shellSort.PerformShellSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.RadixSort radixSort = new Class.RadixSort();
            radixSort.PerformRadixSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.GnomeSort gnomeSort = new Class.GnomeSort();
            gnomeSort.PerformGnomeSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.CountingSort countingSort = new Class.CountingSort();
            countingSort.PerformCountingSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.BucketSort bucketSort = new Class.BucketSort();
            bucketSort.PerformBucketSort(arr);

            arr = new int[] { 5, 2, 1, 4, 3 };
            Class.Cocktail cocktail = new Class.Cocktail();
            cocktail.PerformCocktail(arr);
        }
    }
}
