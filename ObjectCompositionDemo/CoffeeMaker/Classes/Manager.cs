using CoffeeMaker.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Classes
{
    internal class Manager : Employee
    {
        private readonly ICoffeeProducer _defaultCoffeeProducer;
        public int Rank { get; set; }

        public Manager(ICoffeeProducer defaultCoffeeProducer)
        {
            _defaultCoffeeProducer = defaultCoffeeProducer;
        }
        public void StartDay(ICoffeeProducer coffeeProducer) {
            if (coffeeProducer != null)
            {
                coffeeProducer.ProduceCoffee();
            }
            else {
                _defaultCoffeeProducer?.ProduceCoffee();
            }
        }
    }
}
