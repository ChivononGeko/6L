using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t6
{
    /*
    * Реализуйте метод MakeIntArray(), который должен возвращать массив из N чисел, заполненный
    * случайными целыми числами от 1 до 100 включительно.
    * Реализуйте метод MakeCustomIntArray(), который должен:
    * 1) Принимать в себя массив целых чисел и параметр А.
    * 2) Выводить на экран все элементы полученного массива, которые меньше или равны параметру А. Каждый элемент с новой строки.
    * 3) Иметь исходящий параметр, с количеством элементов, удовлетворяющих данному условию.
    * Внутри метода Main() вызовите метод MakeCustomIntArray(), передав ему в качестве аргументов произвольное число и
    * результат вызова метода MakeIntArray(). Присвойте переменной r исходящий параметр метода MakeCustomIntArray().
    * Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            int r ;
            MakeCustomIntArray(MakeIntArray(), 23);
            Console.WriteLine(r);
        }
        /* Добавьте свой код ниже */
        public static void MakeIntArray()
        {
            int[] Ch = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Ch[i] = rand.Next(100);
            }
           
        }
        public static void MakeCustomIntArray(int[]Ch,int A)
        {
            int r = 0;
            for (int i = 1; i < 100+1; i++)
            {
                if (Ch[i]<=A)
                {
                    Console.WriteLine(Ch[i]);
                    r++;
                }
            }
        }


    }
}