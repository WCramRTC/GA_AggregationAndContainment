using System;

namespace GA_AggregationAndContainment
{
    internal class Engine
    {
        int _hp; // Private field to store the engine's horsepower (hp)

        // Constructor to create an Engine object with a specified horsepower
        public Engine(int hp)
        {
            _hp = hp; // Initialize the horsepower field with the provided value
        }

        // Public property to get and set the engine's horsepower
        public int Hp
        {
            get => _hp; // Getter method returns the current horsepower

            set
            {
                if (value >= 50)
                {
                    _hp = value; // Setter method sets the horsepower if it's greater than or equal to 50
                }
                else
                {
                    throw new Exception("Please enter a valid Horse Power"); // Throws an exception for invalid horsepower values
                }
            }
        }
    }
}
