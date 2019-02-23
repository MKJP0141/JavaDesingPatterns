using System;
using VisitorReal.Model;
using Xunit;

namespace VisitorReal.Test
{
    public class VisitorRealTest
    {
        private Employees _employees;

        public VisitorRealTest()
        {
            _employees = new Employees();

            _employees.Attach(new Clerk());
            _employees.Attach(new Director());
            _employees.Attach(new President());
        }

        [Fact]
        public void IncomeVisitorTest()
        {
            _employees.Accept(new IncomeVisitor());
            
            Assert.Equal(27500, (int)(_employees.Get("Hank").Income));
            Assert.Equal(38500, (int)(_employees.Get("Elly").Income));
        }

        [Fact]
        public void VacationVisitorTest()
        {
            _employees.Accept(new VacationVisitor());
        
            Assert.Equal(24, _employees.Get("Dick").VacationDays);
            Assert.Equal(19, _employees.Get("Elly").VacationDays);
        }
    }
}
