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
        static void Main(string[] args)
        {
            WriteLine("Введите длину массива");

            int n = 0;
            while (!int.TryParse(ReadLine(), out n) || n <= 0)
                WriteLine("Введите положительное целое число");

            var arr = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if(j > i)
                        if (j > (n - i))
                            arr[i,j] = 1;
                }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Write(" {0}",arr[i,j]);
                WriteLine();
            }

            ReadKey(true);
        }
    }
}
