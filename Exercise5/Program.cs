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
        
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bool RP, RM, CP, CM;
                    if (i + 1 > arr.GetLength(0) - 1)
                        RP = true;
                    else RP = arr[i, j] >= arr[i + 1, j];

                    if (j + 1 > arr.GetLength(1) - 1)
                        CP = true;
                    else CP = arr[i, j] >= arr[i, j + 1];

                    if (i - 1 < 0)
                        RM = true;
                    else RM = arr[i, j] >= arr[i-1, j];

                    if (j - 1 < 0)
                        CM = true;
                    else CM = arr[i, j] >= arr[i , j - 1];

                    if (RP && RM && CP && CM)
                    {
                        count++;
                    }
                    
                }
            }
            Console.WriteLine("\nРезультат: " + count);
        }
    }
}
