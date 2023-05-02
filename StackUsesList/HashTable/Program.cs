using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHashTable<int> it = new SuperHashTable<int>(5);

            it.Add(9);
            it.Add(9);

            Console.WriteLine(it.Serch(9).ToString());
        }
    }
}
