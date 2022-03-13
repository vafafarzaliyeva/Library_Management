using LibraryProject.Enums;
using LibraryProject.Exceptions;
using LibraryProject.Interfaces;
using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Services
{
    class Service : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public Service()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Exists(b => b.Name == book.Name))
            {
                throw new SameBookalreadyAddedExpection("kitab artiq movcuddur");
               
            }
            _books.Add(book);
        }

        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(d => d.Author == author && d.Genre == genre);
        }

        public List<Book> Search(string value)
        {
            return _books.FindAll(d => d.Name.Contains(value));
        }

        public Book ShowInfo(string name)
        {
            if (_books.Find(n => n.Name == name) != null)
            {
                return _books.Find(n => n.Name == name);
            }
            throw new BookNotFoundException("Daxil edilen adda kitab yoxdur");
        }
    }
}
