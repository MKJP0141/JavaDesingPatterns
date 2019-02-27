using System;
using System.Collections.Generic;
using System.Text;

namespace MoqTest.Model
{
    public interface IEmployee
    {
        string GetFullName();

        void ToCSV(string firstName, string lastName);
    }
}
