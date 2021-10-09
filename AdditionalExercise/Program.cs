using System;

namespace AdditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделать красивый вывод массива\n");

            Console.WriteLine("Введите размер массива");
            Random rnd = new Random();
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[lengthArr, lengthArr];

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-1500, 1500);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }


            int maxElementArr = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (Math.Abs(maxElementArr) < Math.Abs(arr[i, j]))
                    {
                        maxElementArr = arr[i, j];
                    }
                }
            }
            
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int tempMax = maxElementArr;
                    string probel = "";
                    int temp = arr[i, j];
                    while (temp != 0)
                    {
                        tempMax /= 10;
                        temp /= 10;
                    }
                    while (tempMax != 0)
                    {
                        tempMax /= 10;
                        probel += " ";
                    }
                    if (arr[i, j] >= 0)
                        probel += " ";

                    Console.Write($"{probel}{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
