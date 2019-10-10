using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        public override string ToString()
        {
            string s = "";
            if (sodaSize == Size.Small) s += "Small ";
            else if (sodaSize == Size.Medium) s += "Medium ";
            else if (sodaSize == Size.Large) s += "Large ";

            if (this.Flavor == SodasaurusFlavor.Cherry) s += "Cherry ";
            else if (this.Flavor == SodasaurusFlavor.Chocolate) s += "Chocolate ";
            else if (this.Flavor == SodasaurusFlavor.Cola) s += "Cola ";
            else if (this.Flavor == SodasaurusFlavor.Lime) s += "Lime ";
            else if (this.Flavor == SodasaurusFlavor.Orange) s += "Orange ";
            else if (this.Flavor == SodasaurusFlavor.RootBeer) s += "RootBeer ";
            else if (this.Flavor == SodasaurusFlavor.Vanilla) s += "Vanilla ";
            return s + "Sodasaurus";
        }
    }
}
