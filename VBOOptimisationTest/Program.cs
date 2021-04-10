using System;

namespace VBOOptimisationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new CompositeDrawNode
            {
                new BoxDrawNode()
            };

            Console.WriteLine("Hello world!");
        }
    }
}
