using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        private Size totSize;
        /// <summary>
        /// Basic Construct for Triceritots Side. Sets the default size to small
        /// </summary>
        public Triceritots()
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
                return totSize;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 352;
                    totSize = Size.Small;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 410;
                    totSize = Size.Medium;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 590;
                    totSize = Size.Large;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            if (totSize == Size.Small) s += "Small ";
            else if (totSize == Size.Medium) s += "Medium ";
            else if (totSize == Size.Large) s += "Large ";
            return  s + "Triceritots";
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
