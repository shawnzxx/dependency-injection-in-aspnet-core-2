using CoffeeMaker.interfaces;
using System;

namespace CoffeeMaker.Classes
{
    public class CoffeeMachine : ICoffeeProducer
    {
        public int WaterTemperature { get; set; }
        public void ProduceCoffee()
        {
            Console.WriteLine("Coffee Machine is making coffee!");
        }
    }
}