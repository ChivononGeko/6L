using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t21
{
    /*
    * Реализуйте метод IntMultiply(), который должен принимать два целых числа N (столбец) и M (строка) и выводить на экран
    * матрицу размером N на M, заполненную числом 1. Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            IntMultiply(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
        }
        public static void IntMultiply(int n, int m)
        {
            /* Добавьте свой код ниже */
            int[,] matr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i,j] = 1;
                    Console.Write($"{matr[i, j]}\t");
                }
                Console.WriteLine();
            }
           
        }
    }
}