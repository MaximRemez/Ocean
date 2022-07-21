using System;

namespace OceanLibrary.OceanException
{
    public class InvalidSumElementsException : Exception
    {
        static readonly string excMessage = "The number of elements is greater than the ocean field!";

        public InvalidSumElementsException() : base(excMessage)
        {
        }

        public InvalidSumElementsException(string message) : base(excMessage)
        {
        }

        public InvalidSumElementsException(string message, Exception inner) : base(excMessage, inner)
        {
        }
    }
}
