using LibraryProject.Enums;
using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string value);
        List<Book> Filter(string author, Genre genre);

    }
}
