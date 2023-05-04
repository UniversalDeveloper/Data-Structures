using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class SuperHashTable<T>
    { 
        private Item<T>[] items;

public SuperHashTable(int sizeArr)
        {
            items = new Item<T>[sizeArr];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }
        public void Add(T item) 
        {
            var key = GetHash(item);
            items[key].Node.Add(item);        
        }

        public bool Serch(T item) 
        {
            var key = GetHash(item);
             bool v1= items[key].Node.Contains(item);
            return v1;
            

        }
        public int GetHash (T item)
        {
          return item.GetHashCode() % items.Length;
        }


    }
}
