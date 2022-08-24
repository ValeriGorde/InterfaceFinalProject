using System;

namespace Task1
{
    public interface ICalculator 
    {
        public void Enter();
        public int Calc(int x, int y);
    }

    
    public class Calculator : ICalculator
    {
        public int Calc(int x, int y)
        {
            return x + y;
        }

        public void Enter()
        {
            Console.WriteLine("---Калькулятор---");
            Console.WriteLine("Введите два числа!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("---Калькулятор---");
            Console.WriteLine("Введите два числа!");
            int result = 0;

            try 
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                result = calculator.Calc(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(result);

        }
    }
}
