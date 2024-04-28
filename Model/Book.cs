using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_automation.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string BookLang { get; set; }
        public string PublishHouse { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public int NumberOfPages { get; set; }
        public int YearOfIssue { get; set; }

        public Book() {
            
        }
        public Book(int bookId, string bookName, string Author , string bookLang, string publishHouse, string type, int amount, int numberOfPages, int yearOfIssue)
        {
            this.BookId = bookId;
            this.BookName = bookName;
            this.Author = Author;
            this.BookLang = bookLang;
            this.PublishHouse = publishHouse;
            this.Type = type;
            this.Amount = amount;
            this.NumberOfPages = numberOfPages;
            this.YearOfIssue = yearOfIssue;
        }
        public int getBookId()
        {
            return this.BookId;
        }
        public string getBookName()
        {
            return this.BookName;
        }
        public string getBookLang()
        {
            return this.BookLang;
        }
        public string getPublishHouse()
        {
            return this.PublishHouse;
        }
        public string getType()
        {
            return this.Type;
        }
        public int getAmount()
        {
            return this.Amount;
        }
        public int getNumberOfPages()
        {
            return this.NumberOfPages;
        }
        public int getYearOfIssue()
        {
            return this.YearOfIssue;
        }
    }
}
