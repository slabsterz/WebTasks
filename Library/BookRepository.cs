using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookRepository
    {
        public List<Book> DefaultList { get; } = new List<Book>();

        public BookRepository()
        {            
            DefaultList = new List<Book>()
        {
            new Book("The Catcher in the Rye", "J.D. Salinger", 300, "Available"),
            new Book("To Kill a Mockingbird", "Harper Lee", 250, "Available"),
            new Book("1984", "George Orwell", 400, "Available")
        };
            
        }

        public void PrintList(List<Book> list)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Book book in list)
            {
                stringBuilder.AppendLine($"Title: {book.Title}, Author: {book.Author}, Pages: {book.Pages}, Availability: {book.AvailabilityStatus}");
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }

   

}

