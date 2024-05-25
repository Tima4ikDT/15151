using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для математических функций
    public interface IFunction
    {
        double Calculate(double input);
    }

    // Конкретная реализация функции синуса
    public class Sine : IFunction
    {
        public double Calculate(double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180;
            return Math.Sin(angleRadians);
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр функции синуса
            IFunction sine = new Sine();

            // Вычисляем синус с помощью интерфейса
            double result = sine.Calculate(30);

            Console.WriteLine(result);
        }
    }
}
