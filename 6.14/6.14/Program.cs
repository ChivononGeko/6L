using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t14
{
    /*
    * Внутри метода Main() создайте массив из 10 целых чисел и сохраните его в соответствующую переменную.
    * Считайте с клавиатуры 10 чисел и добавьте их в массив. Отсортируйте полученный массив в порядке возрастания
    * и выведите его на экран, каждый элемент массива с новой строки. Методом Sort пользоваться нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int[] massa = new int[10];
            for (int i = 0; i < massa.Length; i++)
            {
                massa[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <massa.Length-1; i++)
            {
                for (int j =i+1; j < massa.Length; j++)
                {
                    if (massa[i]>massa[j])
                    {
                        int a = massa[i];
                        massa[i] = massa[j];
                        massa[j] = a;
                    }
            
                }
            }
            for (int i = 0; i < massa.Length; i++)
            {
                Console.WriteLine(massa[i]);
            }
        }
    }
}