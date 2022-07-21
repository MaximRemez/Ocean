using System;

namespace OceanLibrary.OceanException
{
    class InvalidNumberElementException : Exception
    {
        static readonly string excMessage = "The number of elements is out of bounds!";

        public InvalidNumberElementException() : base(excMessage)
        {
        }

        public InvalidNumberElementException(string message) : base(excMessage)
        {
        }

        public InvalidNumberElementException(string message, Exception inner) : base(excMessage, inner)
        {
        }
    }
    
}
