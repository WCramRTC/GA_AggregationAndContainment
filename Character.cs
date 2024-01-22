using System;

namespace GA_AggregationAndContainment
{
    internal class Character
    {
        // Private fields to store character's name and weight
        string _name;
        int _weight;

        // Constructor to create a Character object with a given weight and name
        public Character(int weight, string name)
        {
            _weight = weight; // Initialize the weight field with the provided value
            _name = name;     // Initialize the name field with the provided value
        }

        // Public property to get and set the character's weight
        public int Weight { get => _weight; set => _weight = value; }

        // Public property to get and set the character's name
        public string Name { get => _name; set => _name = value; }
    }
}
