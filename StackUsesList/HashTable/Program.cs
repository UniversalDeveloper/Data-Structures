using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHashTable<StringEnter> it = new SuperHashTable<StringEnter>(10);
            var str = new StringEnter() { EnterStr = "one" };
            it.Add(new StringEnter() { EnterStr = "cat" });
            it.Add(new StringEnter() { EnterStr = "dog" });
            it.Add(new StringEnter() { EnterStr = "dog" });
            it.Add(str);
            Console.WriteLine(it.Serch(str));
        }
    }
}
