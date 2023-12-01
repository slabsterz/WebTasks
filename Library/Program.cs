using System;

namespace Library
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to donate a book?");
            string input = Console.ReadLine().ToLower();

            while (input != "quit")  
            {      
            while (true)
            {
                   if (input.StartsWith("y") || input.Contains("don"))
                   {
                       Donation.DonatingBooks();
                       HelpCommands.CommandsAfterDonation();
                   }
                   input = Console.ReadLine();

                   if (!input.Contains("don"))
                   {
                       break;
                   }
            }
                

                // HelpCommands.CommandsForDifferentUsers();
               

                //input = Console.ReadLine().ToLower();

                if (input.StartsWith("n") || input.Contains("no") || input.Contains("reg") || input.Contains("brow"))
                {
                     if (input.Contains("no"))
                     {
                        HelpCommands.CommandsForDifferentUsers();
                     }                                      

                    string reaction = input;

                     if (reaction.Contains("reg"))
                     {
                        LibraryOperations.RegisterAMember();
                        //TODO: add a dictionary KVP<string, string> (username, pass) to validate 
                     }
                     else if (reaction.Contains("brow") || reaction.Contains("cata"))
                     {
                        BookRepository bookRepository = new BookRepository();
                        bookRepository.PrintList(bookRepository.DefaultList);

                        HelpCommands.CommandsForSorting();

                        string sortingWay = Console.ReadLine();

                        switch (sortingWay)
                        {
                            case "title": SortingBooks.SortBooksByTitle();
                                break;
                            case "author": SortingBooks.SortBooksByAuthor();
                                break;
                            case "pages": SortingBooks.SortBooksByPages();
                                break;
                            case "status": SortingBooks.SortBooksByStatus();
                                break;
                        }
                     }
                }

                input = Console.ReadLine();
            }
            
        }
    }
}
