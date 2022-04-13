using System;
using System.Diagnostics;

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

The static keyword makes the class members (variables, properties, methods, etc.)
belong to the class itself instead of belonging to individual instances.
No matter how many object instances of a class are created, there is only one
copy of the static member. (It can't be called from the instances, only the class.)
This can, for example, be used to keep track of a universal counter across all
instances of a class.

Note that static methods can access only static members.

Constructors can be declared static to initialize static members of the class.
The static constructor is automatically called once when we access a static member
of the class.

An entire class can be declared as static.
A static class can contain only static members.
You cannot instantiate an object of a static class, as only one instance of the
static class can exist in a program.
Static classes are useful for combining logical properties and methods.
A good example of this is the Math class.
It contains various useful properties and methods for mathematical operations.

The this keyword is used inside the class and refers to the current instance of
the class, meaning it refers to the current object.
One of the common uses of this is to distinguish class members from other data,
such as local or formal parameters of a method.
Another common use of this is for passing the current instance to a method as
a parameter: ShowPersonInfo(this);

The readonly modifier prevents a member of a class from being modified after
construction. It means that the field declared as readonly can be modified only
when you declare it or from within a constructor.
There are three major differences between readonly and const fields.
1. A constant field must be initialized when it is declared, whereas a readonly
field can be declared without initialization.
2. A readonly field value can be changed in a constructor, but a constant
value cannot.
3. A readonly field can be assigned a value that is a result of a calculation,
but constants cannot.

An indexer allows objects to be indexed like an array.
Declaration of an indexer is to some extent similar to a property.
The difference is that indexer accessors require an index.
Like a property, you use get and set accessors for defining an indexer.
However, where properties return or set a specific data member, indexers return
or set a particular value from the object instance.
Indexers are defined with the this keyword.

Overloaded operator methods must be static.

C# does not support multiple inheritance, so you cannot inherit from multiple
classes.
However, you can use interfaces to implement multiple inheritance.

A class can prevent other classes from inheriting it, or any of its members,
by using the sealed modifier.

C# supports nested classes: a class that is a member of another class.
A nested class acts as a member of the class, so it can have the same access
modifiers as other members (public, private, protected).
*/

namespace basic
{
    class Point2D {
        public double x, y;
        private static int count = 0;
        
        // readonly prevents the member from being modified outside of the constructor
        readonly private int idx;

        public int index {
            get {
                return idx;
            }
        }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.idx = count;
            count++;
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

        public static Point2D fromArray(double[] arr)
        {
            Debug.Assert(arr.Length == 2);
            return new Point2D(arr[0], arr[1]);
        }

        public string getString()
        {
            return "Point2D(" + Convert.ToString(this.x) + ", " + Convert.ToString(this.y) + ")";
        }

        // Example of Indexer
        public double this[int index] {
            get {
                if (index == 0) {return this.x;}
                else if (index == 1) {return this.y;}
                else {throw new IndexOutOfRangeException();}
            }
            set {
                if (index == 0) {this.x = value;}
                else if (index == 1) {this.y = value;}
                else {throw new IndexOutOfRangeException();}
            }
        }

        // Example of Operator Overloading
        public static Point2D operator+ (Point2D a, Point2D b)
        {
            return new Point2D(a.x + b.x, a.y + b.y);
        }

        public static Point2D operator- (Point2D a, Point2D b)
        {
            return new Point2D(a.x - b.x, a.y - b.y);
        }

        public static Point2D operator+ (Point2D a, double b)
        {
            return new Point2D(a.x + b, a.y + b);
        }

        public static Point2D operator- (Point2D a, double b)
        {
            return new Point2D(a.x - b, a.y - b);
        }

        public static Point2D operator+ (double a, Point2D b)
        {
            return new Point2D(a + b.x, a + b.y);
        }

        public static Point2D operator- (double a, Point2D b)
        {
            return new Point2D(a - b.x, a - b.y);
        }

        public static Point2D operator* (Point2D a, double b)
        {
            return new Point2D(a.x * b, a.y * b);
        }

        public static Point2D operator* (double a, Point2D b)
        {
            return new Point2D(a * b.x, a * b.y);
        }

        public static Point2D operator/ (Point2D a, double b)
        {
            return new Point2D(a.x / b, a.y / b);
        }
    }

    class Settings {
        private int age, salary;
        private int _mode;

        // Note: Constant members are static by definition.
        public const int MODE0 = 0;
        public const int MODE1 = 1;

        // property
        public int mode
        {
            get { return this._mode; }
            set {
                if (value == Settings.MODE0)
                {
                    this._mode = value;
                    this.age = 18;
                    this.salary = 20;
                }
                else if (value == Settings.MODE1)
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

        // Destructor
        ~Settings()
        {
            // Can be used for releasing resources/memory before exiting program.
            // This can be useful, for example, if your class works with storage or files.
            // E.g. you can close a file in the destructor.
            Console.WriteLine("Deconstructed Settings object.");
        }

        public void printInfo()
        {
            Console.WriteLine("Mode: " + this.mode);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Salary: " + this.salary);
        }
    }

    class Cat {
        public static int count=0; // Example of static variable

        public Cat()
        {
            count++;
        }

        ~Cat()
        {
            count--;
        }
    }

    class DrawConfig
    {
        // static members
        public static string color {get; set;}
        public static int thickness {get; set;}
        public static string font {get; set;}
        public static bool enabled {get; set;}

        // non-static members
        public string name {get; set;}

        // Constructors can be declared static to initialize static members of the class.
        static DrawConfig()
        {
            color = "RED";
            thickness = 2;
            font = "Times New Roman";
            enabled = true;
        }

        public DrawConfig(string name="default")
        {
            this.name = name;
        }
    }

    // Static classes can only contain static members and methods.
    static class MethodHelper
    {
        static public double MagicNumber {get; set;}
        public const double PI = 3.14;

        static MethodHelper()
        {
            MagicNumber = 1.23456;
        }

        static public double Double(double value)
        {
            return value * 2;
        }

        static public double AddTwo(double value)
        {
            return value + 2;
        }
    }

    class Polygon
    {
        public Point2D[] vertices;

        public int n {
            get {
                return this.vertices.Length;
            }
        }

        private string privateInfo = "Only base Polygon knows.";
        protected string familyInfo = "Only those who inherit from base Polygon know.";
        public string publicInfo = "Everyone knows.";

        public Point2D center {
            get {
                Point2D working_center = new Point2D(0, 0);
                foreach (Point2D vertex in this.vertices)
                {
                    working_center += vertex;
                }
                working_center /= this.n;
                return working_center;
            }

            set {
                Point2D displacement = value - this.center;
                for (int i = 0; i < this.n; i++)
                {
                    this.vertices[i] += displacement;
                }
            }
        }

        public string getString()
        {
            string working_str = "[";
            for (int i = 0; i < this.n; i++)
            {
                if (i == 0)
                {
                    working_str += this.vertices[i].getString();
                }
                else
                {
                    working_str += (", " + this.vertices[i].getString());
                }
            }
            working_str += "]";
            return working_str;
        }
    }

    // Inheritance Example
    class Triangle : Polygon
    {
        public Triangle(Point2D[] vertices)
        {
            this.vertices = vertices;
        }

        public double area {
            get {
                double abc = this.vertices[0].x * (this.vertices[1].y - this.vertices[2].y);
                double bca = this.vertices[1].x * (this.vertices[2].y - this.vertices[0].y);
                double cab = this.vertices[2].x * (this.vertices[0].y - this.vertices[1].y);
                return (abc + bca + cab) / 2;
            }
        }
    }

    // In order to prevent people from creating a child class of a given class, the sealed keyword can be used.
    sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("Why would you seal a class?");
            Console.WriteLine("To protect your intellectual property I guess.");
            Console.WriteLine("That, or maybe your class is statically interlaced with something else.");
            Console.WriteLine("It may also make it clear to other developers who use your code that the class isn't meant to be inherited from.");
        }
    }

    class Vehicle
    {
        public int nWheels {get; set;}
        public int nMirrors {get; set;}

        public Vehicle(int nWheels, int nMirrors)
        {
            this.nWheels = nWheels;
            this.nMirrors = nMirrors;
        }
    }

    class Car : Vehicle
    {
        public int nSeats {get; set;}

        // Example of parameters in Base class's constructor
        public Car(int nMirrors, int nSeats) : base(4, nMirrors)
        {
            this.nSeats = nSeats;
        }
    }

    // Nested class example
    class Motorcycle : Vehicle
    {
        public Motor motor;

        public class Motor
        {
            private string brand;

            public Motor(string brand)
            {
                this.brand = brand;
            }

            public string brandname {
                get {
                    return this.brand;
                }
            }
        }

        public Motorcycle(string motorBrand) : base(2, 2)
        {
            this.motor = new Motor(motorBrand);
        }
    }

    class Program
    {
        // If any other methods under your Program class is called in Main,
        // it needs to be static because Main is static.
        static void HelloWorld()
        {
            Console.WriteLine("Hello World! I am static!");
        }

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

            // Static variable example
            Cat cat0 = new Cat();
            Console.WriteLine("Cat.count: " + Cat.count);
            Cat cat1 = new Cat();
            Console.WriteLine("Cat.count: " + Cat.count);

            // Can be used just like classmethods in python.
            // This will be very useful for creating conversion methods
            // between classes.
            Point2D p1 = Point2D.fromArray(new double[] {2.2, 3.4});
            Console.WriteLine("p1.getString(): " + p1.getString());
            Console.WriteLine("p0.index: " + p0.index);
            Console.WriteLine("p1.index: " + p1.index);

            HelloWorld();

            // Static members and non-static members can be managed seperately.
            Console.WriteLine("DrawConfig.enabled: " + DrawConfig.enabled);
            DrawConfig.enabled = false;
            Console.WriteLine("DrawConfig.enabled: " + DrawConfig.enabled);
            DrawConfig dconfig = new DrawConfig("Clayton's drawing config");
            Console.WriteLine("dconfig.name: " + dconfig.name);

            // Static classes can be used for utility like this.
            Console.WriteLine("MethodHelper.AddTwo(MethodHelper.PI) * MethodHelper.Double(MethodHelper.MagicNumber):");
            Console.WriteLine(MethodHelper.AddTwo(MethodHelper.PI) * MethodHelper.Double(MethodHelper.MagicNumber));
        
            // Examples of static Classes
            Console.WriteLine("Math.Sqrt(10): " + Math.Sqrt(10));
            int[] arr = {1, 2, 3, 4};
            Array.Reverse(arr); // {4, 3, 2, 1}
            string s1 = "some text";
            string s2 = ", more text";
            Console.WriteLine("String.Concat(s1, s2): " + String.Concat(s1, s2));
            Console.WriteLine("DateTime.Now: " + DateTime.Now);
            Console.WriteLine("DateTime.Today: " + DateTime.Today);
            // Console and Convert classes are also examples of static classes.

            // Indexer example
            Point2D p2 = new Point2D(3.4, 7.1);
            Console.WriteLine("p2.getString(): " + p2.getString());
            Console.WriteLine("p2[0]: " + p2[0] + ", p2[1]: " + p2[1]);
            p2[0] = 10.1;
            Console.WriteLine("p2.getString(): " + p2.getString());

            Console.WriteLine("p0 + p1: " + (p0 + p1).getString());
            Console.WriteLine("p2 + 4: " + (p2 + 4).getString());
            Console.WriteLine("4 + p2: " + (4 + p2).getString());

            // Inheritance
            Point2D[] ptArr = new Point2D[3] {
                new Point2D(-2.4, 0),
                new Point2D(3, 1),
                new Point2D(4, 5)
            };
            Triangle triangle = new Triangle(ptArr);
            Console.WriteLine("triangle.getString(): " + triangle.getString());
            Console.WriteLine("triangle.area: " + triangle.area);
            Console.WriteLine("triangle.center.getString(): " + triangle.center.getString());
            triangle.center = new Point2D(0, 0);
            Console.WriteLine("triangle.getString(): " + triangle.getString());
            Console.WriteLine("triangle.area: " + triangle.area);
            Console.WriteLine("triangle.center.getString(): " + triangle.center.getString());

            SealedClass sealedClass = new SealedClass();

            // Nested classes can be used both inside and outside of the class itself.
            Motorcycle motorcycle = new Motorcycle("Brand A");
            Motorcycle.Motor motor = new Motorcycle.Motor("Famous Brand");
            Console.WriteLine("motorcycle.motor.brandname: " + motorcycle.motor.brandname);
            Console.WriteLine("motor.brandname: " + motor.brandname);
        }
    }
}
