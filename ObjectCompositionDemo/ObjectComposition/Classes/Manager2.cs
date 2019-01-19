namespace ObjectComposition.Classes
{
    internal class Manager2 : Employee
    {
        //This is Property Injection
        //when create object of Manager2 we can assign another object into this property
        public CoffeeMachine CoffeeMaker { get; set; }

        public int Rank { get; set; }

        public void StartDay()
        {
            //?.XXX means if _coffeeMaker object is not null, invoke method
            CoffeeMaker?.MakeCoffee();
        }
    }
}