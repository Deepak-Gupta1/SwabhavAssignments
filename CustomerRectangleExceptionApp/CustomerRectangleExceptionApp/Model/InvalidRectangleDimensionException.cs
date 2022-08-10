using System;
using System.Runtime.Serialization;

namespace CustomerRectangleExceptionApp.Model
{
    internal class InvalidRectangleDimensionException : Exception
    {
        public InvalidRectangleDimensionException()
        {
        }

        public InvalidRectangleDimensionException(string message) : base(message)
        {
        }
    }
    internal class InvalidRectangleColorException : Exception
    {

        public InvalidRectangleColorException(string message) : base(message)
        {
        }
    }
}