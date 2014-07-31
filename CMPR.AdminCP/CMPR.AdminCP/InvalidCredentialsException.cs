using System;

namespace CMPR.AdminCP
{
    internal class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string message)
            : base(message)
        {
        }
    }
}