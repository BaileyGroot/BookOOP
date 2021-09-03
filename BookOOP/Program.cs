using System;
using System.Collections.Generic;
using static System.Console;

namespace BookOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("GrootLib");

            WriteLine("Choose book from the list: ");

            WriteLine("");

            // Get our Book List Class.
            BookList bookList = new BookList();
            Book book = new Book();
            StackList listStack = new StackList();

            // Call our method that contains our books.
            bookList.listBook();

            // Print out the books in our method.
            foreach (var i in bookList.books)
            {
                WriteLine(i.bookName);
            }

            WriteLine("");
            Write("Choose book number: ");
            string name = ReadLine();
            bookList.chooseBook(name);
            listStack.stack.(name);
            bookList.deleteBook(name);

            foreach (var i in bookList.books)
            {
                WriteLine(i.bookName);
            }

            WriteLine("");
            WriteLine("The book you choosed.");
            WriteLine("");

            foreach (var item in collection)
            {

            }
        }
    }
}