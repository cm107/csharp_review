using System;

/*
There are three ways to pass arguments to a method when the method is called:
By value, By reference, and as Output.

The ref keyword passes the memory address to the method parameter, which allows
the method to operate on the actual variable.

The ref keyword is used both when defining the method and when calling it.

Output parameters are similar to reference parameters, except that they transfer
data out of the method rather than accept data in.
They are defined using the out keyword.

ref tells the compiler that the object is initialized before entering the
function, while out tells the compiler that the object will be initialized inside
the function.
*/

namespace methods
{
    class Program
    {
        // Parameters
        static void Print(int x)
        {
            Console.WriteLine(x);
        }

        // Method Overloading
        static void Print(double x)
        {
            Console.WriteLine(x);
        }

        // Multiple Parameters
        static int Sum(int x, int y)
        {
            return x + y;
        }

        // Optional Parameters (default values)
        static void FavoriteNumber(int fav_num, string name="Anon")
        {
            Console.WriteLine("{0}: My favorite number is {1}", name, fav_num);
        }

        // Pass by value
        static void PrintSqrByVal(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        // Pass by reference
        static void PrintSqrByRef(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        // Pass by output
        static void PrintTwoSqrByOutput(out int x)
        {
            x = 2;
            x = x * x;
            Console.WriteLine(x);
        }

        // Recursion
        static int Factorial(int num) {
            if (num < 0) {
                throw new ArgumentOutOfRangeException("Cannot calculate factorial of negative number.");
            }
            if (num == 1 || num == 0) {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        static void DrawPyramid(int n)
        {
            int maxNumStars = 2 * n - 1;
            for (int i = 1; i <= n; i++)
            {
                int numStars = 2 * i - 1;
                int numLeadingSpaces = (maxNumStars - numStars) / 2;
                for (int j = 1; j <= numLeadingSpaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= numStars; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= numLeadingSpaces; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Print(Sum(4, 2));
            Print(3.152);
            FavoriteNumber(7, "Clayton");
            FavoriteNumber(8);

            // Named Arguments
            // Doing this makes it so that you don't have to remember
            // the order of the arguments.
            // (Thank God!)
            FavoriteNumber(name: "Sensei", fav_num: 10);

            int x = 2;
            Console.WriteLine("Original:");
            Print(x);
            PrintSqrByVal(x);
            Console.WriteLine("After passing by value:");
            Print(x);
            PrintSqrByRef(ref x);
            Console.WriteLine("After passing by reference:");
            Print(x);
            Console.WriteLine("Pass by output:");
            int y;
            PrintTwoSqrByOutput(out y);

            Console.WriteLine("Factorial(5): " + Factorial(5));
            Console.WriteLine("Factorial(0): " + Factorial(0));
            DrawPyramid(3);
            DrawPyramid(20);
        }
    }
}
