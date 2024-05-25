using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Интерфейс для операций с числами
    public interface ICalculator
    {
        double Calculate(double num);
    }

    // Реализация операции квадратного корня
    public class SquareRootCalculator : ICalculator
    {
        public double Calculate(double num)
        {
            if (num < 0)
            {
                throw new ArithmeticException("Квадратный корень из отрицательного числа не определен");
            }
            return Math.Sqrt(num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра калькулятора
            ICalculator calculator = new SquareRootCalculator();

            // Использование калькулятора для вычисления
            double result = calculator.Calculate(16);

            Console.WriteLine(result);
        }
    }
}