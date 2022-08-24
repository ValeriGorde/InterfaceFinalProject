using System;

namespace Task2
{
    public interface ILogger 
    {
        void Event(int a, int b);
        void Error();
    }

    public class Logger : ILogger
    {
        public void Error()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели неверное число!");
        }

        public void Event(int a, int b)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(a+b);
        }
    }

    public interface IWorker 
    {
        void Work();
    }
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var calculate = new Calculate(Logger);

            try 
            {
                calculate.Work();
                Console.ReadKey();
            }
            catch (Exception)
            {
                calculate.ErrorMessage();
            }
            
        }
    }
}
