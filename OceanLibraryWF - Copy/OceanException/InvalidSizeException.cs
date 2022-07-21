using System;

namespace OceanLibrary.OceanException
{
    public class InvalidSizeException : Exception
    {
        static readonly string excMessage = "The size of field is out of bounds!";

        public InvalidSizeException() : base(excMessage)
        {
        }

        public InvalidSizeException(string message) : base(excMessage)
        {
        }

        public InvalidSizeException(string message, Exception inner) : base(excMessage, inner)
        {
        }
    }
}
