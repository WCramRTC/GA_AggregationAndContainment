namespace GA_AggregationAndContainment
{
    internal class Program
    {
        static List<Engine> _engines; // Declare a list of Engine objects.

        static void Main(string[] args)
        {
            _engines = new List<Engine>(); // Initialize the list of engines.

            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel); // Create a GraphicsCard object with the Intel brand.

            Computer comp = new Computer(gc); // Create a Computer object, passing the GraphicsCard as a component.

            Engine fastEngine = new Engine(250); // Create a fast Engine with a power of 250.
            Engine slowerEngine = new Engine(120); // Create a slower Engine with a power of 120.

            _engines.Add(fastEngine); // Add the fast engine to the list of engines.
            _engines.Add(slowerEngine); // Add the slower engine to the list of engines.

            Suspension suspension = new Suspension(-.4f, 5, .5f); // Create a Suspension object with specific parameters.

            Car car = new Car("Ford", "Escort", fastEngine, suspension); // Create a Car object with a brand, model, fastEngine, and suspension.
            Console.WriteLine(car.ToString()); // Print information about the car.

            Character donkeyKong = new Character(150, "Donkey Kong"); // Create a Character object named Donkey Kong with a weight of 150.
            GoKart goKart = new GoKart(donkeyKong); // Create a GoKart object, passing Donkey Kong as the driver.

            Console.WriteLine(goKart); // Print information about the GoKart and its driver.

            Character toad = new Character(50, "Toad"); // Create another Character object named Toad with a weight of 50.
            GoKart goKartToad = new GoKart(toad); // Create another GoKart object, passing Toad as the driver.
            Console.WriteLine(goKartToad); // Print information about the second GoKart and its driver.

            Console.WriteLine("Before our try catch");

            // Try to tweak the engine of goKartToad with a negative value.
            goKartToad.TweakEngine(-50);

            try
            {
                Console.WriteLine("We reached this line of code");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Handle and print any exceptions that occur.
            }

            Console.WriteLine("This is after our try catch");
        }
    }
}
