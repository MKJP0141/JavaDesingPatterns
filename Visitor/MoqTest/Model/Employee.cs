using System;
using System.Collections.Generic;
using System.Text;

namespace MoqTest.Model
{
    class Employee : IEmployee
    {
        private string _fistName;
        private string _lastName;

        public Employee(string firstName, string lastName)
        {
            _fistName = firstName;
            _lastName = lastName;
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public void ToCSV(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
