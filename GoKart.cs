using System;

namespace GA_AggregationAndContainment
{
    internal class GoKart
    {
        Engine _engine;          // Private field to store the go-kart's engine
        Character _playerCharacter; // Private field to store the character driving the go-kart

        // Constructor to create a GoKart object with a specified player character
        public GoKart(Character playerCharacter)
        {
            _playerCharacter = playerCharacter; // Initialize the player character field with the provided character object

            // Calculate the initial engine horsepower based on the player character's weight
            _engine = new Engine(250 - (playerCharacter.Weight / 4));
        }

        // Public property to access the go-kart's engine
        internal Engine Engine1
        {
            get => _engine;
        }

        // Method to tweak the go-kart's engine by setting a new horsepower
        public void TweakEngine(int newHp)
        {
            _engine.Hp = newHp; // Set the new engine horsepower using the Engine's property
        }

        // Override the ToString method to provide a custom string representation of the GoKart object
        public override string ToString()
        {
            // Return a formatted string containing the player character's name, weight, and the go-kart's engine horsepower
            return $"Character {_playerCharacter.Name} - Weight: {_playerCharacter.Weight} : Engine Hp {_engine.Hp} ";
        }
    }
}
