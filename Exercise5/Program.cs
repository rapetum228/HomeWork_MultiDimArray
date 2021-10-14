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
            Console.WriteLine();
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
        
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bool rowPlus, rowMinus, columnPlus, columnMinus;

                    rowPlus = (i + 1 > arr.GetLength(0) - 1) || (arr[i, j] >= arr[i + 1, j]);
                    columnPlus = (j + 1 > arr.GetLength(1) - 1) || (arr[i, j] >= arr[i, j + 1]);
                    rowMinus = (i - 1 < 0) || (arr[i, j] >= arr[i - 1, j]);
                    columnMinus = (j - 1 < 0) || (arr[i, j] >= arr[i, j - 1]);
                    /*
                    if (i + 1 > arr.GetLength(0) - 1)
                        rowPlus = true;
                    else rowPlus = arr[i, j] >= arr[i + 1, j];

                    if (j + 1 > arr.GetLength(1) - 1)
                        columnPlus = true;
                    else columnPlus = arr[i, j] >= arr[i, j + 1];

                    if (i - 1 < 0)
                        rowMinus = true;
                    else rowMinus = arr[i, j] >= arr[i-1, j];

                    if (j - 1 < 0)
                        columnMinus = true;
                    else columnMinus = arr[i, j] >= arr[i , j - 1];
                    */
                    if (rowPlus && rowMinus && columnPlus && columnMinus)
                    {
                        count++;
                        Console.WriteLine(arr[i, j]);
                    }
                    
                }
            }
            Console.WriteLine("\nРезультат: " + count);
        }
    }
}
