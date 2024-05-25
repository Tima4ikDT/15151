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

    // Конкретная реализация функции тангенса
    public class Tangent : IFunction
    {
        public double Calculate(double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180;
            return Math.Tan(angleRadians);
        }
    }

    // Главный класс программы
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр функции тангенса
            IFunction tangent = new Tangent();

            // Вычисляем тангенс с помощью интерфейса
            double result = tangent.Calculate(45);

            Console.WriteLine(result);
        }
    }
}
