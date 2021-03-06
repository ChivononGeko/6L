using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l6t9
{
    /*
    * В том же файле и namespace что и класс Program создайте публичную структуру CustomLine.
    * Для структуры CustomLine:
    * 1) Объявите приватное поле length - отвечающее за длину линии, тип поля определите самостоятельно.
    * 2) Объявите приватное поле symbol - отвечающее за символ линии, тип поля определите самостоятельно.
    * Объявите статический публичный метод PrintLine() в структуре CustomLine, который:
    * 1) Ничего не возвращает.
    * 2) Отвечает за отрисовку экземпляра структуры в консоли и принимает его в качестве входящего параметра.
    * 3) После того как линия отрисована, указатель консоли должен быть переведен на новую строку.
    * Объявите конструктор для структуры CustomLine, который принимает и устанавливает длину линии и символ отрисовки.
    * Внутри метода Main() создайте три экземпляра структуры CustomLine c длиной 10 и символами * 8 $, после чего
    * отрисуйте все 3 созданных экземпляра в консоли.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            new CustomLine(10, "$");
            new CustomLine(10, "8");
            new CustomLine(10, "*");
        }
    }
    public struct CustomLine
    {
        private int length;
        private string symbol;
      public static void PrintLine(CustomLine customline)
      {
        Console.WriteLine(customline);
      }
      public CustomLine(int length, string symbol)
      {
          this.length = length;
          this.symbol = symbol;
          for (int i = 0; i < this.length; i++)
          {
              Console.Write(this.symbol);
          }
         Console.WriteLine("");
      }
    }
}