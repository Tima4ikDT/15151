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

    // Конкретная реализация функции котангенса
    public class Cotangent : IFunction
    {
        public double Calculate(double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180;
            return 1 / Math.Tan(angleRadians);
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр функции котангенса
            IFunction cotangent = new Cotangent();

            // Вычисляем котангенс с помощью интерфейса
            double result = cotangent.Calculate(45);

            Console.WriteLine(result);
        }
    }
}