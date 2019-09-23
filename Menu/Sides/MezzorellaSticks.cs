using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class MezzorellaSticks : Side
    {
        private Size stickSize;
        /// <summary>
        /// Basic Construct for Mezzorella Sticks Side. Sets the default size to small
        /// </summary>
        public MezzorellaSticks()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets a list of the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Gets the size that the side is at and adjusts the price and calories of the side when the size is set.
        /// </summary>
        public override Size Size
        {
            get
            {
                return stickSize;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 540;
                    stickSize = Size.Small;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 610;
                    stickSize = Size.Medium;
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 720;
                    stickSize = Size.Large;
                }
            }
        }
    }
}
