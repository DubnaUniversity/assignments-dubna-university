using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }

            BubbleSort(array);

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j] = array[j] + array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] = array[j] - array[j + 1];
                    }
                }
            }
        }
    }
}