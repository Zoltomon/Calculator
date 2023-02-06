using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("Введите слово Сложение если нужно сложение");
            Console.WriteLine("Введите слово Вычитание если нужно вычитание");
            Console.WriteLine("Введите слово Умножение если нужно умножить");
            Console.WriteLine("Введите слово Деление если нужно разделить");
            Console.WriteLine("Писать первую с большой, а остальные нижнего регистра!");
            Console.WriteLine("Если не целое число то нужо ставить запятую, а не точку!!!");
 
            string operation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите число 1");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            double second = Convert.ToDouble(Console.ReadLine());
            double result = 0;

           
            switch (operation)
            {
                case "Сложение":
                    result = Function.Plus(second, first);
                    break;
                case "Вычитание":
                    result = Function.Minus(second, first);
                    break;
                case "Умножение":
                    result = Function.Multiplication(second, first);
                    break;
                case "Деление":
                    result = Function.Division(second, first);
                    break;
                default:
                    Console.WriteLine("Ошибочная ошибка");
                    Console.WriteLine("Responce: 404");
                    break;
            }
            Console.WriteLine("Результат:" + " " + result);
            Console.ReadKey();
        }
    }
    #region Математические операции
    class Function
    {
        public static double Plus(double second, double first)
        {
            double result = first + second;
            return result;
        }
        public static double Minus(double second, double first)
        {
            double result = first - second;
            return result;
        }
        public static double Multiplication(double second, double first)
        {
            double result = first * second;
            return result;
        }
        public static double Division(double second, double first)
        {
            double result = first / second;
            return result;
        }

    }
    #endregion
}
