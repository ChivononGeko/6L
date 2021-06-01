using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t17
{
 /*
* Реализуйте метод GetArrayFromConsole(). Метод должен:
* 1) Принимать число N в качестве входящего параметра.
* 2) Создавать массив из N элементов и заполнять его строками, считанными с клавиатуры.
* 3) Возвращать созданный массив строк из N элементов.
* Если передано число N меньше 1, то размер возвращаемого массива должен быть равен 1.
* Если передано число больше 10, то размер возвращаемого массива должен быть равен 10.
* Внутри метода Main() выведите на экран информацию о массиве arr в следующем формате:
* 1) "Количество элементов массива: ХХХ"
* 2) "Минимальная длина элемента массива: ХХХ"
* 3) "Максимальная длина элемента массива: ХХХ"
* Выведите на экран 5 и 10 элемент массива.Шаблон задачи изменять нельзя.
 */
public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = GetArrayFromConsole(5);
            /* Добавьте свой код ниже */
            int max = arr[0].Length;
            int min = arr[0].Length;
            int kol = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].Length)
                {
                    max = arr[i].Length;
                }
                if (min > arr[i].Length)
                {
                    min = arr[i].Length;
                }
                kol++;
            }
            Console.WriteLine($"Kolichestvo elimintov: {kol}\nMinimal'naya dlina elmenta massiva: {min}\nMaksimal'naya dlina elmenta massiva: {max}") ;

        }
        public static string[] GetArrayFromConsole(int x)
        {
            /* Добавьте свой код ниже */
            if (x <= 1)
            {
                 string[] arr1 = new string[1];
                 arr1[0] = Console.ReadLine();
                return arr1;
            }
            else if (x > 10)
            {
                string[] arr1 = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    arr1[i] = Console.ReadLine();
                }
                return arr1;
            }
            else
            {
                string[] arr1 = new string[x];
                for (int i = 0; i < x; i++)
                {
                    arr1[i] = Console.ReadLine();
                }
                return arr1;
            }
        }
    }
}