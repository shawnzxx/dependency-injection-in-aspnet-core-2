using CoffeeMaker.Classes;
using CoffeeMaker.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Linq;

namespace CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            //we use singleton in here since office should have one machine only
            collection.AddSingleton<ICoffeeProducer, CoffeeMachine>();
            collection.AddSingleton<ICoffeeProducer, EspressoMaker>();
            collection.AddTransient<Manager>();

            var provider = collection.BuildServiceProvider();
            

            //get all kinds of object which as a ICoffeeProducer
            var coffeeMakers = provider.GetServices<ICoffeeProducer>();
            
            foreach (var coffeeMaker in coffeeMakers)
            {
                coffeeMaker.ProduceCoffee();
            }

            //Manager select to drink coffee today
            var manager = provider.GetService<Manager>();
            var coffeeMakersList = provider.GetServices<ICoffeeProducer>();
            var producer = coffeeMakersList.FirstOrDefault(x => x.GetType() == typeof(CoffeeMachine));
            
            manager.StartDay(producer);

            Console.Read();
        }
    }
}
