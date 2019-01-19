using System;
using System.Collections.Generic;
using System.Text;

namespace FirstIOCTest
{
    class Callee
    {
        public Callee()
        {
            Console.WriteLine("Callee constructor been inited");
        }

        public void Do() {
            Console.WriteLine("Hello World from Callee!");
        }
    }
}
