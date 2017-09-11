using System;

using example;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1<object>.GetSelectScript());
            Console.WriteLine("Hello World!");
        }
    }
}