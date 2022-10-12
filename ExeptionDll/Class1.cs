using System;

namespace ExeptionDll
{
    public class NotFoundExeption:Exception
    {
        public NotFoundExeption(string message):base(message)
        {

        }
    }
    public class UpperException : Exception
    {
        public UpperException(string message) : base(message)
        {

        }
    }
}
