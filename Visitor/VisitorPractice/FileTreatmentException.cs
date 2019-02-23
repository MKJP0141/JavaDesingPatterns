using System;

namespace Composite
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException()
        {
        }

        public FileTreatmentException(string message) : base(message)
        {
        }
    }
}