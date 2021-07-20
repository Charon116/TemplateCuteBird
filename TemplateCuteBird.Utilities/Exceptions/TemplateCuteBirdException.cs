using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCuteBird.Utilities.Exceptions
{
    public class TemplateCuteBirdException : Exception
    {
        public TemplateCuteBirdException()
        {
        }

        public TemplateCuteBirdException(string message) : base(message)
        {
        }

        public TemplateCuteBirdException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
