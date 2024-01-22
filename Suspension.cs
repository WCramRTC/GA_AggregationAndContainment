using System;

namespace GA_AggregationAndContainment
{
    internal class Suspension
    {
        float _frontBalance; // Private field to store the front balance of the suspension
        float _springyNess;  // Private field to store the springiness of the suspension
        float _rearBalance;  // Private field to store the rear balance of the suspension

        // Constructor to create a Suspension object with specified front balance, springiness, and rear balance
        public Suspension(float frontBalance, float springyNess, float rearBalance)
        {
            _frontBalance = frontBalance; // Initialize the front balance field with the provided value
            _springyNess = springyNess;   // Initialize the springiness field with the provided value
            _rearBalance = rearBalance;   // Initialize the rear balance field with the provided value
        }

        // Public property to get and set the front balance of the suspension
        public float FrontBalance
        {
            get => _frontBalance; // Getter method returns the current front balance value

            // Setter method allows setting the front balance within the range of -1 to 1
            set
            {
                if (value >= -1 && value <= 1)
                {
                    _frontBalance = value; // Set the new front balance if it's within the valid range
                }
            }
        }

        // Public property to get and set the springiness of the suspension
        public float SpringyNess { get => _springyNess; set => _springyNess = value; }

        // Public property to get and set the rear balance of the suspension
        public float RearBalance { get => _rearBalance; set => _rearBalance = value; }
    }
}
