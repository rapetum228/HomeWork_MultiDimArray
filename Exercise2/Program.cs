using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти максимальный элемент массива\n");
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");

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

            int maxElementArr = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxElementArr < arr[i, j])
                    {
                        maxElementArr = arr[i, j];
                    }
                }


            }
            Console.Write($"\n{maxElementArr} - мaxiмальный элемент массива\n");
        }
    }
}
