using System;

namespace GA_AggregationAndContainment
{
    internal class Car
    {
        // Private fields to store car make, model, engine, and suspension
        string _make;
        string _model;
        Engine _engine;
        Suspension _suspension;

        // Constructor to create a Car object with make, model, engine, and an optional suspension component
        public Car(string make, string model, Engine engine, Suspension suspension = null)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _suspension = suspension;
        }

        // Method to swap the car's engine with a new engine object
        public void SwapEngine(Engine engine)
        {
            if (engine != null)
            {
                _engine = engine; // Assign the new engine to the car
            }
        }

        // Method to swap the car's engine by specifying its horsepower (creates a new engine)
        public void SwapEngine(int hp)
        {
            _engine = new Engine(hp); // Create a new engine with the given horsepower and assign it to the car
        }

        // Override the ToString method to provide a custom string representation of the Car object
        public override string ToString()
        {
            // Return a formatted string containing car make, model, engine horsepower, and suspension details
            return $"{_make} {_model} : {_engine.Hp} :\n" +
                $"Suspension: Front Balance {_suspension.FrontBalance}\n" +
                $"Rear Balance: {_suspension.RearBalance}\n" +
                $"Springyness: {_suspension.SpringyNess}";
        }
    }
}
