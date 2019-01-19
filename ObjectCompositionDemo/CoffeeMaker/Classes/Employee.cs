using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Classes
{
    internal class Employee : IDisposable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BankAccount Account { get; set; }

        public void Dispose()
        {
            //if have account instance is disposed we need to dispose account also
            Account?.Dispose();
        }
    }
}
