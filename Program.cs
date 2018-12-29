using System;
using System.Collections;

namespace Shell_Sort
{
    public class SortShell
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            show_array_elements(arr);
            ShellSort(arr);
            Console.WriteLine("\nSorted Array Elements :");
            show_array_elements(arr);
            Console.ReadLine();
        }

        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            int atlama = n / 2;
            int temp;

            while (atlama > 0)
            {
                for (int i = 0; i + atlama < n; i++)
                {
                    int j = i + atlama;
                    temp = array[j];

                   if (j - atlama >= 0 && temp < array[j - atlama])
                    {
                        array[j] = array[j - atlama];
                        j = j - atlama;
                    }

                    array[j] = temp;
                }

                atlama = atlama / 2;
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");

        }
    }
}