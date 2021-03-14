using System;

namespace printing_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = "Hello, World!";
            Console.WriteLine(var); // \n char included
            Console.WriteLine("Formatted String: {0}", var);
            Console.Write("1"); // \n char not included in Console.Write
            Console.Write("2");
            Console.Write("\n");
        }
    }
}
