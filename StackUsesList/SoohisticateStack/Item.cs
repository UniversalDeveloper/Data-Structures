using System;
using System.Collections.Generic;
using System.Text;

namespace SophisticateStack
{
    class Item<T>
    {
        public T data { get; set; }
        public Item<T> PreviousItem { get; set; }
        public Item(T data)
        {
            this.data = data;
        }
        public string ToString()
        {
            return data.ToString();
        }
    }
}
