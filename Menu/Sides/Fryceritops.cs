using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        private Size frySize;
        /// <summary>
        /// Basic Construct for Fryceritops Side. Sets the default size to small
        /// </summary>
        public Fryceritops()
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
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Gets the size that the side is at and adjusts the price and calories of the side when the size is set.
        /// </summary>
        public override Size Size
        {
            get
            {
                return frySize;
            }
            set
            {
                if(value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 222;
                    frySize = Size.Small;
                }
                else if(value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 365;
                    frySize = Size.Medium;
                }
                else if(value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 480;
                    frySize = Size.Large;
                }
            }
        }
    }
}
