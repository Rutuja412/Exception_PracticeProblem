using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handlind
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base( message)
        {

        }

    }
}
