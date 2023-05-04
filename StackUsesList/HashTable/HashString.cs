using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashString
    {
        private Item<String>[] items;
     
        public HashString(int size) 
        {
            items = new Item<String>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<String>(i);
            }
        }
        public void Add(String item)
        {
            var key = GetHashCodeStr(item);
            items[key].Node.Add(item);
        }
        public bool Serch(String item)
        {
            var key = GetHashCodeStr(item);
            bool v1 = items[key].Node.Contains(item);
            return v1;
        }

        public void ShowData(String item)
        {
            var key = GetHashCodeStr(item);
            foreach (var itm in items[key].Node)
            {
                Console.WriteLine(itm);
            }
        }

        
        public  int GetHashCodeStr(string EnterStr)
        {
            int g = 31;
            int hash = 0;
            int res = 0;
            for (int i = 0; i < EnterStr.Length; i++)
            {
                hash = g * hash + Char.ConvertToUtf32(EnterStr, i);
            }
            res= hash % items.Length;
            return res;
        }
    }
}
