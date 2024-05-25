using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для операций с числами
    public interface ICalculator
    {
        double Calculate(double num1, double num2);
    }

    // Реализация операции возведения в степень
    public class ExponentiationCalculator : ICalculator
    {
        public double Calculate(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра калькулятора
            ICalculator calculator = new ExponentiationCalculator();

            // Использование калькулятора для вычисления
            double result = calculator.Calculate(2, 3);

            Console.WriteLine(result);
        }
    }
}