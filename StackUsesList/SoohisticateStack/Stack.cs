using System;
using System.Collections.Generic;
using System.Text;

namespace SophisticateStack
{
    class Stack<T>
    { private Item<T> head { get; set; }
      public int countElInStack { get; set; }
        public Stack() 
        { 
            head = null;
            countElInStack = 0;
        }
      /*  public Stack(T data) 
        {
            var item = new Item<T>(data);
            head = item;
            countElInStack++;
        }*/
        public void Push(T data) 
        {
            var item = new Item<T>(data);
            item.PreviousItem = head;
            head = item;
            countElInStack++;
        }
        public T Pop()
        {
            if (head != null)
            {
                var item = head;
                head = item.PreviousItem;
                countElInStack--;
                return item.data;
            }
            else 
            {
                throw new NullReferenceException("Stack is empty!");
            }
            
            
        }
    }
   
}
