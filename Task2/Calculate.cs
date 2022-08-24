using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculate : IWorker
    {
        ILogger Logger { get;  }
        public Calculate(ILogger logger) 
        {
            Logger = logger;
        }
        public void Work()
        {
            Console.WriteLine("Введите два целых числа!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Logger.Event(a, b);
        }
        public void ErrorMessage() 
        {
            Logger.Error();
        }
    }
}
