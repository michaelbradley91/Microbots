using System;

namespace Microbots.Models.Exceptions
{
    public class MicrobotsException : Exception
    {
        public string Summary { get; private set; }
        public string Detail { get; private set; }

        public MicrobotsException(string summary, string detail)
        {
            Summary = summary;
            Detail = detail;
        }
    }
}
