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

        static void fill(int[,] arr)
        {
            var r = new Random();

            int n0 = arr.GetLength(0);
            int n1 = arr.GetLength(1);

            for (int i = 0; i < n0; i++)
                for (int j = 0; j < n1; j++)
                    arr[i, j] = r.Next(100);
        }

        static string toString(int[,] arr)
        {
            string result = string.Empty;
            int n0 = arr.GetLength(0);
            int n1 = arr.GetLength(1);
            
            for (int i = 0; i < n0; i++)
            {
                for (int j = 0; j < n1; j++)
                    result += " " + arr[i, j];

                result += "\n";
            }
            return result;
        }


        static void Main(string[] args)
        {
            WriteLine("Введите длину массива");

            int n = 0;
            while (!int.TryParse(ReadLine(), out n) || n <= 0)
                WriteLine("Введите положительное целое число");

            var arr = new int[n, n];
            fill(arr);

            WriteLine(toString(arr));

            int max;
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (j >= i)
                        if (j >= (n - i - 1))
                        {
                        }
            
            ReadKey(true);
        }
    }
}
