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
     
        public T Pop()
        {
            if (countElInList>0)
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
            if (countElInList > 0)
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
