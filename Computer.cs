using System;

namespace GA_AggregationAndContainment
{
    internal class Computer
    {
        // Private fields to store information about the computer components
        string _cpu;            // Represents the CPU (Central Processing Unit)
        string _mother;         // Represents the motherboard
        GraphicsCard _graphicsCard; // Represents the graphics card

        // Constructor to create a Computer object with a specified graphics card
        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard; // Initialize the graphics card field with the provided graphics card object
        }

        // Additional code or properties related to computer components can be added here

        // Difference Between Containment and Aggregation
        // You can explain the concepts of containment and aggregation here if needed for this class.
    }
}


// computer
// cpu
// motherboard
// ram
// power supply
// fan
// hard drive
// graphics card