using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t19
{
    /*
    * Реализуйте статический метод WordSorter() который:
    * 1) Принимает строку произвольной длины.
    * 2) Формирует и возвращает новую строку так, чтобы буквы каждого слова принятой строки были отсортированы по алфавиту.
    * 3) Если слово содержит буквы не русского алфавита или цифры - оно должно остаться без изменения.
    * Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            string s1= "Красивая строка с1223 123";
            string s2 = "Один два три";
            string s3 = "Арбу3";
            Console.WriteLine(WordSorter(s1));
            Console.WriteLine(WordSorter(s2));
            Console.WriteLine(WordSorter(s3));
        }
        public static string WordSorter(string s)
        {
            /* Добавьте свой код ниже */
            string[] mass = s.Split(' ');
            string ex;
            for (int i = 0; i < mass.Length - 1; i++)
                for (int j = i; j >= 0; j--)
                    if (String.Compare(mass[j], mass[j + 1]) > 0)
                    {
                        ex = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = ex;
                    }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]}\t");
            }


            return null;
        }
    }
}