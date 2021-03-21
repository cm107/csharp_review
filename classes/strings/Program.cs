using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello World!";
            Console.WriteLine("msg: " + msg);
            Console.WriteLine("msg.Length: " + msg.Length);
            Console.WriteLine("msg.IndexOf('W'): " + msg.IndexOf('W'));
            msg = msg.Remove(msg.IndexOf('!'), 1);
            Console.WriteLine("msg: " + msg);
            msg = msg.Replace("World", "Clayton");
            Console.WriteLine("msg: " + msg);
            msg = msg.Insert(msg.IndexOf(' '), ",");
            Console.WriteLine("msg: " + msg);
            Console.WriteLine("msg.Substring(7, 7): " + msg.Substring(7, 7));
            string name = "Clayton";
            Console.WriteLine("msg.Contains(name): " + msg.Contains(name));
        }
    }
}
