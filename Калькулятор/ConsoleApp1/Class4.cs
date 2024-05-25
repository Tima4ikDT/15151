using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для математических операций
    public interface IOperation
    {
        double Calculate(double num1, double num2);
    }

    // Конкретная реализация операции деления
    public class Division : IOperation
    {
        public double Calculate(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Невозможно разделить на ноль");
            }
            return num1 / num2;
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр операции деления
            IOperation division = new Division();

            // Выполняем деление с помощью интерфейса
            double result = division.Calculate(5, 3);

            Console.WriteLine(result);
        }
    }
}