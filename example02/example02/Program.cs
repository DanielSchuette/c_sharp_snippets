using System;

namespace example02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* one way to instantiate an object */
            MyFirstClass book1 = new MyFirstClass("my book", "me", 42);

            Console.WriteLine(book1.Title);
            /* 
             * A "non-static" method that must be called on 
             * a specific instance of the class. Static methods
             * can be called without instantiating an object.
             */
            book1.PrintMe();
        }
    }
}