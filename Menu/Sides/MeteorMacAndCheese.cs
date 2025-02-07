﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        private Size macSize;
        /// <summary>
        /// Basic Constructor for Meteor Mac and Cheese Side. Sets the default size to small
        /// </summary>
        public MeteorMacAndCheese()
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
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        /// <summary>
        /// Gets the size that the side is at and adjusts the price and calories of the side when the size is set.
        /// </summary>
        public override Size Size
        {
            get
            {
                return macSize;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 420;
                    macSize = Size.Small;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 490;
                    macSize = Size.Medium;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 520;
                    macSize = Size.Large;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            if (macSize == Size.Small) s += "Small ";
            else if (macSize == Size.Medium) s += "Medium ";
            else if (macSize == Size.Large) s += "Large ";
            return s + "Meteor Mac and Cheese";
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
