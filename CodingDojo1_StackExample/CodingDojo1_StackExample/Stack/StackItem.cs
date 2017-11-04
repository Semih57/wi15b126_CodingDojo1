using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo1_StackExample.Stack
{
    class StackItem<T>
    {
        public T StackValues { get; set; }
        public StackItem<T> Pointer { get; set; }
    }
}