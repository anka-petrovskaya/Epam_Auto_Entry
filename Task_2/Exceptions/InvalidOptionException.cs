using System;

namespace Task_2.Exceptions
{
    public class InvalidOptionException : Exception
    {
        public InvalidOptionException(string message) : base (message)
        {

        }
    }
}