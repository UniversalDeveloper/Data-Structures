using StackUsesList.Model;
using System;

namespace StackUsesList
{
    class Program
    {
        static void Main(string[] args)
        {
            var stakList = new StackUsesList<int>();
            stakList.Push(1 );
            stakList.Push(2);
            stakList.Push(3);
            
            for (int i = 0; i <3; i++)
            {
                var item = stakList.Peek();
                Console.WriteLine(item);
                stakList.Pop();
            }
           
        }
    }
}
