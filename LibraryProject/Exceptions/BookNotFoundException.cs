using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Exceptions
{
    class BookNotFoundException :Exception
    {
        public BookNotFoundException(string message) : base(message)
        {

        }
    }
}
