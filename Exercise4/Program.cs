using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс мaxимального элемента массива");
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
            int maxElementArr = 0;
            int maxRowInd = 0;
            int maxColumnInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxElementArr < arr[i, j])
                    {
                        maxRowInd = i;
                        maxColumnInd = j;
                        maxElementArr = arr[i, j];
                    }
                }


            }
            Console.Write($"\n{maxElementArr} - мaxимальный элемент массива\n" +
                $"Его координаты - ({maxRowInd}, {maxColumnInd})\n");
        }
    }
}
