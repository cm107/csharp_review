using System;

/*
Conversion is done using Convert.ToXXX methods.
The default int type in C# is 32-bit.
If a non-integer string is given to Convert.ToInt32,
an error will be thrown.

A variable can be explicitly declared with its type before it is
used.
Alternatively, C# provides a handy function to enable the
compiler to determine the type of the variable automatically
based on the expression it is assigned to.
The var keyword is used for those scenarios

Variables declared using the var keyword are called implicitly
typed variables.
Implicitly typed variables must be initialized with a value
right away.
e.g.
var print_str = "Hello World";

Although it is easy and convenient to declare variables using
the var keyword, overuse can harm the readability of your code.
Best practice is to explicitly declare variables.

Constants store a value that cannot be changed from their
initial assignment.
To declare a constant, use the const modifier.
Constants must be initialized with a value when declared.

Comments: Exactly the same as C++.

Operators: Work exactly as they do in C++.

if statements: Exactly the same as C++.

switch statements: Exactly the same as C++.

while statements: Exactly the same as C++.

for loops: Exactly the same as C++.

do-while loops: Exactly the same as C++.
*/

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", yourName);
            Console.WriteLine("How old are you?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ah, okay. So you are {0} years old.", yourAge);
            Console.WriteLine("Are you single?");
            bool isSingle = Convert.ToBoolean(Console.ReadLine());
            if (isSingle) {
                Console.WriteLine("You are single!");
            } else {
                Console.WriteLine("Oh, okay. You aren't single.");
            }

            // var is used to let the compile decide type.
            var val0 = 12;
            var val1 = "test";
            Console.WriteLine("val0: {0}, val1: {1}", val0, val1);
            const int CONSTANT_VAL = 32;
            Console.WriteLine("Constant values cannot be changed.");
            Console.WriteLine("CONSTANT_VAL: {0}", CONSTANT_VAL);
        }
    }
}
