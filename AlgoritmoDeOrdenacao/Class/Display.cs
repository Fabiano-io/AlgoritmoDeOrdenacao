using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class Display
    {
        public void DisplayArray(string description, int[] arr)
        {
            Console.Write(Environment.NewLine);
            Console.Write(description + Environment.NewLine);
                                   
            for (int i = 0; i < arr.Length; i++)
            { Console.Write("[{0}]", arr[i]); }

            Console.ReadLine();
        }
    }
}
