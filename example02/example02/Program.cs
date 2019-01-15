using System;

namespace example02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* one way to instantiate an object */
            MyFirstClass book1 = new MyFirstClass();
            book1.title = "my book";
            book1.author = "me";
            book1.pages = 42; /* what else? */

            /* another way to instantiate an object */
            MyFirstClass book2 = new MyFirstClass
            {
                title = "my second book",
                author = "me (of course)",
                pages = 43,
            };
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
        }
    }
}