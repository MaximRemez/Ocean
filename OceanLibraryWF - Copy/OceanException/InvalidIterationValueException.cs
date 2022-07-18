using System;

namespace OceanLibrary.OceanException
{
    public class InvalidIterationValueException : Exception
    {
        static readonly string excMessage = "The number of iteration is greater than 1000!";

        public InvalidIterationValueException() : base(excMessage)
        {
        }

        public InvalidIterationValueException(string message) : base(excMessage)
        {
        }

        public InvalidIterationValueException(string message, Exception inner) : base(excMessage, inner)
        {
        }
    }

}
