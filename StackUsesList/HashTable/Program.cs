using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           HashString it = new HashString(1000);
            var str0 = "one" ;
            var str1 =  "cat" ;
            var str2 = "dog" ;
            var str3 = "cat";
            
            it.Add(str0);
            it.Add(str1);
            it.Add(str2);
            it.Add(str3);



         it.ShowData("dww3");

            Console.WriteLine(it.Serch(str0));
        }
    }
}
