using System;

/*
Reference types are used for storing objects.
For example, when you create an object of a class, it is stored as a reference
type.
Reference types are stored in a part of the memory called the heap.
When you instantiate an object, the data for that object is stored on the heap,
while its heap memory address is stored on the stack.
That is why it is called a reference type - it contains a reference
(the memory address) to the actual object on the heap.

For example, a p1 object of type Person on the stack stores the memory address of
the heap where the actual object is stored.

Stack is used for static memory allocation, which includes all your value types,
like x.
Heap is used for dynamic memory allocation, which includes custom objects,
that might need additional memory during the runtime of your program.

C# supports the following access modifiers:
public, private, protected, internal, protected internal.

value is a special keyword, which represents the value we assign to a property
using the set accessor.

A property can also be private, so it can be called only from within the class.
*/

namespace basic
{
    class Point2D {
        public double x, y;
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double calcMagnitude()
        {
            return Math.Sqrt(this.x*this.x + this.y*this.y);
        }

        public double magnitude
        {
            get {
                return calcMagnitude();
            }
        }
    }

    class Settings {
        private int age, salary;
        private int _mode;

        // property
        public int mode
        {
            get { return this._mode; }
            set {
                if (value == 0)
                {
                    this._mode = value;
                    this.age = 18;
                    this.salary = 20;
                }
                else if (value == 1)
                {
                    this._mode = value;
                    this.age = 30;
                    this.salary = 40;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Mode: " + value);
                }
            }
        }

        // Auto-Implemented Property
        public string Name {get; set;}

        public Settings(){
            this.mode = 0;
        }

        public Settings(int mode)
        {
            this.mode = mode;
        }

        public void printInfo()
        {
            Console.WriteLine("Mode: " + this.mode);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Salary: " + this.salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D p0 = new Point2D(7.4, 8.2);
            Console.WriteLine("p0.calcMagnitude(): " + p0.calcMagnitude());
            Console.WriteLine("p0.magnitude: " + p0.magnitude);
            Settings settings = new Settings();
            Console.WriteLine("settings.mode: " + settings.mode);
            settings.printInfo();
            settings.mode = 1;
            Console.WriteLine("settings.mode: " + settings.mode);
            settings.printInfo();

            // Auto-Implemented Properties
            Console.WriteLine("settings.Name: " + settings.Name); // Contains nothing before setting.
            settings.Name = "Clayton";
            Console.WriteLine("settings.Name: " + settings.Name);
        }
    }
}
