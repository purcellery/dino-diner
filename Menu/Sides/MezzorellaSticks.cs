using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 610;
                    stickSize = Size.Medium;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 720;
                    stickSize = Size.Large;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            if (stickSize == Size.Small) s += "Small ";
            else if (stickSize == Size.Medium) s += "Medium ";
            else if (stickSize == Size.Large) s += "Large ";
            return s + "Mezzorella Sticks";
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        public override string[] Special
        {
            get
            {
                List<string> s = new List<string>();
                return s.ToArray();
            }
        }
    }
}
