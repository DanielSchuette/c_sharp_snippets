using System;
namespace example02
{
    /* a book data type */
    public class MyFirstClass
    {
        /* attributes */
        public string Title;
        public string Author;
        public int Pages;

        /* the constructor (multiple are possible) */
        public MyFirstClass(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public MyFirstClass()
        {
        }

        /* don't define as static! */
        public void PrintMe()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPages: {2}",
                              Title, Author, Pages);
        }
    }
}