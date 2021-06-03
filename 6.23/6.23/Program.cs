using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t23
{
    /*
    * Задан динамический массив arr, известно, что внутри массива arr имеются: сроки, целые и дробные числа, логические значения.
    * Внутри метода Main() реализуйте следующую логику:
    * 1) Создайте 4 типизированных списка, в соответствии с возможными типами внутри динамического массива arr.
    * 2) Рассортируйте все элементы массива arr по соответствующим спискам в зависимости от типа элемента.
    * 3) Выведите на экран информацию о получившихся списках в следующем формате:
    * "Список целых чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
    * "Список строк включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
    * "Список дробных чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
    * "Список логических значений включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
    * Последней строкой выведите на экран общее количество элементов, которые содержались в динамическом массиве arr.
    * Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList() { "ч", 1, 2, 3, "q", true, false, "й", 1.11, 2.2, 1d, 2d, 17, 17.0, 123, "int32", false, true };
            /* Добавьте свой код ниже */
            List<int> A = new List<int>();
            List<double> B = new List<double>();
            List<string> C = new List<string>();
            List<bool> D = new List<bool>();

            for (int i = 0; i < arr.Count; i++)
            {
                string arr1 = Convert.ToString(arr[i]);
                if (Double.TryParse(arr1, out double e) == true)
                {
                    double b = Double.Parse(arr1);
                    if(b - Math.Floor(b)==0)
                    {
                        int a = Convert.ToInt32(b);
                        A.Add(a);
                    }
                    else
                    {
                        B.Add(b);
                    }
                }
                else if (arr1=="True" || arr1 == "False")
                {
                    bool d = Convert.ToBoolean(arr[i]);
                    D.Add(d);
                }
                else
                {
                    C.Add(arr1);
                }
            }
            foreach(int a in A)
            {
                Console.Write($"{a}\t");
            }
            Console.WriteLine();
            foreach (double b in B)
            {
                Console.Write($"{b}\t");
            }
            Console.WriteLine();
            foreach (string c in C)
            {
                Console.Write($"{c}\t");
            }
            Console.WriteLine();
            foreach (bool d in D)
            {
                Console.Write($"{d}\t");
            }
        }
    }
}