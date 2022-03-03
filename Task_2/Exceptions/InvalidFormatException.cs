using System;

namespace Task_2.Exceptions
{
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string message) : base(message)
        {

        }
    }
}