using CoffeeMaker.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Classes
{
    internal class EspressoMaker : ICoffeeProducer
    {
        public void ProduceCoffee()
        {
            Console.WriteLine("Espresso Maker is making coffee!");
        }
    }
}
