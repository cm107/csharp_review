using System;
using System.Linq;

/*
A jagged array is an array-of-arrays where each array can be of different lengths.
Thus, each array in a jagged array occupies their own block of memory.
A multidimensional array, on the other hand, occupies a single block of memory,
and always has the same number of values in each row and collumn.
*/

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i*i;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            foreach (var val in myArray) // Easier and more similar to python. (Can use type int or type var.)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("myArray.Length: " + myArray.Length); // Number of elements
            Console.WriteLine("myArray.Rank: " + myArray.Rank); // Number of dimensions
            Console.WriteLine("myArray.Min(): " + myArray.Min());
            Console.WriteLine("myArray.Max(): " + myArray.Max());
            Console.WriteLine("myArray.Sum(): " + myArray.Sum());

            string[] names = new string[3] {"John", "Mary", "Jessica"};
            string[] names0 = new string[] {"John", "Mary", "Jessica"}; // Can ommit size declaration
            string[] names1 = {"John", "Mary", "Jessica"}; // can omit new operator as well
            Console.WriteLine("names.Length: " + names.Length); // Number of elements
            Console.WriteLine("names.Rank: " + names.Rank); // Number of dimensions

            foreach (string name in names)
            {
                if (name.Contains("s"))
                {
                    Console.WriteLine(name);
                }
            }

            // Multidimensional Arrays
            int[,] grid = { {2, 3}, {5, 6}, {4, 6} };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(grid[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + grid[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("grid.Length: " + grid.Length); // Number of elements
            Console.WriteLine("grid.Rank: " + grid.Rank); // Number of dimensions

            // Jagged Arrays (Array of arrays)
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] {1, 8, 2, 7, 9};
            jaggedArr[1] = new int[] {2, 4, 6};
            jaggedArr[2] = new int[] {33, 42};

            // Jagged Arrays (alternative declaration approach)
            int[][] jaggedArr0 = new int[][]
            {
                new int[] {1, 8, 2, 7, 9},
                new int[] {2, 4, 6},
                new int[] {33, 42}
            };

            Console.WriteLine("jaggedArr.Length: " + jaggedArr.Length); // Number of elements
            Console.WriteLine("jaggedArr.Rank: " + jaggedArr.Rank); // Number of dimensions
        }
    }
}
