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

    // Конкретная реализация операции вычитания
    public class Subtraction : IOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр операции вычитания
            IOperation subtraction = new Subtraction();

            // Выполняем вычитание с помощью интерфейса
            double result = subtraction.Calculate(5, 3);

            Console.WriteLine(result);
        }
    }
}