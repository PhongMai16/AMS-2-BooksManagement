using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BooksManagementSimple1.Options
{
    public class Crud
    {
        public static List<Books.Books> BooksList = new List<Books.Books>();
        
        // This function will show all information of employee (IDBooks, Name of Books , CreateDate, Kind Of Books

        public void Display()
        {
            Console.WriteLine("List of Books");
            foreach (var book in BooksList)
            {
                Console.WriteLine($"Id of this book is: {book.IdBooks}");
                Console.WriteLine($"Name of this book is: {book.NameBooks}");
                Console.WriteLine($"CreateDate of this book is: {book.CreateDate.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine($"The kind of this book is: {book.Kind}");
            }
        }
        
        // This function will find the information of book By ID of book 
        public void FindIdBook(int id)
        {
            var books = from f in BooksList where f.IdBooks == id select f;
            Console.WriteLine("List of Books");
            foreach (var book in BooksList)
            {
                Console.WriteLine($"Id of this book is: {book.IdBooks}");
                Console.WriteLine($"Name of this book is: {book.NameBooks}");
                Console.WriteLine($"CreateDate of this book is: {book.CreateDate.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine($"The kind of this book is: {book.Kind}");
            }
            
        }
        //This function will find the information of book By Name 

        public void FindNameBook(string name)
        {
            var books = from f in BooksList 
                where f.NameBooks.ToLower().Trim() == name.ToLower().Trim() select f;
            Console.WriteLine("List of Books");
            foreach (var book in BooksList)
            {
                Console.WriteLine($"Id of this book is: {book.IdBooks}");
                Console.WriteLine($"Name of this book is: {book.NameBooks}");
                Console.WriteLine($"CreateDate of this book is: {book.CreateDate.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine($"The kind of this book is: {book.Kind}");
            }
        }
        //This function will find the information of book By Kind of Book
        
        public void FindKindBook(string kindOfBook)
        {
            var books = from f in BooksList 
                where f.Kind.ToLower().Trim() == kindOfBook select f;
            Console.WriteLine("List of Books");
            foreach (var book in BooksList)
            {
                Console.WriteLine($"Id of this book is: {book.IdBooks}");
                Console.WriteLine($"Name of this book is: {book.NameBooks}");
                Console.WriteLine($"CreateDate of this book is: {book.CreateDate.ToString()}");
                Console.WriteLine($"The kind of this book is: {book.Kind}");
            }
        }

        public void AddBook(int input)
        {
            int idBook;
            string nameBook;
            DateTime createDate;
            string kind;


            switch (input)
            {
                //This function will get your values from you entering
                case 1: 
                    Console.WriteLine("Please enter ID of book: ");
                    idBook = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Name of book: ");
                    nameBook = Console.ReadLine();
                    Console.WriteLine("Please enter time (month/day/year): ");
                    createDate = Convert.ToDateTime(Console.ReadLine());
                    kind = "English";
                    
                    //calling class English and passing Parameters
                    Books.Books english = new Books.Books(idBook, nameBook, createDate, kind);

                    //Adding it to List of English Book
                    BooksList.Add(english);
                    break;
                
                
                case 2:
                    Console.WriteLine("Please enter ID of books: ");
                    idBook = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Name of Book: ");
                    nameBook = Console.ReadLine();
                    Console.WriteLine("Please enter time (month/day/year): ");
                    createDate = Convert.ToDateTime(Console.ReadLine());
                    kind = "Physical";
                    
                    //Calling class Programming and passing Parameters
                    Books.Books physical = new Books.Books(idBook, nameBook, createDate, kind);
                    
                    //Adding it to List of Physical Book
                    BooksList.Add(physical);
                    break;
                     
                case 3:
                    Console.WriteLine("Please enter ID of books: ");
                    idBook = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Name of Book: ");
                    nameBook = Console.ReadLine();
                    Console.WriteLine("Please enter time (month/day/year): ");
                    createDate = Convert.ToDateTime(Console.ReadLine());
                    kind = "Programming";
                    
                    //Calling class Programming and Passing Parameters
                    Books.Books programming = new Books.Books(idBook, nameBook, createDate, kind);
                    
                    //Adding id to list of Programming book
                    BooksList.Add(programming);
                    break;
                
                    //entering again when user input invalid values.
                    default:
                        Console.WriteLine("Please enter again! Invalid number!");
                        break;
            }

        }

        //This function will update books
        public void Update(int idBook)
        {
            Console.WriteLine("Please enter the name of book that you want to edit: ");
            BooksList.FirstOrDefault(id => id.IdBooks == idBook).NameBooks = Console.ReadLine();
            
            Console.WriteLine("Please enter day that you want to edit: ");
            BooksList.FirstOrDefault(id => id.IdBooks == idBook).CreateDate = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Please enter the kind of book");
            BooksList.FirstOrDefault(id => id.IdBooks == idBook).Kind = Console.ReadLine();
            
        }

        public void DeleteBook(int idBook) // DeleteBook Function
        {
            var book = BooksList.Where(id => id.IdBooks == idBook).First();
            BooksList.Remove(book);
        }
        
    }
}