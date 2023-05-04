using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableUsingCClass
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> storeString = new HashSet<string>();

            string str1 = "one";
            string str2 = "two";
            string str3 = "one";
            var key = str1.GetHashCode();

            var key1 = str2.GetHashCode();
            var key2 = str3.GetHashCode();

            storeString.Add(str1);
            storeString.Add( str2);
            storeString.Add( str3);
            Console.WriteLine("Hello World!");
        }
    }
}
