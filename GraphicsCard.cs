using System;

namespace GA_AggregationAndContainment
{
    public class GraphicsCard
    {
        public enum Brand { Nvidia, AMD, Intel } // An enumeration representing different graphics card brands

        Brand _graphicsCardBrand; // Private field to store the graphics card's brand

        // Constructor to create a GraphicsCard object with a specified brand
        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand; // Initialize the graphics card's brand field with the provided value
        }
    }
}
