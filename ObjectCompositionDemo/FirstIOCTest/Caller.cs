using System;
using System.Collections.Generic;
using System.Text;

namespace FirstIOCTest
{
    class Caller
    {
        private readonly Callee _callee;
        public Caller(Callee callee)
        {
            _callee = callee;
            Console.WriteLine("Caller constructor been inited");
        }

        public void DoSomething() {
            _callee.Do();
        }
    }
}
