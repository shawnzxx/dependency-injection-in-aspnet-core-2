using System.Collections.Generic;

namespace ObjectComposition.Classes
{
    internal class Office2
    {
        private readonly CoffeeMachine _coffeeMaker;

        internal Office2()
        {
            _coffeeMaker = new CoffeeMachine();
        }

        public List<Employee> Employees { get; set; } = new List<Employee>();


        private void StartWorkDay()
        {
            var manager2 = new Manager2();
            manager2.CoffeeMaker = _coffeeMaker;
            manager2.StartDay();
        }
    }
}