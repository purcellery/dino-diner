using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{ 
    public abstract class Drink : IMenuItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<String> Ingredients { get; }

        public abstract Size Size { get; set; }

        public bool Ice { get; set; }

        /// <summary>
        /// Basic Constructor for the parent Drink Class
        /// </summary>
        public Drink()
        {
            this.Ice = true;
            Size = Size.Small;
        }

        /// <summary>
        /// Method to set the Ice property to false as per the desire of the customer.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
        public abstract string ToString();
    }
}
