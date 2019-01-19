namespace ObjectComposition.Classes
{
    internal class Manager3 : Employee
    {
        public int Rank { get; set; }

        //This is Method Injection
        //need to pass another object through method
        public void StartDay(CoffeeMachine coffeeMaker)
        {
            //?.XXX means if _coffeeMaker object is not null, invoke method
            coffeeMaker?.MakeCoffee();
        }
    }
}