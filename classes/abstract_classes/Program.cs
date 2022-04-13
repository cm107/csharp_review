using System;

/*
As described in the previous example, polymorphism is used when you have different
derived classes with the same method, which has different implementations in each
class.
This behavior is achieved through virtual methods that are overridden in the
derived classes.
In some situations there is no meaningful need for the virtual method to have a
separate definition in the base class.
These methods are defined using the abstract keyword and specify that the derived
classes must define that method on their own.
You cannot create objects of a class containing an abstract method, which is why
the class itself should be abstract.

Remember, abstract method declarations are only permitted in abstract classes.
Members marked as abstract, or included in an abstract class, must be implemented
by classes that derive from the abstract class.
An abstract class can have multiple abstract members.

Abstract classes have the following features:
- An abstract class cannot be instantiated.
- An abstract class may contain abstract methods and accessors.
- A non-abstract class derived from an abstract class must include actual
implementations of all inherited abstract methods and accessors.

Note: It is not possible to modify an abstract class with the sealed modifier
because the two modifiers have opposite meanings. The sealed modifier prevents a
class from being inherited and the abstract modifier requires a class to be
inherited.

An interface is a completely abstract class, which contains only abstract members.
It is declared using the interface keyword.
All members of the interface are by default abstract, so no need to use the
abstract keyword.
Also, all members of an interface are always public, and no access modifiers can
be applied to them.
It is common to use the capital letter "I" as the starting letter for an
interface name.
Interfaces can contain properties, methods, etc. but cannot contain
fields (variables) because that wouldn't make sense.
Note that the override keyword is not needed when you implement an interface.
But why use interfaces rather than abstract classes?
A class can inherit from just one base class, but it can implement multiple
interfaces!
Therefore, by using interfaces you can include behavior from multiple sources in
a class.
To implement multiple interfaces, use a comma separated list of interfaces when
creating the class.
*/

namespace abstract_classes
{
    abstract class Shape
    {
        public Shape() {}

        // Must be overridden
        public abstract void Draw();
    }

    class Rectangle : Shape
    {
        public Rectangle() {}

        override public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    class Triangle : Shape
    {
        public Triangle() {}

        public override void Draw()
        {
            Console.WriteLine("Triangle Draw");
        }
    }

    public interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);
    }

    public interface IReportableObject
    {
        void Report();
    }

    class CheckingAccount : IAccount, IReportableObject
    {
        private double balance = 0.0;

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Withdrew " + amount);
            }
            else
            {
                Console.WriteLine("Not enough money.");
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited " + amount);
        }

        public void Report()
        {
            Console.WriteLine("Balance: " + this.balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape r = new Rectangle();
            Shape t = new Triangle();

            r.Draw();
            t.Draw();

            Console.WriteLine("Array Example:");
            Shape[] shapes = {r, t};
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            // Interface test
            CheckingAccount account = new CheckingAccount();
            account.Deposit(100);
            account.Withdraw(50);
            account.Report();
        }
    }
}
