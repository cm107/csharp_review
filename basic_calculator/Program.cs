using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            while(true) {
                string temp;
                Console.Write("x: ");
                temp = Console.ReadLine();
                if(temp == "exit") {
                    break;
                }
                int x = Convert.ToInt32(temp);
                Console.Write("y: ");
                temp = Console.ReadLine();
                if(temp == "exit") {
                    break;
                }
                int y = Convert.ToInt32(temp);
                Console.WriteLine("Sum: {0}", x+y);
            }
        }
    }
}
