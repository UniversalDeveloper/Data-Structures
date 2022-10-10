using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackUsesList.Model
{
    class StackUsesList<T>
    {
        private List<T> dataStore = new List<T>();
        private int countElInList => dataStore.Count;
        private bool isEmpty => dataStore.Count == 0;


        public T Pop()
        {
            if (!isEmpty)
            {
                var returnElFromList= dataStore.LastOrDefault();
                dataStore.Remove(returnElFromList);
                return returnElFromList;
            }
            else
            {
                throw  new NullReferenceException("Stack is empty");
            }

            
        }


        public void Push(T dataItem) 
        {
            dataStore.Add(dataItem);
        }

        public T Peek()
        {
            if (!isEmpty)
            {
                return dataStore.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        public override string ToString()
        {
            return $"Stack with {countElInList} elements";
        }
    }
}
