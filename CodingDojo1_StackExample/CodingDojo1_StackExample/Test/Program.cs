using System;
using System.Linq;
using System.Text;
using CodingDojo1_StackExample.Stack;

namespace CodingDojo1_StackExample.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            TestObject();
            //TestString();
            //TestInt();
            Console.ReadLine();
        }


        static void TestInt()
        {
            Stack<int> test = new Stack<int>();

            test.Push(57);
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(82);
            test.Push(99);
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
        }

        static void TestString()
        {
            Stack<string> test = new Stack<string>();

            test.Push("Semih");
            test.Push("Johann");
            Console.WriteLine("read: {0}", test.Peek());
            test.Push("Dieter");
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());

        }

        static void TestObject()
        {
            Stack<Test> test = new Stack<Test>();

            test.Push(new Test(27, "Samuel"));
            test.Push(new Test(80, "Muhammed Ibn Musa al-Chawarizmi"));
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(new Test(15, "Harun"));
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("{0} removed", test.Pop());

        }
    }
}