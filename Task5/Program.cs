using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Task5
{
    class Program
    {
        static readonly Random R = new Random();

        static void fill(int[,] arr)
        {

            int n0 = arr.GetLength(0);
            int n1 = arr.GetLength(1);

            for (int i = 0; i < n0; i++)
                for (int j = 0; j < n1; j++)
                    arr[i, j] = R.Next(100);
        }

        static string toString(int[,] arr, string format = " {0:00}")
        {
            string result = string.Empty;
            int n0 = arr.GetLength(0);
            int n1 = arr.GetLength(1);
            
            for (int i = 0; i < n0; i++)
            {
                for (int j = 0; j < n1; j++)
                    result += string.Format(format,arr[i,j]);

                result += "\n";
            }
            return result;
        }


        static void Main(string[] args)
        {
            WriteLine("Введите размер матрицы");

            int n = 0;
            while (!int.TryParse(ReadLine(), out n) || n <= 0)
                WriteLine("Введите положительное целое число");

            var arr = new int[n, n];
            fill(arr);
            WriteLine(toString(arr));

            var template = new int[n, n];

            int max = int.MinValue;
            for (int i = 0; i < n; i++)
                for (int j = Math.Max(i, n - i - 1); j < n; j++)
                {
                    template[i, j] = arr[i, j];
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            WriteLine("Требуемый регион:\n{0}",toString(template));


            WriteLine("Максимальный элемент требуемого региона: {0}",max);

            //WriteLine(toString(arr));

            ReadKey(true);
        }
    }
}