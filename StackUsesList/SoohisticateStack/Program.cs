using System;

namespace SophisticateStack
{
    class Program
    {
        static void Main(string[] args)
        { Stack<int> exampl = new Stack<int>();
           
            exampl.Push(30);
            exampl.Push(400);
            exampl.Push(50);
            while (exampl.countElInStack!=0)
            {
                Console.WriteLine(exampl.Pop());

            }
            Console.WriteLine(exampl.Pop());

            Console.WriteLine("Hello World!");
        }
    }
}
