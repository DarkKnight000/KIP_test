using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_test
{
    internal class Program
    {
        private static int N, M;
        private static int[,] mas;
        static void Main(string[] args)
        {

            while (true) 
            {
                try
                {
                    Console.WriteLine("Введите количество строк в массиве:");
                    N = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nВведите натуральное целое число\n");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество столбцов в массиве:");
                    M = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nВведите натуральное целое число\n");
                }
            }

            mas = new int[N, M];
            Random rnd = new Random();

            Console.WriteLine("\nМассив: \n");

            for (int i = 0; i < M; i++)
            {
                Console.Write($"\t[{i+1}]");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write($"[{i + 1}] \t");

                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = rnd.Next(-100, 100);
                    Console.Write(mas[i,j] + "\t");
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine($"\nМинимальное число в массиве: {Min(mas)}");
            Console.WriteLine($"\nМаксимальное число в массиве: {Max(mas)}");
            Console.WriteLine();
            Avg();

            Console.ReadKey();
        }

        private static int Min(int[,] mas)
        {
            int min = 2147483647;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
            }

            return min;
        }

        private static int Max(int[,] mas)
        {
            int max = -2147483648;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
            }

            return max;
        }

        private static void Avg()
        {
            double avg = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    avg += mas[i, j];
                }
                avg /=  M;
                Console.WriteLine($"Среднее арифметическое {i+1} строки = {avg}");

                avg = 0;
            }

        }
    }
}
