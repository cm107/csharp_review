using System;

/*
The word polymorphism means "having many forms".
Typically, polymorphism occurs when there is a hierarchy of classes and they are
related through inheritance from a common base class.
Polymorphism means that a call to a member method will cause a different
implementation to be executed depending on the type of object that invokes
the method.
Simply, polymorphism means that a single method can have a number of different
implementations.

The virtual keyword allows methods to be overridden in derived classes.
Virtual methods enable you to work with groups of related objects in a uniform way.

Virtual methods defined in the base class can be overridden in the derived class
using the override keyword.

To summarize, polymorphism is a way to call the same method for different objects
and generate different results based on the object type.
This behavior is achieved through virtual methods in the base class.
To implement this, we create objects of the base type, but instantiate them as the
derived type.

The polymorphic approach allows us to treat each object the same way.
As all objects are of type Shape, it is easier to maintain and work with them.
You could, for example, have a list (or array) of objects of that type and work
with them dynamically, without knowing the actual derived type of each object.

Polymorphism can be useful in many cases.
For example, we could create a game where we would have different Player types
with each Player having a separate behavior for the Attack method.
In this case, Attack would be a virtual method of the base class Player and each
derived class would override it.
*/

namespace polymorphism
{
    class Shape
    {
        public Shape() {}

        public virtual void Draw()
        {
            Console.WriteLine("Base Draw");
        }
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

    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Shape r = new Rectangle();
            Shape t = new Triangle();

            s.Draw();
            r.Draw();
            t.Draw();

            Console.WriteLine("Array Example:");
            Shape[] shapes = {s, r, t};
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
