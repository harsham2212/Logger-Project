using System;

namespace ProjectLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");
            AddNumber add = new AddNumber();
            add.Sum(2,3);
        }
    }
}
