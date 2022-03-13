using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Exceptions
{
    class SameBookalreadyAddedExpection :Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
    }
}
