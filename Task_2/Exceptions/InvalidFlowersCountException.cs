using System;


namespace Task_2.Exceptions
{
    public class InvalidFlowersCountException : Exception
    {
        public InvalidFlowersCountException(string message) : base(message)
        {
        }
    }
}