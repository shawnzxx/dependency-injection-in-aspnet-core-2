using System.Collections.Generic;

namespace ObjectComposition.Classes
{
    internal class Office3
    {
        private readonly CoffeeMachine _coffeeMaker;

        internal Office3()
        {
            _coffeeMaker = new CoffeeMachine();
        }

        public List<Employee> Employees { get; set; } = new List<Employee>();


        private void StartWorkDay()
        {
            var manager3 = new Manager3();
            manager3.StartDay(_coffeeMaker);
        }
    }
}