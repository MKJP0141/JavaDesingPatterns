using System;

namespace VisitorPractice
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