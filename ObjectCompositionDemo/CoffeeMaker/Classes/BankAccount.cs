using System;

namespace CoffeeMaker.Classes
{
    internal class BankAccount : IDisposable
    {
        public int AccountNumber { get; set; }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}