using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        // private fields
        private string _title;
        private string _author;
        private string _isbn;

        // Constructor
        public Book(string title, string author, string isbn)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
        }

        // Public Properties
        public string Title
        {
            get { return _title; }
            set
            {
                if (!value.Any(char.IsDigit) && value != "")
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title name cannot be blank or contain numbers.");
                }
               
            }

        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (!value.Any(char.IsDigit) && value != "")
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot be blank or contain numbers.");
                }
            }
        }


        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (!value.Any(char.IsDigit) && value != "")
                {
                    _isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISMB cannot be blank or contain numbers.");
                }
            }
        }

        // Constructor
        public Book (string booktitle, string bookauthor, string bookisbn)
        {
            this.Title = booktitle;
            this.Author = bookauthor;
            this.ISBN = bookisbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
