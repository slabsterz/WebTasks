using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryOperations
    {
        public void CheckOutBook(Book book, LibraryMember member)
        {
            member.BorrowBook(book);
            book.AvailabilityStatus = "Not present in the system.";
        }

        public void ReturnBook(Book book, LibraryMember member)
        {
            member.ReturnBook(book);
            book.AvailabilityStatus = "Book is available.";
        }

        public void ShowLibraryMembers()
        {
            LibraryMember member = new LibraryMember();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (LibraryMember members in member.LibraryMembers)
            {
                stringBuilder.AppendLine($"Name: {members.FirstName}, {members.LastName},ID: {members.MemberID},Books borrowed: {members.BooksBorrowed}");
            }
            //stringBuilder.AppendLine(member.LibraryMembers).ToString();
            Console.WriteLine(stringBuilder.ToString());
        }

        public void ShowAllBooks()
        {
            Book book = new Book();
        }

        public static void RegisterAMember()
        {
            LibraryMember member = new LibraryMember();

            Console.Clear();
            Console.WriteLine("What is your first name ?");
            string createUserFirstName = Console.ReadLine();
            member.FirstName = createUserFirstName;

            Console.WriteLine("What is your last name ?");
            string createUserLastName = Console.ReadLine();
            member.LastName = createUserLastName;
            member.LibraryMembers.Add(member);

            member.DisplayMemberInfo();
        }
    }
}
