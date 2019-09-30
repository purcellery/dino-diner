using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }
    public class Sodasaurus : Drink
    {
        private Size sodaSize;

        /// <summary>
        /// Basic Constructor for the Water Drink Class
        /// </summary>
        public Sodasaurus() : base()
        {
            Flavor = SodasaurusFlavor.Cola;
        }
        
        public SodasaurusFlavor Flavor { get; set; }
        
        /// <summary>
        /// Returns a list of the ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar"};
            }
        }

        /// <summary>
        /// Adjusts the price and the calories of the sodasaurus depending on the size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return sodaSize;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 1.50;
                    this.Calories = 112;
                    sodaSize = Size.Small;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 2.00;
                    this.Calories = 156;
                    sodaSize = Size.Medium;
                }
                else if (value == Size.Large)
                {
                    this.Price = 2.50;
                    this.Calories = 208;
                    sodaSize = Size.Large;
                }
            }
        }
    }
}
