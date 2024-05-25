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

    // Конкретная реализация функции косинуса
    public class Cosine : IFunction
    {
        public double Calculate(double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180;
            return Math.Cos(angleRadians);
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр функции косинуса
            IFunction cosine = new Cosine();

            // Вычисляем косинус с помощью интерфейса
            double result = cosine.Calculate(60);

            Console.WriteLine(result);
        }
    }
}
