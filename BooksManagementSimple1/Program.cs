using System;
using BooksManagementSimple1.Options;

namespace BooksManagementSimple1
{
    class Program
    {
        private static char reply;
        
        static void Main(string[] args)
        {

            Crud cRud = new Crud();

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t|---------------------------EMPLOYEE MANAGE SYSTEM MENU--------------------------|");
                Console.WriteLine("\t\t| 1. Adding new book           <==                                               |");
                Console.WriteLine("\t\t| 2. View all of books         <==                                               |");
                Console.WriteLine("\t\t| 3. Searching books           <==                                               |");
                Console.WriteLine("\t\t| 4. Update book detail        <==                                               |");
                Console.WriteLine("\t\t| 5. Remove book you want      <==                                               |");
                Console.WriteLine("\t\t| 6. Exit                      <==                                               |");
                Console.WriteLine("\t\t|--------------------------------------------------------------------------------|");

                string yourOption = (Console.ReadLine());
                int findingID;

                // Switch case
                switch (yourOption)
                {
                    //Adding new book to the List (BooksList)
                    case "1":
                        Console.WriteLine("Wanna add English book, Plz press 1");
                        Console.WriteLine("Wanna add Physical book, Plz press 2");
                        Console.WriteLine("Wannna add Programming book, Plz press 3");
                        int input = Convert.ToInt32(Console.ReadLine());
                        cRud.AddBook(input);
                        break;
                    //Display all book 
                    
                    case "2":
                        cRud.Display();
                        break;
                    
                    case "3":
                        // Searching book that you user want
                        Console.WriteLine("Enter type of searching");
                        Console.WriteLine("Enter 1 to search ID of book");
                        Console.WriteLine("Enter 2 to search Name of Book");
                        Console.WriteLine("Enter 3 to search Kind of Book");
                        int typeSearch = Convert.ToInt32(Console.ReadLine());
                        switch (typeSearch)
                        {
                            case 1:
                                Console.WriteLine("Enter ID of the book(Searching)");
                                int idbook = Convert.ToInt32(Console.ReadLine());
                                cRud.FindIdBook(idbook);    
                                break;
                            // search by name
                            case 2:
                                Console.WriteLine("Enter Name of the book(Searching)");
                                var nameBook = Console.ReadLine();
                                cRud.FindNameBook(nameBook);
                                break;
                            case 3:
                                Console.WriteLine("Enter Kind of the book(Searching)");
                                var kindBook = Console.ReadLine();
                                cRud.FindKindBook(kindBook);
                                break;
                            // Asking user to enter again
                            default:
                                Console.WriteLine("Please enter again, [invalid values!]");
                                break;

                        }
                        break;

                    case "4":
                        // Update the book
                        Console.WriteLine("Please enter ID of the book which you want to update: ");
                        findingID = int.Parse(Console.ReadLine());
                        // Validate the values when user enter 
                        if (findingID != null)
                        {
                            cRud.Update(findingID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID");
                        }

                        break;
                    

                    case "5":
                        // Clear all in the console makes it easier to read in console
                        Console.WriteLine("Enter the ID of book you want to delete:");
                        findingID = Convert.ToInt32(Console.ReadLine());
                        //Validating the values that user enter 
                        if (findingID != null)
                        {
                            cRud.DeleteBook(findingID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID");
                        }

                        break;
                    
                        
                    case "6":
                        Console.WriteLine("Thank you for using the app!");
                        break;

                    default:
                        // Asking user to enter again when input invalid values
                        Console.WriteLine("Invalid values, please enter again!");
                        break;

                }

                // Asking user want to continue or shutdown the app
                Console.WriteLine("Would you want to continue (Yes/No)");
                reply = char.Parse(Console.ReadLine());

            } while (reply is 'Y' or 'y');
            
        }
    }
}