using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo1_StackExample.Stack
{
    class Stack<T>
    {
        public StackItem<T> currentElement;

     
        public void Push(T item)
        {
            if (currentElement == null)
                currentElement = new StackItem<T>() { StackValues = item, Pointer = null };
            else
            {
                StackItem<T> temp = new StackItem<T>() { StackValues = item, Pointer = currentElement };
                currentElement = temp;
            }

        }

        public T Pop()
        {
            if (currentElement != null)
            {
                T temp = currentElement.StackValues;
                currentElement = currentElement.Pointer;
                return temp;
            }
            else
                throw new NullReferenceException();
        }

        public T Peek()
        {
            if (currentElement != null)
                return currentElement.StackValues;
            else
                return default(T);
        }

    }
}