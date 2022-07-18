using System;
namespace OceanLibrary.OceanException
{
    public class InvalidValueElementsException : Exception
    {
        static readonly string excMessage = "The number of elements is greater than the ocean field!";

        public InvalidValueElementsException() : base(excMessage)
        {
        }

        public InvalidValueElementsException(string message) : base(excMessage)
        {
        }

        public InvalidValueElementsException(string message, Exception inner) : base(excMessage, inner)
        {
        }
    }
}
