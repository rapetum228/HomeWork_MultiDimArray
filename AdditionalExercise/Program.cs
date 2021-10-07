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
                    arr[i, j] = rnd.Next(-1100, 1100);
                    int temp = arr[i, j];
                    string probel = " "; string zaProbel = "";
                    while (Math.Abs(temp) < 1000)
                    {
                        temp *= 10;
                        probel += " ";
                        
                    }
                    if (arr[i, j] < 0)
                    {
                        zaProbel = " ";
                    }

                    Console.Write($"{probel}{arr[i, j]}{zaProbel}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
