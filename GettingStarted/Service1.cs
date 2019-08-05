using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStarted
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class CalculatorService : ICalculator
    {
        public double Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine("Received Add({0},{1})", x, y);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Divide(double x, double y)
        {
            double result = x / y;
            Console.WriteLine("Received Divide({0},{1})", x, y);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine("Received Multiply({0},{1})", x, y);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Subtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine("Received Subtract({0},{1})", x, y);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
    }
}
