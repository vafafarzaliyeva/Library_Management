using LibraryProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Models
{
    class Book
    {
       
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string author, Genre genre,int pagecount)
        {
            Name = name;
            Author = author;
            Genre = genre;
            PageCount = pagecount;
        }


        public override string ToString()
        {
            return $"Name:{Name}\nAuthor:{Author}\nGenre:{Genre}\nPageCount:{PageCount}";
        }
    }
}
