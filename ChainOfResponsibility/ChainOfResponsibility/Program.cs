using ChainOfResponsibility.Approver;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var vicePresident = new VicePresident();
            director.SetNext(vicePresident);

            director.ProcessRequest(9999);
            director.ProcessRequest(10001);
        }
    }
}
