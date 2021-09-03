using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BookOOP
{
    class BookList
    {
        public List<Book> books = new List<Book>();
        public void listBook() // Book list
        {
            books.Add(new Book() { bookId = 1, bookName = "Magic beats 1", bookGenre = "Fantasy" });
            books.Add(new Book() { bookId = 2, bookName = "Magic beats 2", bookGenre = "Fantasy" });
            books.Add(new Book() { bookId = 3, bookName = "Magic beats 3", bookGenre = "Fantasy" });
            books.Add(new Book() { bookId = 4, bookName = "Magic beats 4", bookGenre = "Fantasy" });
        }

        public void deleteBook(string name) // Deleting book
        {
            books.RemoveAll(Book => Book.bookName == name);
        }
        public void chooseBook(string name) // Choosing book
        {
            books.Find(Book => Book.bookName == name);
        }

    }
}
