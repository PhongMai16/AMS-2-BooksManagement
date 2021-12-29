using System;

namespace BooksManagementSimple1.Books
{
    public class Books
    {

        public string NameBooks { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public string Kind { get; set; }
        public int IdBooks { get; set; }


        //Constructor 
        public Books(int idBook, string nameBooks, DateTime createDate, string kindOfBook)
        {
            this.IdBooks = idBook;
            this.NameBooks = nameBooks;
            this.CreateDate = createDate;
            this.Kind = kindOfBook;
            
        }
    }
}