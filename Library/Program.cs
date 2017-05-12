using System;

namespace Library
{
    class Program
    {
        static int Main(string[] args)
        {
            var obj = new Object();
            Console.WriteLine(obj.GetType());
            Console.ReadLine();
            return 0;
        }
    }
}
