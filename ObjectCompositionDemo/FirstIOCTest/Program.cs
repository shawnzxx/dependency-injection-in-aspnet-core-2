using Microsoft.Extensions.DependencyInjection;
using System;

namespace FirstIOCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st always register with ServiceCollection
            var container = new ServiceCollection();

            //This still are concrete calsses we should mapping interface to them and reduce coupling even more.
            container.AddScoped<Callee>();
            container.AddScoped<Caller>();

            Console.Clear();

            var provider = container.BuildServiceProvider();
            //retriev from ServiceProvider
            var caller = provider.GetService<Caller>();
            
            caller.DoSomething();
            Console.ReadKey();
        }
    }
}
