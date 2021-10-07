using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти количество элементов массива, " +
                "которые больше всех своих соседей одновременно");

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

            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int RowPlus = i+1;
                if (RowPlus > arr.GetLength(0)-1)
                {
                    RowPlus = arr.GetLength(0)-1;
                }
                int RowMinus = i - 1;
                if (RowMinus < 0)
                {
                    RowMinus = 0;
                } 
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int ColumnPlus = j + 1;
                    if (ColumnPlus > arr.GetLength(1)-1)
                    {
                        ColumnPlus = arr.GetLength(1)-1;
                    }
                    int ColumnMinus = j - 1;
                    if (ColumnMinus < 0)
                    {
                        ColumnMinus = 0;
                    }
                    if (arr[i, j] >= arr[RowPlus, j]
                        && arr[i, j] >= arr[i, ColumnPlus]
                        && arr[i, j] >= arr[i, ColumnMinus]
                        && arr[i, j] >= arr[RowMinus, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("\nРезультат: " + count);
        }
    }
}
