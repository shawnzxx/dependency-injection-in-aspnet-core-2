namespace ObjectComposition.Classes
{
    internal class Manager : Employee
    {
        //This is Constructor Injection
        //inject object through constructor of another object
        //So the 2nd object can use injected object
        private readonly CoffeeMachine _coffeeMaker;
        public Manager(CoffeeMachine coffeeMaker)
        {
            _coffeeMaker = coffeeMaker;
        }

        public int Rank { get; set; }

        public void StartDay()
        {
            //?.XXX means if _coffeeMaker object is not null, invoke method
            _coffeeMaker?.MakeCoffee();
        }
    }
}