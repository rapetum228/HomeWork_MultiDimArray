using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс минимального элемента массива");
            Console.WriteLine("Введите размер массива");
            Random rnd = new Random();
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[lengthArr, lengthArr];

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-150, 150);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int minElementArr = 0;
            int minRowInd = 0;
            int minColumnInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElementArr > arr[i, j])
                    {
                        minRowInd = i;
                        minColumnInd = j;
                        minElementArr = arr[i, j];
                    }
                }


            }
            Console.Write($"\n{minElementArr} - минимальный элемент массива\n" +
                $"Его координаты - ({minRowInd}, {minColumnInd})\n");
        }
    }
}
