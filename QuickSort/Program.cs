using System;
/// <summary>
/// Реализуйте алгоритм быстрой сортировки для массива целых чисел.
/// </summary>
namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 4, 8, 9, 6, 2, 1, 5 };
            Show(intArray);
            quicksort(intArray, 0, intArray.Length-1);
            Show(intArray);
            Console.ReadLine();
        }

        static void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }

        static int partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        static void Show(int[] a)
        {
            foreach (var i in a)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
